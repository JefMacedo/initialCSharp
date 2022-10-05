SortedList<int, string> lista = new SortedList<int, string>();

lista.Add(4,"RJ");
lista.Add(2,"SP");
lista.Add(3,"SC");
lista.Add(1,"MG");

foreach (string estado in lista.Values)
    Console.WriteLine(estado);
