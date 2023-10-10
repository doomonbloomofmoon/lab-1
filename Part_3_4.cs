using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    internal class Part_3_4 : Part
    {
        string wordToFind;
        string inputString;
        string exercise = "3.4. Составить программу, которая будет вводить строку в переменную String. Определить, сколько раз в строке встречается заданное слово.";

        public Part_3_4(string _word, string _input)
        {
            this.wordToFind = _word;
            this.inputString = _input;
        }

        public override void Do()
        {
            OutTask(exercise);
            
            int count = 0;
            
            int startIndex = 0;

            while ((startIndex = inputString.IndexOf(wordToFind, startIndex)) != -1)
            {
                startIndex += wordToFind.Length;

                count++;
            }
            
            Console.WriteLine($"Исходный текст:\n{inputString}\n");
            
            Console.WriteLine($"Искомое слово '{wordToFind}' встречается {count} раз.");

            Console.WriteLine();
        }
    }
}
