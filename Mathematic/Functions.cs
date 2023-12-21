using System;
using System.Collections.Generic;
using System.Linq;
//Big Masoud 
//Instagram : uniquemasso
//Github : Masoud1384
namespace Mathematic
{
    public class Functions
    {
       public static bool PrimeNumber(int number)
       {
           if (number < 2)
             return false;
           
           for (int i = 2; i < number; i++)
           {
               if (number % i == 0)
                  return false;
           }
           return true;
       }
        public static bool IsPair(int number)
        {
            if (number % 2 == 0)
                return true;

            return false;
        }
        public static int ChandRagham(string number)
        {
            return number.Length;
        }
        public static bool PerfectNumber(int number)
        {
            var list = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (!(i % 2 == 0))
                {
                    list.Add(i);
                }
            }
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
                if (sum == number)
                {
                    return true;
                }
            }

            return false;

        }
        public static int DivideWithoutOperator(int number, int numberDividedTo, out int rest)
        {
            int num = number;
            int count = 0;
            while (num >= numberDividedTo)
            {
                num = num - numberDividedTo;
                count++;
            }
            rest = num;
            return count;
        }
        public static void ShowAllTypesOfANumber(int num)
        {
            int temp = num;
            int count = 0;
            int k = 10;
            while (temp > 0)
            {
                count++;
                int b = temp % k;
                Console.Write(b + "\t");
                temp = temp / 10;
            }
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                int temp2 = num;
                k = k * 10;
                while (temp2 > k - 1)
                {
                    int b = temp2 % k;
                    Console.Write(b + "\t");
                    temp2 = temp2 / 10;
                }
                Console.WriteLine();
            }
        }
        public static bool Exist(int first, int second)
        {
            int k = 1;
            int a = 0;
            int temp1 = first;
            int temp2 = second;
            while (true)
            {
                if (temp2 > 0)
                {
                    k *= 10;
                    temp2 /= 10;
                }
                else
                    break;
                a++;
            }
            for (int i = 0; i < a; i++)
            {
                temp2 = second;
                if (temp1 % k == temp2)
                    return true;
                else
                    temp1 /= 10;
            }
            return false;
        }
        public static List<int> Coefficient(int number)
        {
            var list = new List<int>();
            for (int i = 1; i <= number * 10; i++)
            {
                if (i % number == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public static int Reciprocal(int number)
        {
            int temp = number;
            int k = 10;
            string a = "";
            while (temp > 0)
            {
                a += temp % k;
                temp = temp / 10;
            }
            return Convert.ToInt32(a);
        }
        public static double GramTooKilo(double vaznBeGeram)
        {
            var grm = Convert.ToDouble(vaznBeGeram);
            const double kiloo = 1000;
            double thistothat = grm / kiloo;
            return thistothat;
        }
        public static int Factoriel(int number)
        {
            int factorial = 1;
            for (int i = 1; i < number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static List<int> Duplicate(List<int> numbers)
        {
            List<int> unique = new List<int>();
            foreach (var item in numbers)
            {
                if (!unique.Contains(item))
                {
                    unique.Add(item);
                }
            }
            return unique;
        }
        public static TimeSpan SecToTime(long second)
        {
            return TimeSpan.FromSeconds(second);
        }
        public static void ShowBetweenNumbers(int first, int second)
        {
            int max;
            int min;
            if (first > second)
            {
                max = first;
                min = second;
            }
            else
            {
                max = second;
                min = first;
            }
            for (int i = min + 1; i < max; i++)
            {
                Console.Write(i + "\t");
            }
        }
        public static int GCD(int first, int second)
        {
            var list = new List<int>();
            int max;
            int min;
            if (first > second)
            {
                max = first;
                min = second;
            }
            else
            {
                min = first;
                max = second;
            }
            for (int i = 1; i < max; i++)
            {
                if ((max % i == 0) && (min % i == 0))
                {
                    list.Add(i);
                }
            }
            int biggest = 0;
            foreach (var item in list)
            {
                if (item > biggest)
                    biggest = item;
            }
            return biggest;
        }
        public static int LCM(int first, int second)
        {
            var list = new List<int>();
            int max;
            int min;
            if (first > second)
            {
                max = first;
                min = second;
            }
            else
            {
                min = first;
                max = second;
            }
            var zaribMax = Coefficient(max);
            var zaribMin = Coefficient(min);
            foreach (var item in zaribMax)
            {
                foreach (var item2 in zaribMin)
                {
                    if (item == item2)
                    {
                        list.Add(item);
                    }
                }
            }
            return list.Min();
        }
        public static decimal BMI(decimal weight, decimal hightByMeter)
        {
            var high = hightByMeter;
            for (int i = 1; i < 2; i++)
            {
                high *= high;
            }
            return weight / high;
        }
        public static int SumOfBeetweenNumbers(int first, int second)
        {
            int max;
            int min;
            if (first > second)
            {
                max = first;
                min = second;
            }
            else
            {
                min = first;
                max = second;
            }
            int sum = 0;
            for (int i = min; i < max + 1; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Reverser(int Number)
        {
            var zarib = 10;
            var num = Number;
            List<int> list = new List<int>();
            for (int i = 0; i < Number.ToString().Length; i++)
            {
                var theNumber = num % zarib;
                list.Add(theNumber);
                num /= zarib;
            }
            string ret = "";
            foreach (var item in list)
            {
                ret += item;
            }
            return int.Parse(ret);
        }
        public static int Powerby(int Number, int power)
        {
            int num = Number;
            for (int i = 1; i < power; i++)
            {
                num *= Number;
            }
            return num;
        }
        public static int Round(double Number)
        {
            int formNum = (int)Number;
            var number = Number.ToString();
            var Num = number.Split('.');
            var strNum = Num[1].ToString();
            var mainNum = strNum[0];
            if (Convert.ToInt32(mainNum) >= 5)
            {
                return formNum + 1;
            }
            return formNum;
        }
        public static List<int> Mode(ref int mod, List<int> parameter)
        {
            var list = parameter;
            var Number1 = new List<int>();
            int bigCount = 0;
            int bigCount2 = 0;
            int refer = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        bigCount++;
                        Number1.Add(list[i]);
                    }
                }
                if (bigCount > bigCount2)
                {
                    refer = list[i];
                    bigCount2 = bigCount;
                }
            }
            mod = refer;

            var unique = new List<int>();
            foreach (var item in Number1)
            {
                if (!unique.Contains(item))
                    unique.Add(item);
            }
            return unique;
        }
        public static double Radical(double Num)
        {
            return Math.Pow(Num, 0.5);
        }
        public static double Variance(List<double> numbers)
        {
            var sum = numbers.Sum();
            var avrg = sum / numbers.Count;
            double variance = 0;
            foreach (var item in numbers)
            {
                double num = (item - avrg);
                variance += Math.Pow(num, 2);
            }
            var result = variance / numbers.Count;
            return result;
        }
        public static double StandardDeviation(List<double> numbers)
        {
            var sum = numbers.Sum();
            var avrg = sum / numbers.Count;
            double variance = 0;
            foreach (var item in numbers)
            {
                double num = (item - avrg);
                variance += Math.Pow(num, 2);
            }
            var resultVariance = variance / numbers.Count;
            return Radical(resultVariance);
        }
        public static double IQR(List<int> numbers)
        {
            //numbers.Sort();
            //if (numbers.Count == 7)
            //{
            //    decimal q2 = numbers.Count / 2;
            //    var IndexQ2 = Math.Round(q2);
            //    var Q2 = numbers[(int)IndexQ2];
            //    var Q1 = (numbers[1] + numbers[2])/2;
            //    var Q3 = numbers[5]+numbers[6];
            //    return Q3 - Q1;
            //}
            //else if (numbers.Count == 5)
            //{

            //}
            //else if (!IsPair(numbers.Count))
            //{
            //    decimal q2 = numbers.Count / 2;
            //    var IndexQ2 = Math.Round(q2);
            //    var Q2 = numbers[(int)IndexQ2];
            //}
            //else
            //{

            //}
            return 0;
        }
        public static int DivWithoutDivision(int number, int divTo)
        {
            int num = number;
            int count = 0;
            for (int i = number - 1; i >= 0; i--)
            {
                num -= divTo;
                if (num != 0 && num > divTo)
                    count++;
            }
            return count;
        }
        public static int nonadjacent(List<int> numbers)
        {
            int sum = numbers[0];
            var nums = numbers.Skip(2);
            sum += nums.Sum();
            return sum;
        }
        public static List<int> GenerateSequence(int numTerms)
        {
            List<int> fibonacciSequence = new List<int>();

            if (numTerms >= 1)
            {
                fibonacciSequence.Add(0);
            }

            if (numTerms >= 2)
            {
                fibonacciSequence.Add(1);
            }

            if (numTerms > 2)
            {
                int prev = 0;
                int current = 1;

                for (int i = 3; i <= numTerms; i++)
                {
                    int next = prev + current;
                    fibonacciSequence.Add(next);
                    prev = current;
                    current = next;
                }
            }

            return fibonacciSequence;
        }
        public static int FindLargestPrimePalindrome(int limit)
        {
            for (int number = limit - 1; number >= 2; number--)
            {
                if (IsPrime(number) && IsPalindrome(number))
                {
                    return number;
                }
            }
            return -1; // No prime palindrome found within the limit
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        private static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();

            int left = 0;
            int right = numberString.Length - 1;

            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
