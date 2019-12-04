using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETContainerExercises
{
    
    class Program
    {

        /*public static void ArrayExample(int size)
        {
            int[] array = new int[size];
            foreach (int value in array)
            {
                array[value] = value;
                Console.WriteLine(array[value]);
            }
        }*/

        /*public static void parameter(int size)
        {
            int[] array = new int[size];
            foreach (int value in array)
            {
                array[value] = value + 1;
                Console.WriteLine(array[value]);

            }
        }*/

        /*public static void ListExample()
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(2);
            myList.Add(9);
            myList.Sort();
            int[] listCopy = new int[myList.Count];
            //myList.RemoveRange(3, 2);
            for (int idx = 0; idx < myList.Count; idx++)
            {
                listCopy[idx] = myList[idx];
                
                Console.WriteLine(myList[idx]);
                Console.WriteLine(listCopy[idx]);
            }
            //myList.RemoveRange(0, 4);
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }*/

        /*public static void StackExample()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(3);
            myStack.Push(1);
            Console.WriteLine(myStack.Pop());
            myStack.Push(2);
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }*/
        public static void DictionaryExample()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(0, "CAR");
            myDictionary.Add(1, "DOG");
            myDictionary[5] = "BIRB";

            Console.WriteLine(myDictionary[5]);
        }
        static void Main(string[] args)
        {
            /*TestClass[] tC = new TestClass[5];
            int[] testCopy = new int[5];
            //ArrayExample(5);
            //parameter(5)
            for (int i = 0; i < tC.Length; i++)
            {
                tC[i] = new TestClass();
                tC[i].names = "BOI";
                tC[i].age = i;
                testCopy[i] = tC[i].age;
                Console.WriteLine(tC[i].names);
                Console.WriteLine(tC[i].age);
                Console.WriteLine(testCopy[i]);
            }
            tC[0].age = 1;*/
            //ListExample();
            //StackExample();
            DictionaryExample();
            Console.ReadLine();
        }

    }
}
