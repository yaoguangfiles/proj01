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
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            //var day2 = new Day2();
            //day2.Log("My message");
            //day2.Log("My new message", 145);

            //Day1Examples();
            //Day2Examples();
            //Day3Examples();
            //Day3QueueExample();
            Day3StackExample();
        }

        public struct Day3Struct {
            public int id;
            public string name;
            private string otherName;
            private List<string> colors;

            public Day3Struct(int id, string name) {
                this.id = id;
                this.name = name;
                this.otherName = name;
                colors = new List<string>();
            }

            public void AddId(int num) {
                this.id += num;
            }

            public void AddColor(string color) {
                colors.Add(color);
            }

            public void Print() {
                foreach(string color in colors)
                {
                    Console.WriteLine(color);
                }
            }
        }

        public static void WontChange(Day3Struct mystruct) {
            mystruct.id = 0;
        }

        public static void WillChange(Day3Struct mystruct) {
            mystruct.name = "someting";
        }

        public static void Day3Examples() {
            var MyList = new List<string>();
            //var firstItem = MyList[0];
            MyList.Add("Seth");
            string[] names = { "Miles", "Josh", "Jim", "Sarah", "Charlotte" };
            MyList.AddRange(names);

            for (int i = 0; i < MyList.Count; i++)
            {
                if(MyList[i] == "Charlotte")
                {
                    MyList.Remove(MyList[i]);
                }

                if ( MyList[i] == "Charlotte")
                {
                    MyList.RemoveAt(i);
                }

                MyList.ForEach(item => MyList.Remove(item));

                foreach(var item in MyList)
                {
                    if(item == "Charlotte")
                    {
                        MyList.Remove(item);
                    }
                }
            }
        }

        public static void Day3DictionaryExample() { //Y: what is the difference between C# dictionary and sortedList
            var cities = new Dictionary<string, string>();
            cities.Add("North Carolina", "Charlotte");
            cities.Add("South Carolina", "Columbia");
            cities.Add("West Virginia", "Charleston");
            var charlotte = cities["North Carolina"];
            cities.Remove("South Carolina");

            foreach(KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine($"The state is {kvp.Key} and it's city is {kvp.Value}");
            }

            cities.Clear();
            cities["North Carolina"] = "Raleigh";
            var cityNames = cities.Values;
            var stateNames = cities.Keys;
        }

        public static void Day3SortedListExample() { //Y: what is C# SortedList?
            var cities = new SortedList<string, string>(); //C++ hash map
            cities.Add("North Carolina", "Charlotte");
            cities.Add("South Carolina", "Columbia");
            cities.Add("West Virginia", "Charleston");
            var charlotte = cities["North Carolina"];
            cities.Remove("South Carolina");

            cities.Clear();
            cities["North Carolina"] = "Raleigh";
            var cityNames = cities.Values;
            var stateNames = cities.Keys;
        }

        public static void Day3QueueExample() {
            var myQueue = new Queue<string>();
            myQueue.Enqueue("Seth");
            myQueue.Enqueue("Miles");
            myQueue.Enqueue("Charlotte");
            myQueue.Enqueue("James");

            var name = myQueue.Dequeue();
            myQueue.Peek();
            myQueue.Clear();

            string[] queueOfName = { "" };
            myQueue.CopyTo(queueOfName, 0);
        }

        public static void Day3StackExample() {
            var myStack = new Stack<int>();
            myStack.Push(42);
            myStack.Push(13);
            myStack.Push(21);
            myStack.Push(35);

            //int number = myStack.Pop();
            int[] numArray = { };
            //myStack.CopyTo(numArray, 0);
            //myStack.Clear();
            if (myStack.Contains(13))
            {

            }
            Console.WriteLine(myStack.ToString());
            foreach(var item in myStack)
            {
                Console.WriteLine(item);
                myStack.Pop();
            }
        }

        public static void Day3Sorting() { //Y: bath room
            Dog dog = new Dog("Test Dog", "Black", true);

            Console.WriteLine(dog);
            Console.WriteLine(dog.ToString());

            List<Dog> dogList = new List<Dog>();
            dogList.Add(new Dog("Princess", "Orange", true));
            dogList.Add(new Dog("Bob", "Blue", true));
            dogList.Add(new Dog("Mark", "Golden", false));

            List<Dog> dogList2 = new List<Dog>(dogList);


        }

        //public static void Day3Examples() {
        //    Day3Struct testStruct = new Day3Struct(1, "Joe");

        //    Console.WriteLine(testStruct.name);
        //    WillChange(testStruct);
        //    Console.WriteLine(testStruct.name);
        //}

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
