using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snap
{
    class Card
    {

        enum cardnum { Ace = 13, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9, J = 10, Q = 11, K = 12 };

        enum suit { C, D, H, S };




        public void CreatePack()
        {
// removed again
        }






        public static void DrawCard(int x, string y)
        {
            Console.WriteLine("|----------|");
            Console.WriteLine("|          |");
            Console.WriteLine("| {0}        |", x);
            Console.WriteLine("|          |");
            Console.WriteLine("|    {0}     |", y);
            Console.WriteLine("|          |");
            Console.WriteLine("|       {0}  |", x);
            Console.WriteLine("|          |");
            Console.WriteLine("|----------|");
        }
    }
}




