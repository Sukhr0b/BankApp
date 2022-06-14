using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankApp
{
    public class GetAllUsers
    {
        static string filePath = "C:/Users/Nitro/source/repos/BankApp/Database/UsersDb.json";
        static string jsonData = File.ReadAllText(filePath);

        public void GetAllUserss()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();

            var eachUser = userList.Select(
                user => new
                {
                    id = user.Id,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    balance = user.Balance
                });

            foreach (var eachOne in eachUser)
            {
                Console.WriteLine(eachOne);
            }
        }
    }
}
