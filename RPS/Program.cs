using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Chose your weapon");
                Console.WriteLine("[R]ock, [P]aper, [S]cissors, [L]izard, sp[O]ck");
                string weapon = Console.ReadLine().ToUpperInvariant();

                if (weapon == "R" || weapon == "P" || weapon == "S" || weapon == "L" || weapon == "O")
                {
                    flag = false;
                    CheckWhoWin(weapon);
                    Console.ReadKey();
                }

            }

        }

        public static char GetRandomWeapon()
        {
            string chars = "RPSLO";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }

        public static void CheckWhoWin(string myWeapon)
        {   
            char randomWeapon = GetRandomWeapon();

            if(myWeapon == "R")
            {
                switch(randomWeapon)
                {
                    case 'R':
                        Console.WriteLine("Rock-rock. Try again");
                        break;
                    case 'P':
                        Console.WriteLine("Rock-Paper. Paper covers rock");
                        break;
                    case 'S':
                        Console.WriteLine("Rock-Scissors. Rock crushes scissors");
                        break;
                    case 'L':
                        Console.WriteLine("Rock-Lizard. Rock crushes lizard");
                        break;
                    case 'O':
                        Console.WriteLine("Rock-Spock. Spock vaporizes rock");
                        break;
                }
            }

            if(myWeapon == "P")
            {
                switch(randomWeapon)
                {
                    case 'R':
                        Console.WriteLine("Paper-rock. Paper covers rock");
                        break;
                    case 'P':
                        Console.WriteLine("Paper-Paper. Try again");
                        break;
                    case 'S':
                        Console.WriteLine("Paper-Scissors. Scissors cuts paper");
                        break;
                    case 'L':
                        Console.WriteLine("Paper-Lizard. Lizard eat paper");
                        break;
                    case 'O':
                        Console.WriteLine("Paper-Spock. Paper disproves Spock");
                        break;
                }
            }

            if(myWeapon == "S")
            {
                switch(randomWeapon)
                {
                    case 'R':
                        Console.WriteLine("Scissors-rock. Rock crushes scissors");
                        break;
                    case 'P':
                        Console.WriteLine("Scissors-Paper. Scissors cuts paper");
                        break;
                    case 'S':
                        Console.WriteLine("Scissors-Scissors. Try again");
                        break;
                    case 'L':
                        Console.WriteLine("Scissors-Lizard. Scissors decapitates lizard");
                        break;
                    case 'O':
                        Console.WriteLine("Scissors-Spock. Spock smashes Scissors");
                        break;
                }
            }

            if(myWeapon == "L")
            {
                switch(randomWeapon)
                {
                    case 'R':
                        Console.WriteLine("Lizard-rock. Rock crushes lizard");
                        break;
                    case 'P':
                        Console.WriteLine("Lizard-Paper. Lizard eat paper");
                        break;
                    case 'S':
                        Console.WriteLine("Lizard-Scissors. Scissors decapitates lizard");
                        break;
                    case 'L':
                        Console.WriteLine("Lizard-Lizard. Try again");
                        break;
                    case 'O':
                        Console.WriteLine("Lizard-Spock. Lizard poisons Spock");
                        break;
                }
            }

            if(myWeapon == "O")
            {
                switch(randomWeapon)
                {
                    case 'R':
                        Console.WriteLine("Spock-rock. Spock vaporizes rock");
                        break;
                    case 'P':
                        Console.WriteLine("Spock-Paper. Paper disproves Spock");
                        break;
                    case 'S':
                        Console.WriteLine("Spock-Scissors. Spock smashes Scissors");
                        break;
                    case 'L':
                        Console.WriteLine("Spock-Lizard. Lizard poisons Spock");
                        break;
                    case 'O':
                        Console.WriteLine("Spock-Spock. Try again");
                        break;
                }
            }

        }
    }
}
