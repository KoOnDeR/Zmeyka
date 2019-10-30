using System;
using System.Collections.Generic;



namespace Ubeyte_Menya_Plz
{
     class Head
    {

        public Point Coords {get; set;}
        public Point PrevCoords { get; set; }
        public void MoveUp()
        {
            PrevCoords.Y = Coords.Y;
            PrevCoords.X = Coords.X;
            --Coords.Y;
        }
        public void MoveDown()
        {
            PrevCoords.X = Coords.X;
            PrevCoords.Y = Coords.Y;
            ++Coords.Y;
        }
        public void MoveLeft()
        {
            PrevCoords.Y = Coords.Y;
            PrevCoords.X = Coords.X;
            --Coords.X;
        }
        public void MoveRight()
        {
            PrevCoords.Y = Coords.Y;
            PrevCoords.X = Coords.X;
            ++Coords.X;
        }
        public void HeadInit()
        {
            Coords = new Point(10, 20);
            PrevCoords = new Point(10, 20);
            Console.SetCursorPosition(20, 10);
            Console.Write("☻");
        }
        class Body
        {
          
          
            
            
        }
        
        
    }
}
