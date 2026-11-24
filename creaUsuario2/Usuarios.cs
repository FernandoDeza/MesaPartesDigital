using System;
using System.IO;
using System.Security.Cryptography;

namespace formulario_creacion_de_cuenta
{
    public static class Usuarios
    {
        // Ubicacion del archivo de usuarios
        private static string fichero = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "MesaPartesDigital", "usuarios.dat");

        // Verificar si el usuario ya existe
        public static bool verificaUsuario(string usuario)
        {
            bool band = false;

            if (File.Exists(fichero) == false)
            {
                return false;
            }

            using (BinaryReader br = new BinaryReader(
                new FileStream(fichero, FileMode.Open, FileAccess.Read)))
            {
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string correo = br.ReadString();
                    string salt = br.ReadString();
                    string clave = br.ReadString();

                    if (correo == usuario.Trim().ToLowerInvariant())
                    {
                        band = true;
                        break;
                    }
                }
            }

            return band;
        }

        // Proteger la contraseña
        private static string protegerClave(string clave, byte[] salt)
        {
            using (Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(
                clave, salt, 600000, HashAlgorithmName.SHA256))
            {
                return Convert.ToBase64String(hash.GetBytes(32));
            }
        }

        // Registrar una nueva cuenta
        public static void registrarUsuario(string usuario, string clave)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fichero));

            if (verificaUsuario(usuario))
            {
                throw new InvalidOperationException("El usuario ya existe.");
            }

            byte[] salt = new byte[16];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (BinaryWriter bw = new BinaryWriter(
                new FileStream(fichero, FileMode.Append, FileAccess.Write)))
            {
                bw.Write(usuario.Trim().ToLowerInvariant());
                bw.Write(Convert.ToBase64String(salt));
                bw.Write(protegerClave(clave, salt));
            }
        }

        // Validar usuario y contraseña
        public static bool validarUsuario(string usuario, string clave)
        {
            bool band = false;

            if (File.Exists(fichero) == false)
            {
                return false;
            }

            using (BinaryReader br = new BinaryReader(
                new FileStream(fichero, FileMode.Open, FileAccess.Read)))
            {
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string correo = br.ReadString();
                    string salt = br.ReadString();
                    string contraseña = br.ReadString();

                    if (correo == usuario.Trim().ToLowerInvariant())
                    {
                        if (contraseña == protegerClave(
                            clave, Convert.FromBase64String(salt)))
                        {
                            band = true;
                        }

                        break;
                    }
                }
            }

            return band;
        }
    }
}