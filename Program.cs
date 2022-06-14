using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trendyol_Checker
{
    static class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Console.Title = "Trendyol APİ Checker [>] @! AstatiN";
            Utils.Runner();
            Console.ReadKey();
        }


    }
}
