using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGtextgame
{
    class Map
    {
        int[][] map;
        Random rdm = new Random();



        public void setmapsize()
        {
            int x = rdm.Next(3, 7) + 1;
            int y = rdm.Next(3, 7) + 1;

            map = new int[x][];

            for (int a = 0; a < x; a++)
            {
                map[a] = new int[y];
                map[a][0] = -1;
                map[a][y - 1] = -1;
            }
            for (int a = 0; a < y; a++)
            {
                map[0][a] = -1;
                map[x - 1][a] = -1;
            }
            for (int a = 1; a < x-1; a++)
            {
                for (int b = 1; b < y-1; b++)
                {
                    map[a][b] = 0;
                }
            }
            setEvents(x,y);

            ///*
             Console.WriteLine(x);
             Console.WriteLine(y);

             for (int a = 0; a < map.Length; a++)
             {
                 for (int b = 0; b < map[a].Length; b++)
                 {
                     if (map[a][b] == -1)
                     {
                         Console.Write("*");
                         Console.Write(" ");
                     }
                     else
                     {
                         Console.Write(map[a][b]);
                         Console.Write(" ");
                     }
                 }
                 Console.WriteLine();
             }
            // */

        }

        public void setEvents(int x, int y)
        {
            for (int a = 1; a < x-1; a++)
            {
                for (int b = 1; b < y-1; b++)
                {
                    map[a][b] = rdm.Next(1,4);
                }
            }
        }

        public void runEvent(int number)
        {
            if(number == 1)
            {
                //Monster meet high chance
                if(number < 6)
                {

                }
                else
                {

                }
            }
            else if(number == 2)
            {
                //stat point get high chance
                if (number < 6)
                {

                }
                else
                {

                }
            }
            else if (number == 3)
            {
                //item get high chance
                if (number < 6)
                {

                }
                else
                {

                }
            }
            else{
                //nothing but catch any error that could occur
                Console.Write("You should not be here... (TT ^ TT)");
            }
        }//end of method


    }
}
