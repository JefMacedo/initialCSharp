//Operadores Lógicos

string cidade1 = "Blumenal";
string cidade2 = "Teresopolis";

int i = 2;
int j = 5;

bool ret9 = i == j && cidade1 == cidade2;
ret9 = i < j && cidade1 != cidade2;

bool ret10 = i < j || cidade1 == cidade2;
bool ret11 = !(i < j);

Console.WriteLine(ret9);
Console.WriteLine(ret10);
Console.WriteLine(ret11);