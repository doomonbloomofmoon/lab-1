using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    internal class Part_4_4 : Part
    {
        string exercise = "4.4. Задан текст. После каждой буквы \"о\" вставить сочетание \"Oк\".";
        string text;

        public Part_4_4(string _text) 
        {
            this.text = _text;
        }
        
        public override void Do()
        {
            OutTask(exercise);

            Console.WriteLine("Исходный текст: \n" + text);

            StringBuilder result = new StringBuilder();

            foreach (char letter in text)
            {
                result.Append(letter);

                if (letter == 'о' || letter == 'О')
                    result.Append("Ок");
            }

            Console.WriteLine("Результат работы: ");

            Console.WriteLine(result.ToString());

            Console.WriteLine();
        }
    }
}
