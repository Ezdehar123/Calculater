using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculater1 cal = new Calculater1();

            Console.WriteLine(" Enter 1st number" );
            cal.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter 2nd number ");
            cal.num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the operand ");
            cal.sighn= Console.ReadLine();
            cal.Displayres();
            Console.Read();

        }

    }
}

public class Calculater1
{
    public int num1;
    public int num2;
    public string sighn;
    public int res;

    public void Displayres() { 
    switch (sighn)
                {
                    case "+":
                        res = num1+num2;
                        break;

                    case "-":
                         res = num1 - num2;
                        
                        break;
                    case "*":
                        res = num1 * num2;
   
                        break;
                    case "/":
                        res = num1 / num2;
                     
                        break;
                    
                }


    Console.WriteLine(" The result is " + res );

}

}