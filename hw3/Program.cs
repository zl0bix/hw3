using System.Data;

namespace hw3
{
    internal class Program
    {
        class Paint
        {
            public void F00(int num,char ch) 
            {
                for (int i = 0; i < num; i++)
                {
                    for(int j = 0; j < num; j++)
                        Console.Write(ch + " ");
                    Console.WriteLine();
                }
            }
        }

        class Palindrome
        {
            public static bool F01(int  num)
            {
                string str = Convert.ToString(num);
                int tmp = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == str[str.Length - j -1])
                        tmp++;
                                              
                }
                if (tmp == str.Length)
                    return true;
                return false;
            } 
        }

        static void Main(string[] args)
        {
            int sideA;
            char ch;
            Console.Write("Enter side of square -> ");
            sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter symbol -> ");
            ch = char.Parse(Console.ReadLine());
            Paint paint = new Paint();
            paint.F00(sideA, ch);

            if (Palindrome.F01(12321))
                Console.WriteLine("It is POLINDROME!!!");
            else
                Console.WriteLine("It is not POLINDROME!!!");


        }
    }
}