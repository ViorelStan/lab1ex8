/*
 * Se citesc trei numere de la tastatura, x, y, z.
 * Scrieti un program care va afisa cele 3 valori in ordine descrescatoare
*/

Console.WriteLine("Introduceti valoare pentru x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru y:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru z:");
int z = int.Parse(Console.ReadLine());

var arr = new[] { x, y, z };
Array.Sort(arr);
Array.Reverse(arr);
Console.WriteLine("{0}, {1}, {2}",arr[0], arr[1], arr[2]);