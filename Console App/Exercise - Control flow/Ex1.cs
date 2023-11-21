using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Control_flow
{
    internal class Ex1
    {
        public void ValidNum()
        {
            Console.WriteLine("Enter a valid number from 1 to 10");
            var input = int.Parse(Console.ReadLine());

            if(input >=1 && input <11)
            {
                Console.WriteLine(String.Format("Ex:1 - Valid Input - {0}",input));
            }else
            {
                Console.WriteLine(String.Format("Ex:1 - Invalid Input - {0}", input));
            }
        }

        public void MaxNum()
        {
            Console.WriteLine("Enter two numbers \n");
            Console.WriteLine("A : ");
            try
            {
                var inputA = int.Parse(Console.ReadLine());
                Console.WriteLine("B : ");
                var inputB = int.Parse(Console.ReadLine());
                if (inputA > inputB)
                {
                    Console.WriteLine("A is Greater");
                }
                else if (inputB == inputA)
                {
                    Console.WriteLine("Both are equal");
                }
                else
                {
                    Console.WriteLine("B is greater");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        public void SpeedLimit()
        {
            try
            {
                var demeritPoint = 0;
                var speedLimit = 60;
                Console.WriteLine("Enter Speed Limit");
                var speed = int.Parse(Console.ReadLine());
                if (speed <= speedLimit)
                {
                    Console.WriteLine("Ok, you may Go");
                }
                else
                {
                    var excessiveSpeed = speed - speedLimit;
                    demeritPoint = excessiveSpeed / 5;
                    Console.WriteLine("Speed Limit : " + speedLimit);
                    Console.WriteLine("Your Speed : " + speed);
                    Console.WriteLine("Your Demerit Points : " + demeritPoint);
                    if(demeritPoint>12)
                    {
                        Console.WriteLine("Your License Suspended");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Enter valid Speed in Numbers");
            }
            

        }
    }
}
