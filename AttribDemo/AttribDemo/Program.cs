using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AttribDemo.Class;

namespace AttribDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Assembly currenAssembly = Assembly.GetExecutingAssembly();
            Analayze analayze = new Analayze();
            analayze.AnalayzeAssembly(currenAssembly);
            Console.ReadLine();
        }
    }
}
