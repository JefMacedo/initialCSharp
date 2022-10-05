List<int> numeros = new List<int>() { 1, 0, 5, 6, 2, 3, 4, 9, 8, 7 };
numeros.Sort();

foreach(int i in numeros)
    Console.WriteLine(i);

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();

/*
 QUEUE segue o padrão FIFO - First In, First Out
 */

Queue<string> lista = new Queue<string>();
lista.Enqueue("Olá");
lista.Enqueue("pessoal");
lista.Enqueue("do curso");

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();

string elem = lista.Dequeue();
Console.WriteLine(elem);

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();

int total = lista.Count;
Console.WriteLine(total);

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();

Console.WriteLine(lista.Peek());

Console.WriteLine();
Console.WriteLine("--------------/--------------");
Console.WriteLine();