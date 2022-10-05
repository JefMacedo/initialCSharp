int[] numeros = new int[] { 1, 2, 3, 4, 5 };

int num = numeros[0]; // recebe o valor da primeira posição do array
Console.WriteLine(num);

int total = numeros.Length; // recebe o tamanho do array

List<int> listNumeros = new List<int>();
List<int> listNums = new List<int>() { 1, 2, 3, 4, 5 };

int count = listNums.Count;
Console.WriteLine(count);

listNums.Add(6);
listNums.Remove(3);

int numer = listNums.ElementAt(0); //retorna o valor da posição na lista
Console.WriteLine(numer);

//listNums.Clear(); //remove todos os itens da lista

foreach (int numero in listNums)
    Console.WriteLine(numero);