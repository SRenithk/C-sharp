using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Classes_and_Objects
{
    public class Enums
    {
        public enum ShippingMethod
        { 
            RegularAirMail=1,
            RegisteredAirMail=2,
            Express=3
        }
        public void ImplementEnum()
        {
            //enum to external data
            var method = ShippingMethod.Express;
            Console.WriteLine("\nImplementation Enum");
            Console.WriteLine(method);

            //external Id to enum
            var Id = 2;
            Console.WriteLine((ShippingMethod)Id);

            //external string to enum
            var methodName = "Express";
            //typeof fetches type of ShippingMethod
            var res = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(res);
        }
    }
}
