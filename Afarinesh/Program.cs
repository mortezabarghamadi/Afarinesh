// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using Tamrin.classes;

List<int> mylist = new List<int>()
    ;
Console.WriteLine("please specify the number of entries in the lis");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter the number");
for (int i = 0; i < n; i++)
{
    int adad2 = Convert.ToInt32(Console.ReadLine());
    mylist.Add(adad2);
}

MySort mySort = new MySort();
mySort.bubllesort(mylist, n);
foreach (var temp in mylist)
{
    Console.WriteLine($"number:{temp}");
}