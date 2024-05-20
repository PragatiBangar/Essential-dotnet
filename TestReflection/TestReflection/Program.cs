
using Microsoft.VisualBasic;
using System;
using System.Reflection;

Console.WriteLine("Reflection Examples\n\n");

// Using GetType to obtain type information:
/*int i = 42;

Type type = i.GetType();
Console.WriteLine(type);

Console.WriteLine("---------------------------------------------------------------------------------");

// Initialise t as typeof string 
Type t = typeof(string);

// Use Reflection to find about 
// any sort of data related to t 
Console.WriteLine("Name : {0}", t.Name);
Console.WriteLine("Full Name : {0}", t.FullName);
Console.WriteLine("Namespace : {0}", t.Namespace);
Console.WriteLine("Base Type : {0}", t.BaseType);
*/


Assembly executing = Assembly.GetExecutingAssembly();

// Array to store types of the assembly 
Type[] types = executing.GetTypes();

foreach (var item in types)
{
    // Display each type 
    //Console.WriteLine("Class : {0}", item.Name);
    Console.WriteLine("Class : "+ item.Name);
    Console.WriteLine("\n");
    // Array to store methods 
    MethodInfo[] methods = item.GetMethods();
    foreach (var method in methods)
    {
        // Display each method 
        Console.WriteLine("--> Method : {0}", method.Name);

        ParameterInfo[] parameters = method.GetParameters();
        foreach (var arg in parameters)
        {
            // Display each parameter 
            Console.WriteLine("----> Parameter : {0} Type : {1}",
                                    arg.Name, arg.ParameterType);
        }
    }

    // Array to store parameters 
    

}