using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    abstract internal class Part
    {
        protected void OutTask(string _exercise)
        {
            Console.WriteLine(_exercise + "\n");
        }

        public abstract void Do();
    }
}
