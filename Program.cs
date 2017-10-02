using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/*
* RPG Game - Dungeon crawler
* 
* --Features
* -Stats
* -Criticals
* -Health
* -Random Events
* -LVL
* 
* --Planned features
* -Catch Monsters
* 
*/

namespace RPGtextgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RPG Game";


            Map map = new Map();
            MainController main = new MainController();

            map.setmapsize();

            string input = "";
            Console.WriteLine("Please enter what your choice:\n- Play\n- Help\n- Quit");
            input = Console.ReadLine();

            while (!(input.Equals("quit", StringComparison.InvariantCultureIgnoreCase)))
            {
                if (input.Equals("test", StringComparison.InvariantCultureIgnoreCase))
                {
                    Character user = new Character("ME", 5, 5, 5, 5, 5, 1);
                    Character monster = main.createMonster(user);

                    string choice = main.encounterMonster(monster);
                    if(choice.Equals("fight", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Boolean win = main.fightMonster(user, monster);
                    }
                    else
                    {
                        if(user.agility*5 >= monster.agility)
                        {
                            Console.WriteLine("Escape success!");
                        }
                    }

                }

                else if (input.Equals("play", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("What is your name?");
                    string name = Console.ReadLine();

                    Character user = new Character(name, 5, 5, 5, 5, 5, 1);
                    Console.WriteLine("Below are your status:");

                    user.showStatus();


                    main.StatAssign(user, 5);

                    Character monster = main.createMonster(user);



                    Console.Write("Press any key to continue...");
                    Console.ReadKey();

                    // input = endSave(user);
                }

                else if (input.Equals("help", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Help file... HERE");
                    //String Reader? XMLReader? XMLDoc?...

                    //  input = endSave(user);
                }

                else
                {
                    Console.WriteLine("Invalid Choice!\nPlease Choose from the following:\n- Play\n- Help\n- Quit");
                    input = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// XMLDOCUMENT
        /// </summary>
        /// <returns></returns>


        public static string endSave(Character ch)
        {
            XmlDocument doc = new XmlDocument();
            string xml = "<";
            doc.LoadXml(xml);

            return "quit";
        }
        public static void loadGame()
        {

        }
    }
}
