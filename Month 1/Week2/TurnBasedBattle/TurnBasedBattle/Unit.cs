using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedBattle
{
    class Unit
    {
        private int curentHP;
        private int maxHP;
        private int attackDamage;
        private int healPower;
        private int lifesteal;
        private string Character;
        private Random random;

        public int Hp { get { return curentHP; } }
        public string character { get { return Character; } }
        public bool isDead {get { return curentHP <= 0; } }

        public Unit(int maxHP, int attackDamage, int healPower, string Character)
        {
            this.maxHP = maxHP;
            this.curentHP = maxHP;
            this.attackDamage = attackDamage;
            this.healPower = healPower;
            this.Character = Character;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int rngDamage = (int)(attackDamage * rng);
            unitToAttack.TakeDamage(rngDamage);
            Console.WriteLine($"{Character} attacks {unitToAttack.Character} and deals {rngDamage} damage!");
        }

        public void TakeDamage(int damage)
        {
            curentHP -= damage;

            if (isDead)
            {
                Console.WriteLine(character + " has been defeated!");
            }
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng = healPower);
            curentHP = heal + curentHP > maxHP ? maxHP : curentHP + heal;
            Console.WriteLine($"{character} heals {heal}");
        }
    }
}
