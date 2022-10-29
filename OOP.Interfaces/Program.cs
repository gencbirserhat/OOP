using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    class Program
    {
        static void Main()
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.WithDraw(300);
            saver.WithDraw(500);
            Console.WriteLine("Curent balance: " + saver.Balance);
            Console.WriteLine(saver);

        }
    }

}
