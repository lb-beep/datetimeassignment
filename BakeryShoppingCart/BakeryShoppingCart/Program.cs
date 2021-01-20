using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            DateTime Date1 = new DateTime(1983, 2, 20);
            DateTime Date2 = new DateTime(1999, 5, 15);

            int result = DateTime.Compare(Date1, Date2);

            Console.WriteLine(result);

            if (Date2 > Date1)
            {
                Console.WriteLine("The Date is Greater!");
            }
            else
            {
                Console.WriteLine("The date is less than!");
            }
            

           
        }
    }
}
