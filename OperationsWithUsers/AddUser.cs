using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BankApp
{
    public class AddUser
    {
        static string filePath = "C:/Users/Nitro/source/repos/BankApp/Database/UsersDb.json";
        static string jsonData = File.ReadAllText(filePath);

        public void AddUserByFillingForm()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
            ?? new List<UserModel>();
            Console.WriteLine("Ushbu forma yordamida User ma'lumotlarini kiriting:" +
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
            Console.WriteLine("User qo'shildi!");

            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
