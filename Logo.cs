using System;
using System.Drawing;

namespace Trendyol_Checker
{
    class Logo
    {
        //Birinci bölüm renkleri
        static Color _color1 = Color.FromArgb(91, 35, 113);

        //ikinci bölüm renkleri
        static Color _color2 = Color.FromArgb(53, 26, 117);

        //üçüncü bölüm renkleri
        static Color _color3 = Color.FromArgb(70, 50, 143);


        public static void _Show()
        {
            Console.Clear();
            string line = "\t";
            Console.Write("\n\n");

Colorful.Console.Write(@"  _______                 _             _ " + "\n", _color3);
Colorful.Console.Write(@" |__   __|               | |           | |" + "\n", _color3);
Colorful.Console.Write(@"    | |_ __ ___ _ __   __| |_   _  ___ | |" + "\n", _color3);
Colorful.Console.Write(@"    | | '__/ _ \ '_ \ / _` | | | |/ _ \| |" + "\n", _color3);
Colorful.Console.Write(@"    | | | |  __/ | | | (_| | |_| | (_) | |" + "\n", _color3);
Colorful.Console.Write(@"    |_|_|  \___|_| |_|\__,_|\__, |\___/|_|" + "\n", _color3);
Colorful.Console.Write(@"                             __/ |        " + "\n", _color3);
Colorful.Console.Write(@"                            |___/         " + "\n", _color3);

        }
    }
}
