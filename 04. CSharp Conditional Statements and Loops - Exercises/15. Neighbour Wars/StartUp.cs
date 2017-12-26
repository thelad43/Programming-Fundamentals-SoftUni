namespace _15.Neighbour_Wars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            var peshosHealth = 100;
            var goshosHealth = 100;
            var attackCounter = 0;
            var attackedHealth = 0;

            var isAnyoneAlive = true;
            var attackName = string.Empty;
            var attacker = string.Empty;
            var attacked = string.Empty;

            while (isAnyoneAlive)
            {
                attackCounter++;

                if (attackCounter % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    attackName = "Roundhouse kick";
                    attacker = "Pesho";
                    attacked = "Gosho";
                    attackedHealth = goshosHealth;
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    attackName = "Thunderous fist";
                    attacker = "Gosho";
                    attacked = "Pesho";
                    attackedHealth = peshosHealth;
                }

                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {attackCounter}th round.");
                    isAnyoneAlive = false;
                }
                else
                {
                    if (attackCounter % 3 == 0)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                    }

                    Console.WriteLine($"{attacker} used {attackName} and reduced {attacked} to {attackedHealth} health.");
                }
            }
        }
    }
}