// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Olá a todos");

// operadores aritmétricos
int adicao = 5 + 3;
int subtracao = 5 - 2;
int multiplicacao = 5 * 3;
int divisao = 15 / 3;

int expr = (1 + 2) * 5 - 2 / 2;

Console.WriteLine(expr);

//Operadores relacional
string cidade1 = "Blumenal";
string cidade2 = "Teresopolis";

int i = 2;
int j = 5;

bool ret1 = cidade1 == cidade2;
bool ret2 = cidade1 != cidade2;

bool ret3 = i == j;
bool ret4 = i != j;
bool ret5 = i < j;
bool ret6 = i > j;
bool ret7 = i <= j;
bool ret8 = i >= j;

Console.WriteLine(ret1);
Console.WriteLine(ret2);
Console.WriteLine(ret3);
Console.WriteLine(ret4);
Console.WriteLine(ret5);
Console.WriteLine(ret6);
Console.WriteLine(ret7);
Console.WriteLine(ret8);

//Operador Lógico
bool ret9 = i == j && cidade1 == cidade2;
ret9 = i < j && cidade1 != cidade2;

bool ret10 = i < j || cidade1 == cidade2;
bool ret11 = !(i < j);

Console.WriteLine(ret9);
Console.WriteLine(ret10);
Console.WriteLine(ret11);