using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Data {
    public abstract class Animal {

        //"internal" is only visible the same namespace/ assembly. Y: this is not inhirited?
        //"protected internal" is every thing derived or in the same namespace/ assembly. Y: can be infirited?
        //"protected private" only in the same class, or derived classes in the same namespace/ assembly. 
        public string Name { get; set; }
        public string Color { get; set; }

        private bool Tail { get; set; } // private means that is only accessible within the class
        protected bool Tail2 { get; set; } // is inhereited, but not accessible outside the class

        //ctor, tab, tab, for construtors
        public Animal() { }

        public Animal(string name, string color) {
            this.Name = name;
            this.Color = color;
        }

        public abstract string Speak();

        //has to be marked as virtual to be able to override it
        public virtual string View() {
            return $"I am a {this.Color} animal, my name is {this.Name}";
        }

        public abstract string Move(int distance);
    }
}
