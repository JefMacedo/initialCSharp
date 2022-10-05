/*
 Stack segue o conceito de LIFO - Last In, First Out
 */

Stack<string> lista = new Stack<string> ();

lista.Push("Olá");
lista.Push("Pessoal");
lista.Push("Do curso");

foreach(string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine("--------------/--------------");

Console.WriteLine(lista.Pop());

Console.WriteLine("--------------/--------------");

foreach (string palavra in lista)
    Console.WriteLine(palavra);

Console.WriteLine("--------------/--------------");

Console.WriteLine(lista.Peek());

