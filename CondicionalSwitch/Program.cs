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