using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGtextgame
{
    class Character
    {
        Random rdm = new Random();

        //Character stats/information
        public string name { get; set; }
        public int health { get; set; }//HP
        public int mana { get; set; } //MP
        public int strength { get; set; }//Attack base
        public int endurance { get; set; }//defense/ health
        public int agility { get; set; }//crit rate/ attack order/ dodge chance
        public int intelligence { get; set; }// magic dmg/
        public int wisdom { get; set; }//mag defence/MAna
        public int dodgerate { get; set; }//dodge rate
        public int critrate { get; set; }//critical rate
        public int level { get; set; }//level of character
        public int exp { get; set; }//experience of character
        public int gold { get; set; }//Money
        public int dmg { get; set; }//physical damage char does
        public int mdmg { get; set; }//Magic damage char does
        public int def { get; set; }//physical defense char has
        public int mdef { get; set; }//Magic defense char has
        public Character(string name, int strength, int endurance, int agility, int intelligence, int wisdom, int level)
        {
            this.name = name;
            this.strength = strength;
            this.endurance = endurance;
            this.agility = agility;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.level = level;
            this.exp = 0;
            this.gold = 500;
            this.calculateHP();
            this.calculateMP();
            this.calculateDodge();
            this.calculateCrit();

        }
        public void calculateHP()
        {
            health = 10 + (endurance * 5);
        }
        public void calculateMP()
        {
            mana = 10 + (wisdom * 5);
        }
        public void calculateDodge()
        {
            dodgerate = 2 + ((int)(agility * 0.1));
            if (dodgerate >= 55)
            {
                dodgerate = 55;
            }
        }
        public void calculateCrit()
        {
            critrate = ((int)(agility * 0.2));

            if (critrate >= 100)
            {
                critrate = 100;
            }
        }
        public void calculateDmg()
        {
            dmg = 2 + ((strength * 2) + (int)(agility/ 4));
            mdmg = 2 + ((intelligence * 2) + (int)(wisdom / 4));
        }
        public void calculateDef()
        {
            def = (int)((endurance/2) + (agility / 4));
            mdef = (int)((wisdom/2) + (wisdom/4) + (intelligence / 8));
        }

        public void calculateAll()
        {
            this.calculateCrit();
            this.calculateDodge();
            this.calculateHP();
            this.calculateMP();
            this.calculateDmg();
            this.calculateDef();
        }
        public void levelup()
        {
            if(this.exp > this.level * 10 * this.level)
            this.strength = strength += 1;
            this.endurance = endurance += 1;
            this.agility = agility += 1;
            this.intelligence = intelligence += 1;
            this.wisdom = wisdom += 1;
            this.level = level++;
        }
        public void showStatus()
        {
            Console.WriteLine("=============================\n" +
                              $"|| Name:  {name} LV: {level}\n" +
                              $"|| HP:    {health}\n" +
                              $"|| MP:    {mana}\n" +
                              $"|| Str:   {strength}\n" +
                              $"|| End:   {endurance}\n" +
                              $"|| Agi:   {agility}\n" +
                              $"|| Int:   {intelligence}\n" +
                              $"|| Wis:   {wisdom}\n|| \n" +
                              $"|| Dodge: {dodgerate}\n" +
                              $"|| Crit:  {critrate}\n" +
                              "=============================");

        }
        public void showDmgDef()
        {
            Console.WriteLine("=============================\n" +
                              $"|| Name:  {name} LV: {level}\n" +
                              $"|| Dmg:   {dmg}\n" +
                              $"|| Def:   {def}\n" +
                              $"|| MDmg:  {mdmg}\n" +
                              $"|| MDef:  {mdef}\n" +
                              "=============================");

        }
        public Boolean isDead()
        {
            Boolean b = true;

            if (health <= 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            return b;
        }

        public int expGain(Character ch, Character mon)
        {
            int expgained =(int)( mon.level * (5 * ((rdm.Next(1, ch.level)/100)+1)));
            return expgained;
        }
        public int goldGain(Character ch, Character mon)
        {
            int goldgained = (int)(50 * mon.level * (((rdm.Next(1, ch.level) / 25) + 1)));
            return goldgained;
        }

    }
}
