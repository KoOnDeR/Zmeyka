using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubeyte_Menya_Plz
{
    class Map
    {
        public static int ln = 70;
        public static int high = 20;
        public char[,] map = new char[high, ln];
        public void MapDraw()
        {

            for (int i = 0; i < high; i++)
                map[i, 0] = '#';
            for (int i = 1; i < high; i++)
                for (int j = 1; j < ln; j++)
                    map[i, j] = ' ';
            for (int i = 1; i < ln ; i++)
                map[0, i] = '#';
            for (int i = 1; i < ln; i++)
                map[high - 1, i] = '#';
            for (int i = 0; i < high; i++)
                map[i, ln - 1] = '#';


            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < ln; j++)
                    Console.Write(map[i, j]);
                Console.WriteLine();
            }
          
        }
        
    }
}
