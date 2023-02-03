using System.Security.Cryptography.X509Certificates;

namespace StaticExtensionmethodEnum
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            var user1 = new User("Azer", "kerimov", RegistrationMonth.July, "pp89654");

            Console.WriteLine(user1.GetDetails());

            var user2 = new User("Fatima", "Kerimova", RegistrationMonth.August, "U78I257");
            Console.WriteLine(user2.GetDetails());

            var user3 = new User("Azerrrr", "kerimovggg", RegistrationMonth.September, "pp8egv7");

            Console.WriteLine(user3.GetDetails());

            var user4 = new User("Aztt", "Gerayli", RegistrationMonth.February, "UY89654");

            Console.WriteLine(user4.GetDetails());

            var user5 = new User("Azerrrr", "FFF", RegistrationMonth.December, "RE89654");

            Console.WriteLine(user5.GetDetails());




        }











    }










}

