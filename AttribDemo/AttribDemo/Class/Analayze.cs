using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo.Class
{
    class Analayze
    {
        public void AnalayzeAssembly(Assembly ass)
        {
            var allTypes = ass.GetTypes();
            foreach (var type in allTypes)
            {
                var kind = type.GetCustomAttributes(typeof(CodeReviewAttribute));
                foreach (var attribute in kind)
                {
                    var att = (CodeReviewAttribute) attribute;
                    Console.WriteLine(att.ToString());
                }
                
            }
        }
    }
}
