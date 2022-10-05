// Manipulando strings
string frase = " O dia está lindo!!";

Console.WriteLine(frase.Substring(0, 5));

Console.WriteLine(frase.Replace("lindo", "chuvoso"));

frase.Trim();
frase.TrimEnd();
frase.TrimStart();
Console.WriteLine(frase.Trim('!'));

string cpf = "345678900";
Console.WriteLine(cpf.PadLeft(11, '0'));

string frase2 = frase + "Ensolarado!";

Console.WriteLine(frase2);

string frase3 = $"{frase} Ensolarado!";

Console.WriteLine(frase3);