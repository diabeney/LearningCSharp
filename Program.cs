
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
        }

        
    }
}

