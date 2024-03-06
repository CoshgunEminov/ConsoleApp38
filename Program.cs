namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 100, 150, 300 };
            int largestNumber = FindLargestNumber(numbers);
            Console.WriteLine("boyuk eded: " + largestNumber);
        }

        static int FindLargestNumber(int[] numbers)
        {
            int largest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest;




            Console.WriteLine("Task 4");

            string str = "code";
            char ch1 = 'a';
            char ch2 = 'c';

            Console.WriteLine("Index of 'a' in 'code': " + FindCharIndex(str, ch1));
            Console.WriteLine("Index of 'c' in 'code': " + FindCharIndex(str, ch2));
        }

        static int FindCharIndex(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return i;
                }
            }
            return -1;

            Console.WriteLine("task1");


        }
    }
}