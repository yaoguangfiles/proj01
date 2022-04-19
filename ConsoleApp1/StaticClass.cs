using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training {
    public class StaticClass {

        //static variable are the same for every instance ...
        public static int count = 0;
        //variables are different per instance of a class

        //public static int Count { get; set; }

        public string Name { get; set; }

        public StaticClass(string name) {
            this.Name = name;
            count = count + 1;
        }

        public string NumOfClasses() {
            return $"There are {count} StaticClass";
        }

        public static string Greet() {
            return "Hello from the static class";
        }
    }
}
