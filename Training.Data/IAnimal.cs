using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Data {
    public interface IAnimal {
        //can define getters and setters in an interface, but not variables
        //no method bodies either
        public string View();

        public string Move(int distance);

        public string Speak();

        //public string View() {
        //    return $"I am a {this.Color} animal, my name is {this.Name}";
        //}

    }
}
