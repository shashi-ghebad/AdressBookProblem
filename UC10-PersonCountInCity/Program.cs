﻿using System;
using System.Collections.Generic;


namespace UC10_PersonCountInCity
{
    class Program
    {

        public static string first_Name;
        public static string last_Name;
        public static string address;
        public static string city;
        public static string state;
        public static int zip;
        public static int phone_number;
        public static string email;
        public static string edit_First_Name;
        public static string edit_Last_Name;
        public static string delete_First_Name;
        public static string delete_Last_Name;
       

        static void Main(string[] args)
        {
            AddContacts obj = new AddContacts();
            Console.WriteLine(" WELCOME TO ADDRESS BOOK SYSTEM PROGRAM \n");

            Console.WriteLine("How many Address Book do you want(Expected Integer): ");
            int NUM_OF_ADDRESS_BOOK = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= NUM_OF_ADDRESS_BOOK; j++)
            {
                Console.WriteLine("Type the name of the Address Book: ");
                string address_Book = Console.ReadLine();

                Console.WriteLine(" How many people's Information is needed to be Added(Expected Integer): ");
                int NUM_OF_PEOPLE = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= NUM_OF_PEOPLE; i++)
                {
                    Console.WriteLine("\n Write First Name of the person: ");
                    first_Name = Console.ReadLine();
                    Console.WriteLine("\n Write Last Name of the person: ");
                    last_Name = Console.ReadLine();
                    Console.WriteLine("\n Write Address of the person: ");
                    address = Console.ReadLine();
                    Console.WriteLine("\n Write City of the person: ");
                    city = Console.ReadLine();
                    Console.WriteLine("\n Write State of the person: ");
                    state = Console.ReadLine();
                    Console.WriteLine("\n Write Zip of the person: ");
                    zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Write Phone_number of the person: ");
                    phone_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Write Email of the person: ");
                    email = Console.ReadLine();

                    obj.Assign(address_Book, first_Name, last_Name, address, city, state, zip, phone_number, email);
                }
                obj.Check_Duplicate(address_Book);
                obj.Show(address_Book);

                Console.WriteLine("\n Do you want to edit any person Information then reply with 'y' or 'n': ");
                string y_n = Console.ReadLine();
                if (y_n == "y")
                {
                    Console.WriteLine("Enter the first name of the person you want to edit information: ");
                    edit_First_Name = Console.ReadLine();
                    Console.WriteLine("Enter the first name of the person you want to edit information: ");
                    edit_Last_Name = Console.ReadLine();
                    obj.Edit(edit_First_Name, edit_Last_Name);
                    obj.Show(address_Book);
                }

                Console.WriteLine("\n Do you want to delete any person Information then reply with 'y' or 'n': ");
                string y_n_1 = Console.ReadLine();
                if (y_n_1 == "y")
                {
                    Console.WriteLine("Enter the first name of the person you want to delete information: ");
                    delete_First_Name = Console.ReadLine();
                    Console.WriteLine("Enter the first name of the person you want to delete information: ");
                    delete_Last_Name = Console.ReadLine();
                    obj.delete(delete_First_Name, delete_Last_Name);
                    obj.Show(address_Book);
                }

            }

            Console.WriteLine("\n------PRINT THE NUMBER OF PERSONS BY CITY OR STATE------\n");

            

            obj.count_By_City_Or_State();

            AddContacts.printall();
            Console.ReadKey();
        }
    }
}
 