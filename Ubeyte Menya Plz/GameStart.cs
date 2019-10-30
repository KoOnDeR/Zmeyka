using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ubeyte_Menya_Plz
{
    public class GameStart

    {
        public static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; 
            Game newgame = new Game();
            newgame.Startgame();            
            newgame.Play();
            
            
       }      
    }         
}
