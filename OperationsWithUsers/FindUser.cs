using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankApp
{
    public class FindUser
    {
        static string filePath = "C:/Users/Nitro/source/repos/BankApp/Database/UsersDb.json";
        static string jsonData = File.ReadAllText(filePath);

        public void FindUserById()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();
            Console.Write("Id ni kiriting:\n\\> ");
            int id = int.Parse(Console.ReadLine());

            var userjon = userList.Select(
                user => new
                {
                    id = user.Id,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    balance = user.Balance
                });

            foreach (var item in userjon)
            {
                if (id == item.id)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Ish bitdi!");
                }
                else if (id != item.id)
                {
                    Console.WriteLine("Ish bitdi! Ammo User topilmadi");
                    break;
                }
            }

            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }

        public void FindUserByFirstName()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();
            Console.Write("Ismini kiriting:\n\\> ");
            string firstName = Console.ReadLine();

            var userjon = userList.Select(
                user => new
                {
                    id = user.Id,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    balance = user.Balance
                });

            foreach (var item in userjon)
            {
                if (firstName == item.firstName)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Ish bitdi!");
                }
                else if (firstName != item.firstName)
                {
                    Console.WriteLine("Ish bitdi! Ammo User topilmadi");
                    break;
                }
            }

            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }
        public void FindUserByLastName()
        {
            var userList = JsonConvert.DeserializeObject<List<UserModel>>(jsonData)
                ?? new List<UserModel>();
            Console.Write("Familiyasini kiriting:\n\\> ");
            string lastName = Console.ReadLine();

            var userjon = userList.Select(
                user => new
                {
                    id = user.Id,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    balance = user.Balance
                });

            foreach (var item in userjon)
            {
                if (lastName == item.lastName)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Ish bitdi!");
                }
                else if (lastName != item.lastName)
                {
                    Console.WriteLine("Ish bitdi! Ammo User topilmadi");
                    break;
                }
            }

            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}