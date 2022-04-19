// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Training.Data;

namespace Training{
    public class Program{

        /*
         This is a mult-line comment
         
         The compiler ignores comments
        */
        public const string constName = "new name";
        public static string staticName = "Seth";
        public string myName = "Yao";

        //comment
        //this is your main class
        public static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            var day2 = new Day2();
            day2.Log("My message");
            day2.Log("My new message", 145);

            //Day1Examples();
            Day2Examples();
        }

        public static void Day2Examples() {
            var day2 = new Day2();
            day2.Log("My message");
            day2.Log("My new message", 145);

            //C# is pass by ref for objects and pass by value for primitives
            Day1 testItem = new Day1(3, "Test");
           

            Console.Write($"Starting ID: { testItem.Id}");
            day2.ChangeDay1(testItem);
            Console.Write($"Ending ID: { testItem.Id}");

            int testInt = 3;
            Console.Write($"Starting ID: { testInt}");
            // can be changed 
            day2.WontChange(ref testInt);
            //day2.WontChange( testInt);
            Console.Write($"Ending ID: { testInt}");
            day2.ThrowExample(-1);
        }

        /// <summary>
        ///  documentation comment changed
        /// </summary>
        public static void Day1Examples() {
            Console.WriteLine("Day 1 stuff");

            int _int = 1; //in is your whole numbers

            //generally double
            //may see float, and may see decimal
            //double suffix d/D
            //float suffix f/F
            //decimal suffix m/M
            double _double = 2.0, _double2 = 2.0d;
            float _float = 3.0f;
            decimal _decimal = 4.0m;

            //must cast to work together
            double total = _double + (double)_float + (double)_decimal;

            //very JS or python like, but can define variables as var
            var anything = "string"; //O: The following code example uses a var to store an int value, a string value, and an array of numbers. 
                                     // f: https://www.c-sharpcorner.com/article/what-does-var-mean-in-c-sharp/

            string name = "Test";
            String name2 = "test";

            bool _bool = true;
            char _char = 'A', _char2 = 'a';

            Console.WriteLine(_char.Equals(_char2));

            //same namespace
            Day1 sameNamespace = new Day1();
            
            //constName = "new name"; cannot reassign constants
            staticName = "seth clossman"; // can reassign statics
            sameNamespace.PositiveNum = (int)_double;
            sameNamespace.Name = staticName;

            Console.WriteLine("Same Namespace ID: " + sameNamespace.PositiveNum);
            Console.WriteLine(sameNamespace.SayHello());

            Day1 same2 = new Day1(1, "Dan Pickles");

            Console.WriteLine(@"some random filepath: C:\");

            Console.WriteLine(sameNamespace.SayHello());
            Console.WriteLine(same2.SayHello());

            IEnumerable<int> anyEnumerable = sameNamespace.CovariantReturn();

            //examples of covariance, works because they all implement animal
            //can use all of the shared methods between them
            //Animal animal = new Animal();
            Animal dog = new Dog("Fiddo", "Grey", false );
            Animal cat = new Cat("Kitty", "Black", "Green");

            Console.WriteLine(dog.GetType());
            Console.WriteLine(cat.GetType());
            Console.WriteLine(dog.View());
            Console.WriteLine(cat.View());

            Console.WriteLine($"I am a {dog.Color} and my name is {dog.Name}");
            //need to cast it to use dog specific methods and variables
            Dog sameDog = dog as Dog;
            Console.WriteLine($"Has collar: {sameDog.Collar}");

            Dog stillSameDog = (Dog)dog;
            Console.WriteLine($"Has collar: {stillSameDog.Collar}");

            Console.WriteLine(dog.Speak());
            Console.WriteLine(cat.Speak());
            Console.WriteLine(dog.Move(5));
            Console.WriteLine(cat.Move(5));

            //cannot instantiate an interface
            IAnimal bear = new Bear("Yogi", "Brown");

            // do not need an instance of the class to call
            Console.WriteLine(StaticClass.Greet());

            StaticClass c1 = new StaticClass("Tim");
            StaticClass c2 = new StaticClass("Bob");
            StaticClass c3 = new StaticClass("Joe");
            StaticClass.count = StaticClass.count + 1; // don't need instance of the class

            Console.WriteLine($"{c1.Name}: " + c1.NumOfClasses());
            Console.WriteLine($"{c2.Name}: " + c2.NumOfClasses());
            Console.WriteLine($"{c3.Name}: " + c3.NumOfClasses());
        }
    }
}
