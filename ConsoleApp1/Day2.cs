using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training {
    public class Day2 {


        public void Log(string msg) {
            Console.WriteLine(msg);
        }

        public void Log(int msg) {
            Console.WriteLine(msg);
        }

        public void Log(double msg) {
            Console.WriteLine(msg);
        }

        public void Log(float msg) {
            Console.WriteLine(msg);
        }

        public void Log(object msg) {
            Console.WriteLine(msg.ToString());
        }

        public void Log(string msg, int logType) {
            string[] myArray = new string[] { "Miles", "Seth", "Tom" };
            int[] numberArray = new int[] { 1, 2, 3, 4 };

            //Console.WriteLine(msg);
            foreach(var item in myArray)
            {
                Log(item);
                Log(msg);
                Log(logType);
            }

            for(int i = 0; i < myArray.Length; i++)
            {
                Log(myArray[i]);
            }

            //passes a reference, anything done to numArray2 will change numberArray and vice-versa
            //int[] numArray2 = numberArray;


            //int[] numArray2 = new int[numberArray.Length];
            ////Array.Copy(numberArray, numArray2, numberArray.Length);
            //numberArray.CopyTo(numArray2, 0);
            ////numberArray.ToList().ForEach(Console.WriteLine);

            //numArray2[0] = 7;
            //numArray2[1] = 5;

            //int j = 0;
            //while(j < numberArray.Length)
            //{
            //    Console.WriteLine($"numberArray: {numberArray[j]}");
            //    Console.WriteLine($"numberArray: {numArray2[j]}");
            //    j++;
            //}

            string[] arr = { "Apple", "Banana", "Orange" };
            int[,] arr2 = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } };

            //arr2.ToList().ForEach(IThreadPoolWorkItem => Log(msg));

            //List<int> arr3 = arr2.Cast<int>().ToList();
            //arr3.ForEach(Console.WriteLine);

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for(int j = 0; j < arr2.GetLength(1); j++)
                {
                    Log(arr2[i, j]);
                }
            }

        }

        public void DoWhile() {
            int i = 0;
            do
            {
                Console.WriteLine("Happens before the while check and then again after");
                i++;
            }
            while (i < 10);
        }

        public void IfExample(int numberToCheck) {
            if (numberToCheck < 0)
            {

            }
            else if (numberToCheck < 10)
            {

            }
            else
            {
                
            }

            var myInt = numberToCheck < 0 ? 1 : 0;
        }


        // case switch break default example
        public string CaseSwitchExample(int testNum) {
            //int testNum = 0;
            string retVal = "";

            try
            {
                switch (testNum)
                {
                    case 1:
                        throw new NullReferenceException(); // throw new ArgumentException();
                        break;
                    case 2:
                        retVal = "Two";
                        break;
                    default:
                        retVal = "Zero";
                        break;
                }

            }
            catch (NullReferenceException ex)
            {
                Log($"A null reference exception occured {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Log($"A argument null exception occured {ex.Message}");
            }
            catch (Exception ex)
            {
                Log($"A exception occured outside of the types specified {ex.Message}");
            }
            finally
            {
                Log("Finally step ran");
            }

            //try
            //{
            //    switch (testNum)
            //    {
            //        case 1:
            //            retVal = "One";
            //            break;
            //        case 2:
            //            retVal = "Two";
            //            break;
            //        default:
            //            retVal = "Zero";
            //            break;
            //    }

            //}
            //catch(Exception)
            //{
            //    Log("A null reference exception occured");
            //}
            //finally
            //{

            //}

            return retVal;

        }

        public void ThrowExample(int testNum) {
            if (testNum < 0)
            {
                throw new Exception("You did something wrong!");
                

            }
        }


        //
        public class MyCustomException : Exception {
            public MyCustomException(string msg) : base(msg) {

            }
        }

        //objects are pass by ref
        public void ChangeDay1(Day1 item) {
            item.Id = 75;
        }

        public void WontChange(ref int num) {
            num = 75;
        }


        ////primitives are pass by value
        //public void WontChange(int num) {
        //    num = 75;
        //}
    }

}
