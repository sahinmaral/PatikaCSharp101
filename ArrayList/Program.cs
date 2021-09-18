using System;
using System.Collections;
using System.Collections.Generic;


namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add("Ayşe");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add('A');

            Console.WriteLine(arrayList[0]);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            int[] numberArray = new int[] { 1, 2, 3, 4 };
            List<int> numberList = new List<int>() { 1, 2, 3, 4 };

            arrayList.Add(numberArray);
            arrayList.Add(numberList);
            
            //You can sort arrayList but every item of arrayList has to be same variable
            //because you cannot get error at compiler time but you can get error at runtime
            
            arrayList.Sort();
            
            arrayList.Clear();
            
        }
    }
}