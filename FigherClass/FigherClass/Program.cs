using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterClass
{
    class Fighter
    {
        private int _hpCount;
        private int _damage;

        public int damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value > 0 && value < 20)
                {
                    _damage = value;
                }
            }
        }

        public int health
        {
            get
            {
                return _hpCount;
            }
            set
            {
                _hpCount -= damage;
            }
        }

        public Fighter(int HPCount, int damage)
        {
            _hpCount = HPCount;
            _damage = damage;
        }

        public void ShowFighеerStats()
        {
            Console.Write($"Health-{_hpCount};     ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int health = 100;

            Fighter fighter1 = new Fighter(health, random.Next(7, 13));
            Fighter fighter2 = new Fighter(health, random.Next(7, 13));

            while (fighter1.health > 0 && fighter2.health > 0)
            {
                fighter1.ShowFighеerStats();
                fighter2.ShowFighеerStats();

                Console.ReadKey();
                Console.Clear();

                fighter1.damage = random.Next(7, 13);
                fighter2.damage = random.Next(7, 13);

                if (fighter1.health < fighter2.damage && fighter2.health < fighter1.damage)
                {
                    Console.WriteLine("Ничья");
                }
                else
                {
                    if (fighter1.health < fighter2.damage)
                    {
                        fighter1.health = 0;
                        Console.WriteLine("Боец 2 победил");
                    }
                    if (fighter2.health < fighter1.damage)
                    {
                        fighter2.health = 0;
                        Console.WriteLine("Боец 1 победил");
                    }
                }

                fighter1.health -= fighter2.damage;
                fighter2.health -= fighter1.damage;
            }

            Console.ReadKey();
        }
    }
}
