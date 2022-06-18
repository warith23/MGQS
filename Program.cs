using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("-------1------");
           Console.WriteLine("Enter the first word: ");
           string firstWord = Console.ReadLine();
           int firstwordLen = firstWord.Length;

           Console.WriteLine("Enter the second word: ");
           string secondWord = Console.ReadLine();
           int secondwordLen = secondWord.Length;

           int wordLength = firstwordLen + secondwordLen;
           int result = (wordLength > 20) ?  wordLength * 3 : wordLength + 20;
           Console.WriteLine(result);
           Console.WriteLine();
           


           Console.WriteLine("-----2-----");
           decimal costPrice = 200.876m;
           decimal sellingPrice = 255.425m;

           decimal profit = sellingPrice - costPrice;
           Console.WriteLine($"The selling price - cost price is: ${profit}");
           Console.WriteLine($"The profit is ${Math.Round(profit, 2)}");
            Console.WriteLine();



            Console.WriteLine("-------3-------");
            string word = Console.ReadLine();
            int index = word.IndexOf(word, 2);
            int wordLength = word.Lenght;
            int totalLenght = index + wordLength;
            char answer = char(totalLenght); 
            
            Console.WriteLine($"The total value is {totalLenght}, the index of the third character is {index}, the conversion to character is {answer}");;











          Console.WriteLine("------4------");
          Console.WriteLine("Input your first number: ");
          int firstNo = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Input your second number: ");
          int secondNo = Convert.ToInt32(Console.ReadLine());
                                                                                                                                                 
         int maxNo = Math.Max(firstNo, secondNo);
         Console.WriteLine($"The highest number is: {maxNo}");
         Console.WriteLine();








        }
    }
}
