using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BankApp
{
    public class RemoveUser
    {
        static string filePath = "C:/Users/Nitro/source/repos/BankApp/Database/UsersDb.json";
        static string jsonData = File.ReadAllText(filePath);

        public void RemoveUserByIndex()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();
            Console.WriteLine("Userni faqatgina ID raqami orqali o'chirish mumkin");
            Console.Write("Userni o'chirish uchun uning id raqamini kiriting:\n\\> ");
            int id = int.Parse(Console.ReadLine());

            userList.RemoveAll(x => x.Id == id);



            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}