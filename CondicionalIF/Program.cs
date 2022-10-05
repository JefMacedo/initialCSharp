// Condicional IF

const string aprovado = "Aprovado!";
const string reprovado = "Reprovado!";
const string emRecuperacao = "Em Recuperação!";

Console.WriteLine("Digite a nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 5)
{
    Console.WriteLine(aprovado);
}
else if (nota >= 4 && nota < 5)
{
    Console.WriteLine(emRecuperacao);
}
else
{
    Console.WriteLine(reprovado);
}