
using System.Runtime.CompilerServices;

namespace StaticExtensionmethodEnum
{
    public class User 
    {
        public string Name { get; set; }
        public string Surname { get; set; }

       public RegistrationMonth RegistrationMonth { get; set; }

        public string PIN { get

            {

                return pin;
            
            
            
            }



            set
            {
             if (value.IsPINRight())
                {
                    pin= value;

                }
             else
                {
                    throw new Exception("parol duzgun deyil");


















                        }


            }
        
                
                
                 }
        private string pin;

        public User(string name,string surname,RegistrationMonth registrationMonth, string pin)
        {
            Name= name;
            Surname= surname;
            RegistrationMonth = registrationMonth;
            PIN= pin;
        }


        public string GetDetails()
        {
            return $"{Name} {Surname} {RegistrationMonth} {PIN}";


        }


    }
}
