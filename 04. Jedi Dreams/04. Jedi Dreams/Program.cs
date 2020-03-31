using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Jedi_Dreams
{
    class Program
    {
        public static SortedSet<string> allMethodsNames = new SortedSet<string>();
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            List<Method> allMethods = new List<Method>();
            Method currentMethod = new Method();

            for (int i = 0; i < length; i++)
            {
                var line = Console.ReadLine();

                if (line.Contains("static"))
                {
                    var methodName = GetMethodName(line);
                    if (!allMethodsNames.Contains(methodName))
                    {
                        allMethodsNames.Add(methodName);
                        var newMethod = new Method(methodName);
                        currentMethod = newMethod;
                        allMethods.Add(newMethod);
                    }
                }
                else
                {
                    ParseMethod(line, currentMethod);
                }

                //continue with extracting rest of methods
            }

            // Printing
            foreach (var item in allMethods)
            {
                Console.WriteLine("{0} -> {1} -> {2}", item.MethodName, item.NumberOfMethods, string.Join(", ", item.Methods));
            }
        }

        

        public static void ParseMethod(string line, Method currentMethod)
        {
            // int counter = line.Count(x => (x == '.'));
            // var newMethods = line.Split(new[] { '.', '(' }, StringSplitOptions.RemoveEmptyEntries); // check for uppercase

            var rx = new Regex(@"\.\w+\(>", RegexOptions.Compiled);
            var matches = rx.Matches(line);

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    currentMethod.Methods.Add(match.ToString());
                    currentMethod.NumberOfMethods++;
                }
            }
        }

        public class Method
        {
            private string _methodName;
            private int _numberOfMethods;
            private SortedSet<string> _methods;

            public Method()
            {

            }

            public Method(string methodName)
            {
                this.MethodName = methodName;
                this.Methods = new SortedSet<string>();
                this.NumberOfMethods = 0;
            }


            public string MethodName { get { return this._methodName; } set { this._methodName = value; } }
            public int NumberOfMethods { get { return this._numberOfMethods; } set { this._numberOfMethods = value; } }
            public SortedSet<string> Methods { get { return this._methods;  } set { this._methods = value; } }
        }

        private static string GetMethodName(string line)
        {

            var split = (line.Substring(0, line.IndexOf('('))).Split(null);
            string methodName = split[split.Length - 1];

            return methodName;
        }
    }
}
