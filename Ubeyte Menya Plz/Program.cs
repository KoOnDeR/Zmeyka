using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubeyte_Menya_Plz
{

    class Game
    {
        public void Map()
        {
            Console.OutputEncoding = Encoding.UTF8;


             void Draw()
            {
                int high = 20;
                int ln = 70;
                string[,] Map = new string[high, ln];
                for (int i = 0; i < high; i++)
                    Map[i, 0] = "#";
                for (int i = 1; i < high - 1; i++)
                    for (int j = 1; j < ln - 1; j++)
                        Map[i, j] = " ";
                for (int i = 1; i < ln - 1; i++)
                    Map[0, i] = "#";
                for (int i = 1; i < ln - 1; i++)
                    Map[high - 1, i] = "#";
                for (int i = 0; i < high; i++)
                    Map[i, ln - 1] = "#";
                for (int i = 0; i < high; i++)
                {
                    for (int j = 0; j < ln; j++)
                        Console.Write(Map[i, j]);
                    Console.WriteLine();
                }
            }
            Draw();




        }
    }
    static void Main()
    {
        Draw();
    }
    
}
