// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Olá a todos");
/*
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


// Manipulando strings
string frase = " O dia está lindo!!";

Console.WriteLine(frase.Substring(0, 5));

Console.WriteLine(frase.Replace("lindo", "chuvoso"));

frase.Trim();
frase.TrimEnd();
frase.TrimStart();
Console.WriteLine(frase.Trim('!'));

string cpf = "345678900";
Console.WriteLine(cpf.PadLeft(11,'0'));

string frase2 = frase + "Ensolarado!";

Console.WriteLine(frase2);

string frase3 = $"{frase} Ensolarado!";

Console.WriteLine(frase3); */

/*
 //// Condicional IF

const string aprovado = "Aprovado!";
const string reprovado = "Reprovado!";
const string emRecuperacao = "Em Recuperação!";

Console.WriteLine("Digite a nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 5)
{
    Console.WriteLine(aprovado);
} else if (nota >= 4 && nota < 5) 
{
    Console.WriteLine(emRecuperacao);
} else
{
    Console.WriteLine(reprovado);
}*/

// Condicional Switch
const string DIAS_31 = "Este mês tem 31 dias!";
const string DIAS_30 = "Este mês tem 30 dias!";
const string DIAS_28 = "Este mês tem 28 dias!";
const string MES_INVALIDO = "Este mês não existe!";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();

switch (mes.ToUpper())
{
    case "JANEIRO":
    case "MARÇO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
        Console.WriteLine(DIAS_31);
        break;

    case "ABRIL":
    case "JUNHO":
    case "SETEMBRO":
    case "NOVEMBRO":
        Console.WriteLine(DIAS_30);
        break;

    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;

    default:
        Console.WriteLine(MES_INVALIDO);
        break;
}