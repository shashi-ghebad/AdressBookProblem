using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UC10_Exception
{
    class Program
    {
        public static string userName;
        public static string lastName;
        public static string email;
        public static string mobileNumber;
        public static string password;

        public static bool UserName(string userName)
        {
            try
            {
                if (Regex.IsMatch(userName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$"))
                    return true;
                else
                    throw new UCException(UCException.ExceptionTypes.Invalid_UserName, "Wrong username entered");
            }
            catch (UCException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    public static bool LastName(string lastName)
        {
            try 
            { 
            if( Regex.IsMatch(lastName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$"))
            return true;
                else
                throw new UCException(UCException.ExceptionTypes.Invalid_lastName, "Wrong lastname entered");
        }
            catch (UCException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Email(string email)
        {
            try
            {
                if (Regex.IsMatch(email, @"^[A-Z0-9a-z]+([.#_+-][A-Z0-9a-z]+)*[@][A-Z0-9a-z]+([.][A-Za-z]{2,3}){0,2}$"))
                    return true;
                else
                    throw new UCException(UCException.ExceptionTypes.Invalid_Email, "Wrong email entered");
            }
            catch (UCException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool MobileNumber(string mobileNumber)
        {
            try
            {
            if( Regex.IsMatch(mobileNumber, @"^[0-9]{2}[ ][0-9]{10}$"))
                 return true;
                else
                throw new UCException(UCException.ExceptionTypes.Invalid_MobileNumber, "Wrong MobileNumber entered");
        }
            catch (UCException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
}

        public static bool Password(string password)
        {
            try 
            {
            if( Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=[^.#+*/$@!%^&_-]*[.#+*/$@!%^&_-][^.#+*/$@!%^&_-]*$)[A-Za-z0-9.#+*/$@!%^&_-]{8,}$"))
                return true;
                else
                throw new UCException(UCException.ExceptionTypes.Invalid_Password, "Wrong Password entered");
        }
                catch (UCException ex)
{
                Console.WriteLine(ex.Message);
                return false;
}
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Valid User Name: ");
            userName = Console.ReadLine();
            Console.WriteLine(UserName(userName) + "\n");

            Console.WriteLine("Enter a Valid Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine(LastName(lastName) + "\n");

            Console.WriteLine("Enter a Valid Email: ");
            email = Console.ReadLine();
            Console.WriteLine(Email(email) + "\n");

            Console.WriteLine("Enter a Valid Mobile Number: ");
            mobileNumber = Console.ReadLine();
            Console.WriteLine(MobileNumber(mobileNumber) + "\n");

            Console.WriteLine("Enter a Valid Password: ");
            password = Console.ReadLine();
            Console.WriteLine(Password(password) + "\n");

            Console.ReadKey();
        }
    }
}
