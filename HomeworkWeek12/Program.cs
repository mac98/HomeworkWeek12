using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeworkWeek12
{
    /*
    OLD ALIEN CODE:

    class Alien
    {
        public const int SNAKE_ALIEN = 0;
        public const int OGRE_ALIEN = 1;
        public const int MARSHALLOW_MAN_ALIEN = 2;
        public int type;
        public int health; //0 = dead, 100 = full
        public string name;
        public Alien(int type, int health, string name)
        {
            this.type = type;
            this.health = health;
            this.name = name;
        }
    }
    class AlienPack
    {
        private Alien[] aliens;
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;
            foreach (Alien a in aliens)
            {
                if (a.type == Alien.SNAKE_ALIEN)
                {
                    damage += 10;
                }
                else if (a.type == Alien.OGRE_ALIEN)
                {
                    damage += 6;
                }
                else if (a.type == Alien.MARSHALLOW_MAN_ALIEN)
                {
                    damage += 1;
                }
            }
            return damage;
        }
    }
    */
    class Alien
    {
        private int health;
        public int Health{ get { return health; } set { health = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

    }

    class Snake : Alien
    {
        public Snake()
        {
            Damage = 4;
            Health = 25;
            Name = "Snake";
        }
    }

    class Ogre : Alien
    {
        public Ogre()
        {
            Damage = 20;
            Health = 50;
            Name = "Ogre";
        }
    }

    class MarshmallowMan: Alien
    {
        public MarshmallowMan()
        {
            Damage = 5;
            Health = 15;
            Name = "Marshmallow Man";
        }
    }

    class AlienPack
    {
        private Alien[] Aliens;

        public AlienPack(int num_aliens)
        {
            Aliens = new Alien[num_aliens];
        }

        public void AddAlien(Snake new_snake, int index)
        {
            if (index < Aliens.Length)
                Aliens[index] = new_snake;
        }

        public void AddAlien(Ogre new_ogre, int index)
        {
            if (index < Aliens.Length)
                Aliens[index] = new_ogre;
        }

        public void AddAlien(MarshmallowMan new_marhsmallow_man, int index)
        {
            if (index < Aliens.Length)
                Aliens[index] = new_marhsmallow_man;
        }

        public int CalculateDamage()
        {
            int dam = 0;

            foreach (Alien alien in Aliens)
            {
                dam += alien.Damage;
            }

            return dam;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snake snake1 = new Snake();
            Snake snake2 = new Snake();
            Ogre ogre1 = new Ogre();
            MarshmallowMan man1 = new MarshmallowMan();
            MarshmallowMan man2 = new MarshmallowMan();
            MarshmallowMan man3 = new MarshmallowMan();
            MarshmallowMan man4 = new MarshmallowMan();

            AlienPack wave1 = new AlienPack(7);
            wave1.AddAlien(man1, 0);
            wave1.AddAlien(man2, 1);
            wave1.AddAlien(snake1, 2);
            wave1.AddAlien(man3, 3);
            wave1.AddAlien(snake2, 4);
            wave1.AddAlien(man4, 5);
            wave1.AddAlien(ogre1, 6);

            Console.WriteLine(wave1.CalculateDamage());
            Console.Read();
        }
    }
}