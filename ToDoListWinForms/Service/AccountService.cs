using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToDoListWinForms.Models;

namespace ToDoListWinForms.Service
{
    internal class AccountService
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string filePath = Path.Combine(desktopPath, "data.bin");

        public static void CreateBinFile()
        {
            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath)) { }
            }
        }

        public static void SaveDataToFile(RegistrationModel registration)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(registration.Email);
                    binaryWriter.Write(GetPasswordHash(registration.Password));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error while saving your data");
            }
        }

        public static string GetPasswordHash(string password)
        {
            SHA512 sha512 = SHA512.Create();

            return Convert.ToBase64String(sha512.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidLogin(string email, string password)
        {
            if(File.Exists(filePath))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    while(fileStream.Position < fileStream.Length)
                    {
                        string storedEmail = binaryReader.ReadString();
                        string storedPasswordHash = binaryReader.ReadString();

                        if(storedEmail == email && storedPasswordHash == GetPasswordHash(password))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
