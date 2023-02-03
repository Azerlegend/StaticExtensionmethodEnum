using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionmethodEnum
{
    public static class Extension
    {




        public static bool IsPINRight(this string  pin ) 
        {
        if(pin.Length ==7 && pin==pin.ToUpper() )
                
                return true;


        else
            {
                return false;
            }
        
        
        
        
        }
    }
}
