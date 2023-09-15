﻿
namespace TestHello
{
    class Program 
    {
        static void Main(string[] args) {
            int age = 22;
            int agePlusOne = age + 1;
            Console.WriteLine(agePlusOne);

            string sayHello(string firstName, string lastName)
             {
                return  $"Hello, {firstName} { lastName }";
            }

            int addTwoNumber(int a, int b) => a + b;

            int myNewVal = addTwoNumber(age, agePlusOne);

            Console.WriteLine(myNewVal);

            (string, int) returnMultipleValues(string surname, string username, int age) {
                string hello = sayHello(surname, username);
                return (hello, age);
            }
            Console.WriteLine(returnMultipleValues("Diabene", "yawaddo", 30));
        

            int i = 0;

            while (i < 10) {
                Console.WriteLine(i);
                i++;
            }

            string day = "friday";

            switch (day) {
                case "monday":
                    Console.WriteLine("the best");
                    break;
                case "tuesday":
                case "wednesday":
                Console.WriteLine("Beauty of fall through!");
                break;
                default:
                Console.WriteLine("not important");
                break;
            }

            bool catchErrors = true;

            try {
                char novalid = 'c';
                Console.WriteLine(novalid);
            } catch (Exception Ex) when (catchErrors == true) {
                Console.WriteLine(Ex.Message);
            }

            int number = int.MaxValue;

            checked {
                int err = number;
                Console.WriteLine(err);
            }

            int calculateForce(int mass, int acceletation) {
                if (acceletation == 0) {
                    throw new Exception("acceletation should not be zero");
                }

                return mass * acceletation;
            }

            int force = calculateForce(number, 2);
            Console.WriteLine(force);
     
        }



    }
}

