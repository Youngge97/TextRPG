using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGtextgame
{
    class MainController
    {
        public void levelup(Character ch)
        {
            ch.levelup();
            StatAssign(ch, 5);
        }

        public void StatAssign(Character ch, int numPoint)
        {
            string input = "";
            int num = 0;

            while (numPoint > 0)
            {
                Console.WriteLine($"You have {numPoint} stat points\n" +
                    "Please enter the start you would like to put points into:\n"
                    + "Str, End, Agi, Int, Wis");

                input = Console.ReadLine();

                if (input.Equals("str", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Enter the amount you would like to enter you have {numPoint}");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out num))
                    {
                        ch.strength += num;
                        numPoint -= num;
                    }
                }
                else if (input.Equals("end", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Enter the amount you would like to enter you have {numPoint}");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out num))
                    {
                        ch.endurance += num;
                        numPoint -= num;
                    }
                }
                else if (input.Equals("agi", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Enter the amount you would like to enter you have {numPoint}");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out num))
                    {
                        ch.agility += num;
                        numPoint -= num;
                    }
                }
                else if (input.Equals("int", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Enter the amount you would like to enter you have {numPoint}");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out num))
                    {
                        ch.intelligence += num;
                        numPoint -= num;
                    }
                }
                else if (input.Equals("wis", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Enter the amount you would like to enter you have {numPoint}");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out num))
                    {
                        ch.wisdom += num;
                        numPoint -= num;
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is invalid! Try Again...");
                }
                ch.calculateAll();
                ch.showStatus();

            }
        }

        public string encounterMonster(Character monster)
        {
            Console.WriteLine($"You have encountered LVL {monster.level} {monster.name}!");


            Console.WriteLine($"What would you like to do?\n- Fight\n- Run");

            string input = Console.ReadLine();
            while (!((input.Equals("fight", StringComparison.InvariantCultureIgnoreCase) ||
                (input.Equals("run", StringComparison.InvariantCultureIgnoreCase)))))
            {
                Console.WriteLine($"Not a valid choice");
                Console.WriteLine($"What would you like to do?\n- Fight\n- Run");
                input = Console.ReadLine();
            }
            return input;
        }

        public Boolean fightMonster(Character user, Character monster)
        {
            Boolean win = true;
            Console.WriteLine("=============================\n" +
                              $"|| Name:  {monster.name} LV: {monster.level}\n" +
                              $"|| HP:   {monster.health}\n" +
                              $"|| MP:   {monster.mana}\n" +
                              "=============================");


            string q = "What would you like to do?\n-atk for Normal Attack\n-matk Magic Attack";
            string input = choice(q, "atk", "matk");

            

            return win;
        }
        public string choice(string question,string x, string y)
        {
            string input = Console.ReadLine();
            while (!((input.Equals(x, StringComparison.InvariantCultureIgnoreCase) ||
                (input.Equals(y, StringComparison.InvariantCultureIgnoreCase)))))
            {
                Console.WriteLine($"Not a valid choice");
                Console.WriteLine($"What would you like to do?\n-atk for Normal Attack\n-matk Magic Attack");
                input = Console.ReadLine();
            }
            return input;
        }

        public Character createMonster(Character ch)
        {


            int lvl1 = ch.level;
            int s = 0;
            int a = 0;
            int e = 0;
            int i = 0;
            int w = 0;
            string monname = "";

            Random rdm = new Random();


            int randomnumber = rdm.Next(1, 4);
            int lvl;

            if (lvl1 > 5)
            {
                lvl = rdm.Next(lvl1 - 5, lvl1 + 5);
            }
            else
            {
                lvl = rdm.Next(1, lvl1);
            }


            if (randomnumber == 1)
            {//Attack (physical)

                monname = "StrMonster";
                s = rdm.Next(2, 6) * lvl;
                a = rdm.Next(1, 3) * lvl;
                e = rdm.Next(1, 4) * lvl;
                i = rdm.Next(1, 2) * lvl;
                w = rdm.Next(1, 2) * lvl;

            }
            else if (randomnumber == 2)
            {//Attack (Magic)
                monname = "MagicMonster";
                s = rdm.Next(1, 2) * lvl;
                a = rdm.Next(1, 3) * lvl;
                e = rdm.Next(1, 3) * lvl;
                i = rdm.Next(2, 6) * lvl;
                w = rdm.Next(2, 3) * lvl;
            }
            else
            {//Speed (dodge/evasive)
                monname = "SpeedMonster";
                s = rdm.Next(1, 3) * lvl;
                a = rdm.Next(2, 7) * lvl;
                e = rdm.Next(1, 2) * lvl;
                i = rdm.Next(1, 3) * lvl;
                w = rdm.Next(1, 2) * lvl;
            }

            Character monster = new Character(monname, s, e, a, i, w, lvl);
            monster.calculateAll();

            return monster;
        }
    }
}
