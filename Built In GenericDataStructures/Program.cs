using System;
using System.Collections;

//ref link:https://www.youtube.com/watch?v=A1C3Oo-Hkx8&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=8
//


class MainClass
{   
    static void Main()
    {
        //List<int> myList = new List<int>();
        //System.Collections.Queue q = new Queue();
        //System.Collections.Generic.
        ArrayList myList = new ArrayList();

        myList.Add(5); myList.Add("Kulpot");
        myList.Add(20);
        for (int i = 0; i < myList.Count; i++)
            Console.WriteLine(myList[i]);
    }
}