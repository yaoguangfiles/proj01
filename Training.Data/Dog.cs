using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Data {
    //colon for inheritance
    public class Dog : Animal, IAnimal {
        public bool Collar { get; set; }

        public Dog(string name, string color, bool collar) : base(name, color) {

        }

        public override string Speak() {
            return "Bark";
        }

        //public sealed string Speak() { //Y: what is sealed method
        //    return "Bark";
        //}

        public override string View() {
            return base.View() + $" Collar: {this.Collar}";
        }

        public override string Move(int distance) {
            return $"I ran {distance}";
        }
    }
}
