string metin;
System.Console.WriteLine("Metininizi Giriniz"); 
metin=Console.ReadLine()!;
foreach (var item in metin.Reverse())
{
    Console.WriteLine(item);
}