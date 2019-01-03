using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    // wyswietlanie kategorii - losowanie -< przygotwanie 5 kategorii ze słowami, każde słowo z pytaniem
    // metoda pobierająca litery
    // metoda rysująca wisielca na górze ekranu 
    // unikanie statików

    class Program
    {
        private const string WELCOME = "WITAJ! [G]RASZ CZY [W]YCHODZISZ?";
        private const string EXIT = "CZY JESTEŚ PEWIEN? [T]AK / [N]IE";
        static Random rnd = new Random();

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;

            bool state = Initialize();

            if(state)
            {
                for (int i = 1; i < 45; i++)
                {
                    Console.SetWindowSize(2*i, i);
                    System.Threading.Thread.Sleep(20);
                }
                Console.WriteLine(WELCOME);
                var state2 = Game();
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Coś się zjebało. Sry");
            }

        }

        private static bool Initialize()
        {
            var stolice = new Category("Stolice");
            var zwierzeta = new Category("Zwierzęta");
            var rosliny = new Category("Rośliny");
            var panstwa = new Category("Państwa");
            var komendy = new Category("Komendy rysowania w E3D");

            stolice.Words.Add("Londyn");
            stolice.Words.Add("Madryt");
            stolice.Words.Add("Warszawa");
            stolice.Words.Add("Berlin");
            stolice.Words.Add("Nowy Jork");

            zwierzeta.Words.Add("Pies");
            zwierzeta.Words.Add("Niedźwiedź");
            zwierzeta.Words.Add("Żyrafa");
            zwierzeta.Words.Add("Okoń");
            zwierzeta.Words.Add("Nosorożec");

            rosliny.Words.Add("Róża");
            rosliny.Words.Add("Paproć");
            rosliny.Words.Add("Kasztanowiec");
            rosliny.Words.Add("Jemioła");
            rosliny.Words.Add("Tulipan");

            panstwa.Words.Add("Polska");
            panstwa.Words.Add("Hiszpania");
            panstwa.Words.Add("Francja");
            panstwa.Words.Add("Niemcy");
            panstwa.Words.Add("Rosja");

            komendy.Words.Add("Stra");
            komendy.Words.Add("Newview");
            komendy.Words.Add("Layer");
            komendy.Words.Add("Connct");
            komendy.Words.Add("Rect");

            category.Add(stolice);
            category.Add(zwierzeta);
            category.Add(rosliny);
            category.Add(panstwa);
            category.Add(komendy);

            return true;
        }

        private static bool Game()
        {

            var randomCategory = category[rnd.Next(category.Count())];
            var randomWord = randomCategory.Words[rnd.Next(randomCategory.Words.Count())];

            Console.WriteLine("Wylosowana kategoria: " + randomCategory.Name.ToString().ToUpper());
            Console.WriteLine("Wylosowane słowo: " + randomWord.ToString().ToUpper());

            char[] wordArray = randomWord.ToArray();

            return true;

        }

        private static List<Category> category = new List<Category>();

    }

    public class Category
    {
        private string name;
        private List<string> words = new List<string>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Words
        {
            get { return words; }
            set { words = value; }
        }

        public Category(string name)
        {
            this.name = name;
        }

    }

}
