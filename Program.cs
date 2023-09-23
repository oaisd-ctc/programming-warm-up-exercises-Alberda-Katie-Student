
namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string a = "Hello World";
             int[] b = { 1, 5, 3, 5, 7, 1 };
               Console.WriteLine(Add(2, 4));
               Console.WriteLine(MaxOfThree(3, 5, 1));
               Console.WriteLine(StringLength(a));
               Console.WriteLine(IsEven(9));
               Console.WriteLine(StartsHello(a));
              Console.WriteLine(ConcatenateStrings("hello", "world"));
               Console.WriteLine(LargestInArray(b));
               Console.WriteLine(Factorial(4));
               Console.WriteLine(CharCount("lhellol", 'l'));
               Console.WriteLine(ArraySum(b));
               Console.WriteLine(IsPalindrome("billy"));
               Console.WriteLine(ReverseString("hello"));
               Console.WriteLine(IsPrime(16));
               Console.WriteLine(SwapEnds(a));
               Console.WriteLine(Fibonacci(4));
               */
        }

        public static int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int MaxOfThree(int a, int b, int c)
        {
            int max = a;

            if (max < b)
            {
                max = b;
            }
            else if (max < c)
            {
                max = c;
            }
            return max;
        }
        public static int StringLength(string s)
        {
            int length = 0;
            foreach (char letter in s)
            {
                length++;
            }
            return length;
        }

        public static bool StartsHello(string s)
        {
            // using the ToLower() function will handle inputs like "hELLo", "HELLO", "Hello" etc.
            // By converting to lowercase prior to any pattern matching
            return s.ToLower().StartsWith("hello");
        }
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int Factorial(int n)
        {
            int fact = 1;
            while (n > 1)
            {
                fact *= n;
                n--;
            }
            if (n == 0) return 1;
            return fact;
        }
        public static bool IsPrime(int number)
        {
            int a = 0;
            if (number <= 1) return false;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            // Handle the base cases
            if (n == 0 || n == 1) return n;

            int a = 0;
            int b = 1;
            int c = 0;
            int count = 0;

            while (count < n - 2)
            {
                count++;
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        public static bool IsPalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string a = new string(charArray);

            if (s == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int CharCount(string s, char c)
        {
            int count = 0;
            foreach (char a in s)
            {
                if (a == c)
                {
                    count++;
                }
            }
            return count;
        }

        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;

            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string a = s.Remove(0, 1);
            string b = a.Remove(a.Length - 1);

            return lastChar + b + firstChar;
        }
    }
}
