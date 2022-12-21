using System;
using System.Collections;

public static class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        // Console.WriteLine("Hello, World!");

        // INFO: declaring an arraylist
        ArrayList list1 = new ArrayList();

        // INFO: declaring an arraylist w/ initial size
        ArrayList list2 = new ArrayList(200);

        // ArrayLists can store objects of different types
        list1.Add(25);
        list1.Add("Hello");
        list1.Add(3.14159);
        list1.Add('c');

        // remove/delete an element from the list
        list1.Remove('c');
        // NOTE: this removes the 1st instance of the element, not all instances

        // remove/delete at a specific index
        list1.RemoveAt(0);

        // get the number of elements inside a list
        Console.WriteLine(list1.Count);

        // arraylists support enhanced for loops
        foreach (var element in list1)
        {
            Console.WriteLine(element);
        }

    }
}
