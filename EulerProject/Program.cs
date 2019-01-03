using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CardanoTriplets();
        }

        public static void Modulo35()
        {

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }

        public static void Fibonacci()
        {
            List<decimal> list = new List<decimal>();
            list.Add(1);
            list.Add(2);

            decimal sum = 0;
            for (int i = 1; i < list.Capacity; i++)
            {
                if (list[i] >= 4000000) break;
                decimal temp = list[i - 1] + list[i];
                list.Add(temp);
                if (list[i] % 2 == 0) sum += list[i];

            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();

        }

        public static void PrimeFactors()
        {

            List<long> list = new List<long>();
            List<long> prime = new List<long>();
            long number = long.Parse(Console.ReadLine());
            long temp = 1;
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if ((number % i) == 0)
                {
                    list.Add(i);
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                temp *= list[i];
                prime.Add(list[i]);
                if (temp == number) break;
            }

            Console.WriteLine("The largest prime factor is " + prime.Last());
            Console.ReadKey();
        }

        public static void PalidromeProduct()
        {
            long[] tab = new long[6];
            List<long> outcome = new List<long>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    long number = i * j;
                    int k = 0;
                    while (number > 0)
                    {
                        tab[5 - k] = number % 10;
                        k++;
                        number /= 10;
                    }

                    if (tab[0] == tab[5] && tab[1] == tab[4] && tab[2] == tab[3])
                    {
                        outcome.Add(i * j);
                    }
                }
            }
            foreach (long outnumber in outcome)
            {
                Console.WriteLine(outnumber);
            }
            Console.ReadKey();
        }

        public static void SmallestMultiple()
        {
            bool flag = false;
            List<long> outcome = new List<long>();
            for (long i = 20; i < 999999999; i++)
            {
                flag = false;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }

                }

                if (flag == true) outcome.Add(i);
            }

            foreach (long item in outcome)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        public static void SumSquareDifference()
        {
            long sumOfSquares = 0;
            long SquaresOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                SquaresOfSum += i;
            }

            SquaresOfSum *= SquaresOfSum;

            Console.WriteLine(SquaresOfSum - sumOfSquares);
            Console.ReadKey();

        }

        public static void FirstPrime()
        {
            long p = 3;
            bool flag;
            List<long> prime = new List<long>();
            while (prime.Count < 10002)
            {
                flag = true;
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    prime.Add(p);
                }
                p++;
            }

            Console.WriteLine(prime[9999]);
            Console.ReadKey();
        }

        public static void LargestProductInAseries()
        {
            string inPut = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            Int64[] tab = new Int64[1000];
            int k = 0;
            char[] foo = inPut.ToArray();

            foreach (char x in foo)
            {
                tab[k] = (uint)Char.GetNumericValue(x);
                k++;
            }

            Int64 maxSum1 = 1;
            List<Int64> sumList = new List<Int64>();

            for (int i = 0; i < tab.Length - 13; i++)
            {

                for (int j = i; j < i + 13; j++)
                {
                    maxSum1 *= tab[j];
                }

                sumList.Add(maxSum1);

                maxSum1 = 1;
            }

            Console.WriteLine(sumList.Max());
            Console.ReadKey();
        } 

        public static void LargestProductInAGrid()
        {

            string inputLine;
            StreamReader sr = new StreamReader(@"..\..\Largest_product_in_a_grid.txt");

            inputLine = sr.ReadToEnd();

            string[] enteredLines = inputLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Int64[][] charMatrix = new Int64[20][];

            for(int i=0; i<20; i++)
            {
                string[] temp = enteredLines[i].Split(' ');
                int j=0;
                charMatrix[i] = new Int64[20];

                foreach(string x in temp)
                {
                    charMatrix[i][j] = Int64.Parse(x);
                    j++;
                }
            }

            Int64[,] intMatrix = new Int64[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    intMatrix[i, j] = charMatrix[i][j];
                }
            }


            Int64 maxSum1 = 1;
            Int64 maxSum2 = 1;

            List<Int64> greatestProductList = new List<Int64>();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20-4; j++)
                {

                    for (int k = j; k < j + 4; k++)
                    {
                        maxSum1 *= intMatrix[i,k];
                        maxSum2 *= intMatrix[k, i];

                    }

                    greatestProductList.Add(maxSum1);

                    maxSum1 = 1;
                    maxSum2 = 1;
                }
            }

            maxSum1 = 1;

            for (int i = 0; i < 20-4; i++)
            {
                for(int j=0; j<20-4; j++)
                {
                    Int64 temp = intMatrix[i, j] * intMatrix[i + 1, j + 1] * intMatrix[i + 2, j + 2] * intMatrix[i + 3, j + 3];
                    greatestProductList.Add(temp);

                }

            }

            for (int i = 19; i > 4; i--)
            {
                for (int j = 0; j < 20-4; j++)
                {
                    Int64 temp = intMatrix[i, j] * intMatrix[i - 1, j + 1] * intMatrix[i - 2, j + 2] * intMatrix[i - 3, j + 3];
                    greatestProductList.Add(temp);

                }

            }


            Console.WriteLine(greatestProductList.Max());
            Console.ReadKey();
        } 

        public static void SpecialPythagoreanTriplet()
        {
            int product = 1;
            int temp1 = 0, temp2 = 0;
            int a, b, c;
            for (c = 3; c < 1000; c++)
            {
                for (b = 1; b < c; b++)
                {
                    for (a = 1; a < b; a++)
                    {
                        temp1 = a + b + c;
                        temp2 = (a * a) + (b * b);

                        if (temp1 == 1000 && temp2 == (c * c))
                        {
                            product = a * b * c;
                        }
                    }
                }
            }
            Console.WriteLine(product.ToString());
            Console.ReadKey();
        }

        public static void SummationOfPrimes()
        {
            long p = 3;
            bool flag;
            List<long> prime = new List<long>();
            while (prime.Count < 2000000)
            {
                if (p == 2000000) break;
                flag = true;
                for (int i = 2; i * i <= p; i++)
                {
                    if (p % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    prime.Add(p);
                }

                p++;
            }

            Console.WriteLine(prime.Sum().ToString() + "+2");
            Console.ReadKey();
        }

        public static void HighlyDivisibleTriangularNumber()
        {
            List<BigInteger> triangleNumbers = new List<BigInteger>();

            //BigInteger temp3 = 1;

            //for (UInt64 j = 1; j < 500; j++)
            //{
            //    temp3 = temp3 * j;
            //    Console.WriteLine(temp3.ToString());

            //}

            for (BigInteger i = 500; i < 1000000; i++)
                {
                    BigInteger temp = 0;

                    temp = i * (i + 1) / 2;

                    triangleNumbers.Add(temp);

                    BigInteger numberOfDivisors = 0;

                    for (BigInteger k = 1; k <= temp/2; k++)
                    {
                        if (temp % k == 0)
                        {
                            numberOfDivisors++;
                        }
                    }
                    numberOfDivisors += 1;
                    Console.WriteLine(numberOfDivisors);
                    if (numberOfDivisors > 500)
                    {
                        Console.WriteLine(temp);
                        break;
                    }

                }

            Console.ReadKey();
        }

        public static void LargeSum()
        {
            string inputLine;
            StreamReader sr = new StreamReader(@"..\..\Large_sum.txt");

            inputLine = sr.ReadToEnd();

            string[] enteredLines = inputLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            List<BigInteger> sum = new List<BigInteger>();

            for (int i = 0; i < 100; i++)
            {
                BigInteger digit = BigInteger.Parse(enteredLines[i]);
                Console.WriteLine(digit);
                sum.Add(digit);
            }

            BigInteger sumOfAll=0;

            foreach(BigInteger x in sum)
            {
                sumOfAll += x;
                Console.WriteLine(x);
            }

            sumOfAll = sumOfAll / (BigInteger)(Math.Pow(10, 42));

            Console.WriteLine(sumOfAll.ToString("G10", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }

        public static void LongestCollatzSequence()
        {
            Int64 startingNumber = 1000000;
            
            Int64 terms;

            //List<Int64,Int64> listOfCountOfChain = new List<Int64,Int64>();

            var listOfCountOfChain = new List<KeyValuePair<Int64, Int64>>();

            while(startingNumber>14)
            {
                Int64 startingNumberToList = startingNumber;
                Int64 countOfChain = 2;
                terms = 0;

                if (startingNumber % 2 == 0) terms = startingNumber / 2;
                else terms = (3 * startingNumber) + 1;

                while(terms>1)
                {
                    if (terms % 2 == 0) terms = terms / 2;
                    else terms = (3 * terms) + 1;
                    countOfChain++;
                    if (terms == 1) break;
                    
                }

                listOfCountOfChain.Add(new KeyValuePair<Int64, Int64>(startingNumberToList, countOfChain));
                Console.WriteLine(countOfChain);

                startingNumber--;
            }
            Console.WriteLine("Max:");
          //  Console.WriteLine(listOfCountOfChain.Max());
            var pair = listOfCountOfChain.OrderByDescending(x => x.Value).First();
            Console.WriteLine(pair.Key.ToString());
            Console.ReadKey();

        }

        public static BigInteger Factorial(long digit)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= digit; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void LatticePaths()
        {
            Console.WriteLine("Enter size of gird");
            long grid = long.Parse(Console.ReadLine());

            BigInteger numberOfWays = Factorial(grid * 2) / (Factorial(grid) * Factorial(grid));

            Console.WriteLine(numberOfWays);
            Console.ReadKey();
        } 

        public static void PowerDigitSum()
        {
            BigInteger digit = 2;

            for(int i=1; i<1000;i++)
            {
                digit *= 2;
            }

            List<int> digitList = new List<int>();

            string inPutDigit = digit.ToString();

            int k = 0;
            char[] foo = inPutDigit.ToArray();

            foreach (char x in foo)
            {
                digitList.Add((int)Char.GetNumericValue(x));
            }

            Console.WriteLine(digitList.Sum());
            Console.ReadKey();


        }

        public static void MaximumPathSumI()
        {
            string inputLine;
            StreamReader sr = new StreamReader(@"..\..\Maximum_path_sum_I.txt");

            inputLine = sr.ReadToEnd();

            string[] enteredLines = inputLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int[][] triangle = new int[enteredLines.Count()][];

            int sumUD = 0;
            int sumDU = 0;
            int sumUDU = 0;

            for (int i = 0; i < enteredLines.Count(); i++)
            {
                int[] level = new int[i + 1];
                level = enteredLines[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                triangle[i] = level;

            }

            int index = 0;


            #region Up - Down
            //for (int i = 0; i < enteredLines.Count(); i++)
            //{
            //    var temp = triangle[i][index];
            //    sumUD += temp;
            //    if (i != enteredLines.Count() - 1)
            //    {
            //        if (triangle[i + 1][index] < triangle[i + 1][index + 1])
            //        {
            //            index += 1;
            //        }
            //    }
            //    else break;

            //}

            //int[,] listOfMax = new int[2, enteredLines.Count()];

            //for (int i = 0; i < enteredLines.Count(); i++)
            //{
            //    var maxValIndex = Array.IndexOf(triangle[i], triangle[i].Max());
            //    listOfMax[0, i] = maxValIndex;
            //    listOfMax[1, i] = triangle[i].Max();

            //} 
            #endregion

            #region Down - Up
            //int indexDU = Array.IndexOf(triangle[enteredLines.Count() - 1], triangle[enteredLines.Count()-1].Max());
            //for (int i = enteredLines.Count()-1; i > 0; i--)
            //{
            //    if (i != 1)
            //    {
            //        var temp = triangle[i][indexDU];
            //        sumDU += temp;

            //        if (indexDU == 0)
            //        {
            //            indexDU = 0;
            //        }
            //        else if (indexDU == (triangle[i-1].Count()))
            //        {
            //            indexDU -= 1;
            //        }
            //        else if (triangle[i - 1][indexDU] < triangle[i - 1][indexDU - 1])
            //        {
            //            indexDU -= 1;
            //        }

            //    }
            //    else
            //    {
            //        sumDU += triangle[i][indexDU];
            //        sumDU += triangle[i][0];
            //        break;
            //    }


            //} 
            #endregion

            #region Up-Down-Up

            for (int i = enteredLines.Count() - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count(); j++)
                {
                    if (triangle[i + 1][j] < triangle[i + 1][j + 1])
                    {
                        var temp = triangle[i + 1][j + 1];
                        //Console.WriteLine(triangle[i][j].ToString() + "+" + triangle[i + 1][j + 1].ToString());
                        triangle[i][j] += temp;
                    }
                    else
                    {
                        //Console.WriteLine(triangle[i][j].ToString() + "+" + triangle[i + 1][j].ToString());
                        triangle[i][j] += triangle[i + 1][j];
                    }
                }
            } 
            #endregion

            Console.WriteLine(triangle[0][0]);

            Console.WriteLine(sumDU);
            Console.WriteLine(sumUD);

            Console.ReadKey();

        }

        public static void MaximumPathSumII()
        {
            string inputLine;
            StreamReader sr = new StreamReader(@"..\..\Maximum_path_sum_II.txt");

            inputLine = sr.ReadToEnd();

            string[] enteredLines = inputLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int[][] triangle = new int[enteredLines.Count()][];

            for (int i = 0; i < enteredLines.Count(); i++)
            {
                int[] level = new int[i + 1];
                level = enteredLines[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                triangle[i] = level;

            }


            #region Up-Down-Up

            for (int i = enteredLines.Count() - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count(); j++)
                {
                    if (triangle[i + 1][j] < triangle[i + 1][j + 1])
                    {
                        var temp = triangle[i + 1][j + 1];
                        triangle[i][j] += temp;
                    }
                    else
                    {
                        triangle[i][j] += triangle[i + 1][j];
                    }
                }
            }
            #endregion

            Console.WriteLine(triangle[0][0]);

            Console.ReadKey();

        }

        public static void CountingSundays()
        {
            List<Year> listOfYear = new List<Year>();

            int firstDayOfYear = 1;
            int sundaysOfJan = 1;

            int sundaysOfFirstDay = 0;

            for(int year = 1901; year <= 2000; year++)
            {
                int days=365;
                if (year % 4 == 0) 
                {
                    if(year % 100 == 0 ) 
                    {
                        if(year % 400 == 0)
                        {
                            days = 366;
                            firstDayOfYear += 2;
                        }else 
                        days=365;
                        firstDayOfYear += 1; 
                    }
                    else 
                    {
                        days = 366;
                        firstDayOfYear += 2;
                    }
                }
                else firstDayOfYear += 1; 

                if(firstDayOfYear == 8) firstDayOfYear=1;
                if(firstDayOfYear == 9) firstDayOfYear=2;

                if(firstDayOfYear >= 5) sundaysOfJan = 5; else sundaysOfJan = 4;
                var temp = new Year(year,days,sundaysOfJan,firstDayOfYear);
                listOfYear.Add(temp);

                if (firstDayOfYear == 1) sundaysOfFirstDay++;
            }


            Console.WriteLine(listOfYear.Sum(x => x.sumOfFirstSundays));
            Console.ReadKey();


        }

        class Year
        {
            public int year;
            public int days;
            public int sundaysOfJan;
            public int firstDayOfYear;
            public int sumOfFirstSundays;

            List<int> listOfSundays = new List<int>();
            List<int> listOfFirstDaysOfMonth = new List<int>();

            public Year(int Year, int Days, int SundaysOfYear, int FirstDayOfYear)
            {
                year = Year;
                days = Days;
                sundaysOfJan = SundaysOfYear;
                firstDayOfYear = FirstDayOfYear;
                FillListOfSundays();
                FillListOfFirstDayOfMonth();
                sumOfFirstSundays = 0;
                SundayOnFirstDay();
            }

            private void FillListOfSundays()
            {

                var daysToFirstSunday = 7 - firstDayOfYear;
                var currentDay = daysToFirstSunday + 1;
                var tempDays = days;

                while(tempDays >= 6)
                {
                    listOfSundays.Add(currentDay);
                    tempDays -= 7;
                    currentDay += 7;
                }
            }

            private void FillListOfFirstDayOfMonth()
            {
                var tempDays = 1;

                listOfFirstDaysOfMonth.Add(tempDays);

                for(int i=1;i<=12;i++)
                {

                    if(i<=7 && i!=2)
                    {
                        if (i % 2 != 0) tempDays += 31;
                        else tempDays += 30;
                    }

                    if(i>7)
                    {
                        if (i % 2 != 0) tempDays += 30;
                        else tempDays += 31;
                    }

                    if(i==2)
                    {
                        if (days == 366) tempDays += 29;
                        else tempDays += 28;
                    }

                    listOfFirstDaysOfMonth.Add(tempDays);
                }
            }

            private void SundayOnFirstDay()
            {
                foreach(int x in listOfFirstDaysOfMonth)
                {
                    if(listOfSundays.Contains(x))
                    {
                        sumOfFirstSundays++;
                    }
                }
            }
        }

        public static void AmicableNumbers()
        {
            List<int> amicableNumbers = new List<int>();

            for(int i=2; i<10000; i++)
            {
                int sum = 0;
                for(int j=1; j<i; j++)
                {
                    if(i%j == 0)
                    {
                        sum += j;
                    }
                }

                int sum2 = 0;

                for(int x=1; x<sum; x++)
                {
                    if (sum % x == 0)
                    {
                        sum2 += x;
                    }
                }

                if (sum2 == i && sum != i)
                {
                    amicableNumbers.Add(i);
                    amicableNumbers.Add(sum);
                }

            }
            Console.WriteLine(amicableNumbers.Sum()/2);
            Console.ReadKey();
        }

        public static void NameScores()
        {
            string inputLine;

            StreamReader sr = new StreamReader(@"..\..\p022_names.txt");

            inputLine = sr.ReadToEnd();

            string[] enteredLines = inputLine.Split(new string[] { ",", ""}, StringSplitOptions.RemoveEmptyEntries);

            List<string> names = enteredLines.AsEnumerable().ToList();

            names.Sort();

            List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int[] scores = new int[names.Count()];

            var x = names[937];

            int i=0;

            foreach(string name in names)
            {
                scores[i] = 0;

                foreach(char sign in name)
                {
                    if(alphabet.Contains(sign))
                    {
                        scores[i] += alphabet.IndexOf(sign)+1;
                    }
                }

                scores[i] *= (names.IndexOf(name)+1);

                i++;
            }

            BigInteger sume = scores.Sum();

            Console.WriteLine(sume);

        }
        
        public static void LexicographicPermutations()
        {
            List<long> list = new List<long>();

            string tempNumber;

            char[] listOfNumber = new char[10];

            string number = "0123456789";

            listOfNumber = number.ToCharArray();

            long temp = 0123456789;
            
            while (list.Count() < 1000000)
            {
                var x = temp.ToString("D10");

                char[] y = x.ToCharArray();

                bool condition = true;

                foreach(char z in listOfNumber)
                { 
                    if(!y.Contains(z))
                    {
                        condition = false;
                        break;
                    }
                }

                if(condition)
                {
                    list.Add(temp);
                    Console.WriteLine(temp + " " + list.Count());
                }


                temp++;

            }

            Console.WriteLine("asd");

        }

        public static void Fibonacci1000()
        {
            List<BigInteger> list = new List<BigInteger>();
            list.Add(1);
            list.Add(2);

            decimal sum = 0;
            for (int i = 1; i < list.Count(); i++)
            {
                BigInteger temp = list[i - 1] + list[i];
                list.Add(temp);
                char[] x = temp.ToString().ToCharArray();
                Console.WriteLine(temp);
                if(x.Count() == 1000)
                {
                    Console.WriteLine(list.Count() + 1);
                    Console.ReadKey();
                }


            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }            

        public static void ReciprocalCycles()
        {
            double x = 1;

            bool condition = true;
            double i = 1;
            List<double> score = new List<double>();

            while(i<1000)
            {

                x = 1 / i;
                i++;
                Console.WriteLine(x.ToString());

                char[] y = x.ToString().ToCharArray();

                for(int j=1; j<y.Count()-1; j++)
                {
                    if (y[j] == y[j + 1])
                    {
                        break;
                        score.Add(i);
                    }
                }

            }
        }

        public static void DistinctPowers()
        {
            List<double> powerList = new List<double>();

            for(int i=2;i<=100;i++)
            {
                for(int j=2; j<=100;j++)
                {
                   double temp = Math.Pow(i, j);
                    if(!powerList.Contains(temp))
                    {
                        powerList.Add(temp);
                    }
                }
            }

            Console.WriteLine(powerList.Count().ToString());
            Console.ReadKey();
        }

        public static void NumberSpiralDiagonals()
        {

            List<int> steps = new List<int>();
            List<int> numbers = new List<int>();
            int sum = 1;

            numbers.Add(sum);

            for(int i=2; i<=1001;i=i+2)
            {
                steps.Add(i);
            }

            foreach(int x in steps)
            {
                for(int y=0;y<4;y++)
                {
                    sum += x;
                    numbers.Add(sum);
                }
            }
            Console.WriteLine(numbers.Sum().ToString());
            Console.ReadKey();
        }

        public static void DigitFifthPowers()
        {
            List<double> fifthPowNumb = new List<double>();
            List<double> powers = new List<double>();

            for(int i=0;i<10;i++)
            {
                powers.Add(Math.Pow(i, 5));
            }

            for (int x = 10000; x <= 99999; x++)
            {

                double tempNumber = x;
                string numberString = x.ToString();
                char[] numberChars = numberString.ToCharArray();
                int[] intNum = new int[5];
                int u=0;
                foreach(char z in numberChars)
                {
                    intNum[u] = Int32.Parse(z.ToString());
                    u++;
                    tempNumber -= powers[Int32.Parse(z.ToString())];
                    if(tempNumber<0)
                    {
                        break;
                    }
                    else if(tempNumber == 0)
                    {
                        fifthPowNumb.Add(x);
                    }
                }
            }

            Console.WriteLine(fifthPowNumb.Sum().ToString());

                Console.ReadKey();
        }

        public static void CardanoTriplets()
        {
            Func<double,double,double, Tuple<double,double,double>> tc = Tuple.Create;
           var cardano = new List<Tuple<double,double,double>>();
           double term = 100;
            while(term>0)
            {
                for (double b = 1; b < 100; b++)
                {
                    for (double a = 1; a < 100; a++)
                    {
                        if (a + b > term) break;
                        double c = term - a - b;
                            double pow = Math.Pow(c, 1D / 2);
                            double x = a + (b * pow);
                            double y = a - (b * pow);
                            if (y < 0) break;
                            double term1 = Math.Pow(x, 1D / 3);
                            double term2 = 1 - Math.Pow(y, 1D / 3);
                            Console.WriteLine(a.ToString() + " " + b.ToString() + " " + c.ToString());
                            if (term1 == term2)
                            {
                                cardano.Add(tc(a, b, c));
                            }

                    }

                }
                term--;
            }

        } // Problem 251
    }
}
