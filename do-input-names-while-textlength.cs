using System;

namespace DoWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Enter a friend's name: ");
                string friendsName = Console.ReadLine();
                int currentLength = friendsName.Length;
                lengthOfText += currentLength;
                wholeText += friendsName;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough " + wholeText);
            Console.Read();
        }
    }
}
