using System;
using System.Text;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string message = "";
            string alphaNumOutput = "";
            int checkSum = 0;
            int encodedCharNum = 0;
            int encodedCharNum2 = 0;

            Console.WriteLine("Enter in any phrase that you would like to be encoded:");
            string input = Console.ReadLine();
            input = input.ToUpper();

            byte[] stringBytes = Encoding.Unicode.GetBytes(input);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("{0:X}-", (int)c));

            // The following code is the checkSum solution behaviour
            
            foreach (byte cSum in stringBytes)
            {
                checkSum = checkSum + cSum;
            }

            // This following code is one method that produces the encoded message solution

            foreach (byte workingByte in stringBytes)
            {
                encodedCharNum = (int)workingByte - 64;
                if (encodedCharNum > 0)
                {
                    // Console.WriteLine(testing);
                    alphaNumOutput = "" + alphaNumOutput + encodedCharNum + "-";
                }
            }

            // This following code is another method that produces the encoded message solution

            foreach (char workingChar in input)
            {
                encodedCharNum2 = (int)workingChar - 64;
                if (encodedCharNum2 > 0)
                {
                    // Console.WriteLine(encodedCharNum2);
                    message = "" + message + encodedCharNum2 + "-";

                }
            }

            Console.WriteLine("Your encoded message is: " + message); // This is a method that produces the answer is most common

            Console.WriteLine("(A second way to solve) Your encoded message is: " + alphaNumOutput); // This is a method that produces the answer

            Console.WriteLine("Your Unicode message is: " + builder); // I thought this is what we initially had to do, until I re-read the rubic

            Console.WriteLine("The message checksum is: " + checkSum);
        }
    }
}
