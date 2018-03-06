using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Anonymous_Threatt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] tokens = command.Split();
                string commandName = tokens[0];

                if (commandName == "merge")
                {
                    //command is merge
                    int startIndex = ValidateIndex(int.Parse(tokens[1]), inputText.Count);
                    int endIndex = ValidateIndex(int.Parse(tokens[2]), inputText.Count);

                    inputText = MergeText(startIndex, endIndex, inputText);
                }
                else if (commandName == "divide")
                {
                    //command is divide
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    List<string> part = DivideText(inputText[index], partitions);
                    inputText.RemoveAt(index);
                    inputText.InsertRange(index, part);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputText));
        }

        static List<string> DivideText(string word, int partitions)
        {
            List<string> result = new List<string>();
            int part = word.Length / partitions;

            while (word.Length >= part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part); 
            }

            if (word != "")
            {
                result.Add(word);
            }
            if (result.Count == partitions)
            {
                return result;
            }
            else
            {
                string concat = result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concat);
                return result;
            }

        }

        static int ValidateIndex(int index, int length)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index >= length)
            {
                index = length - 1;
            }
            return index;
        }




        static List<string> MergeText(int startIndex, int endIndex, List<string> inputText)
        {
            string newValue = "";
            int length = endIndex - startIndex;

            for (int i = 0; i <= length; i++)
            {
                newValue += inputText[startIndex];
                inputText.RemoveAt(startIndex);
            }
            inputText.Insert(startIndex, newValue);
            return inputText;
        }
    }
}
