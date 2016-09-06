using System;
using System.Collections.Generic;

namespace Education
{
    class Program
    {
        private static List<User> users = new List<User>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter either create,list, or math");
                string input = Console.ReadLine();
                switch (input)
                {
                        case("create"):
                        users.Add(createUser());
                        break;
                        case("list"):
                            foreach (User user in users)
                            {
                                Console.WriteLine(user.ToString());
                            }
                        break;
                        case("math"):
                        math();
                        break;
                        default:
                        Console.WriteLine("Invalid request");
                        break;
                }
            }

        }

        private static User createUser()
        {
            Console.WriteLine("Enter the users's First name, Last name, and age in  that order");
            Console.Write("First Name:");
            string firstName = Console.ReadLine();
            Console.Write("Last name:");
            string lastName = Console.ReadLine();
            string ageInput;
            int age;
            do
            {
                Console.Write("Age:");
                ageInput = Console.ReadLine();

            } while ((!Int32.TryParse(ageInput, out age)));
            return new User(firstName,lastName,age);

        }

        private static void math()
        {
            string instructions =
                "Pleast enter an operation first (add,subtract,multiply,divide,modulus) then enter two numbers you would like the operation applied to";

            Console.WriteLine(instructions);
            string operation;
            do
            {
                Console.Write("Operation:");
                operation = Console.ReadLine();
            } while (!isValidOperation(operation));
            int firstNumber;
            do
            {
                Console.Write("First number:");

            } while (!Int32.TryParse(Console.ReadLine(), out firstNumber));

            int secondNumber;
            do
            {
                Console.Write("Second number:");

            } while (!Int32.TryParse(Console.ReadLine(), out secondNumber));

            operation = operation.ToLower();

            switch (operation)
            {
                    case("add"):
                    Console.WriteLine(firstNumber+secondNumber);
                    break;
                    case("subtract"):
                    Console.WriteLine(firstNumber-secondNumber);
                    break;
                    case ("multiply"):
                    Console.WriteLine(firstNumber*secondNumber);
                    break;
                    case("divide"):
                    Console.WriteLine(firstNumber/secondNumber);
                    break;
                    case("mod"):
                    case("modulus"):
                    Console.WriteLine(firstNumber%secondNumber);
                    break;

            }

        }

        private static bool isValidOperation(string operation)
        {
           string[] operations = {"add","subtract","multiply","divide","modulus","mod"};

            foreach (string s in operations)
            {
                if (s.Equals(operation,StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }


            return false;
        }
    }


}


