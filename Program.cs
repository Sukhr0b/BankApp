//  CLASS,
//  INTERFACE,
//  FUNKSIYA,
//  EXTENSION METHOD,
//  LINQ,
//  LIST,
//  FILE DIRECTORY,
//  POLYMORPHISM

using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HYPER MEGA SUPER ULTRA EXTRA GIGA META BANK APP :)");
            Console.WriteLine("\\> 1 -> Yangi User qo'shish\n" +
                "\\> 2 -> Userni o'chirish\n" +
                "\\> 3 -> Userni update qilish\n" +
                "\\> 4 -> Userlarning barchasini ko'rish\n" +
                "\\> 5 -> User haqida ma'lumot olish\n");

            Console.Write("\\> ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                AddUser addUser = new AddUser();
                addUser.AddUserByFillingForm();
            }
            else if (number == 2)
            {
                RemoveUser removeUser = new RemoveUser();
                removeUser.RemoveUserByIndex();
            }
            else if (number == 3)
            {
                UpdateUser updateUser = new UpdateUser();
                updateUser.Update();
            }
            else if (number == 4)
            {
                GetAllUsers getAllUsers = new GetAllUsers();
                getAllUsers.GetAllUserss();
            }
            else if (number == 5)
            {
                FindUser findUser = new FindUser();
                Console.WriteLine("\\> Qanday topilsin?" +
                    "\n\\> 1 -> ID orqali" +
                    "\n\\> 2 -> Ism orqali" +
                    "\n\\> 3 -> Familiya orqali");
                int findNum = int.Parse(Console.ReadLine());

                if (findNum == 1)
                    findUser.FindUserById();
                else if (findNum == 2)
                    findUser.FindUserByFirstName();
                else if (findNum == 3)
                    findUser.FindUserByLastName();
            }
            Console.ReadKey();
        }
    }
}