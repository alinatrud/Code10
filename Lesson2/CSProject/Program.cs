namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
        // string shoppingListItem_1 = "Хлеб";
        // string shoppingListItem_2 = "";
        
        // string[] shoppingList = { "bread", "milk", "cola" };
        
        // System.Console.WriteLine(shoppingList.Length);

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine(i);
        // }

        // A 1.
        int[] array = new int[5];

        // A 2.
        string[] array_str = { "1", "2", "3",};

        // B 3.
        int[] array_int = { 1, 2, 3, 4, 5 };
        // System.Console.WriteLine(array_int[1]);
        array_int[2] = 100;
        // System.Console.WriteLine(array_int[2]);

        // B 4.
        System.Console.WriteLine(array_int.Length);

        // C 5.
        float[] array_float = new float[4];

        // System.Console.WriteLine(array_float[3]);

        // С 6.
        let myArray = new Array(5);
        
        // С 7.
        string[] array_str = { "1", "2", "3",};

        // С 8.
        let myArray = new Array(5);
        myArray[0] = 10;
        myArray[1] = 20;
        myArray[2] = 30;
        myArray[3] = 40;
        myArray[4] = 50;
    }
}