using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BankApp
{
    public class UpdateUser
    {
        static string filePath = "C:/Users/Nitro/source/repos/BankApp/Database/UsersDb.json";
        static string jsonData = File.ReadAllText(filePath);

        public void Update()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();
            Console.Write("Id of User: ");
            int id = int.Parse(Console.ReadLine());

            userList.RemoveAll(x => x.Id == id);
            Console.WriteLine("Update User");
            Console.WriteLine("Ushbu forma yordamida User ma'lumotlarini qayta kiriting:" +
                "\n\\> ID: raqam" +
                "\n\\> Ism: Falonchi" +
                "\n\\> Familiya: Pistonchi" +
                "\n\\> Soqqasi: Son");
            userList.Add(new UserModel()
            {
                Id = int.Parse(Console.ReadLine()),
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Balance = decimal.Parse(Console.ReadLine())
            });
            Console.WriteLine("User ma'lumotlari kiritildi!");


            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
