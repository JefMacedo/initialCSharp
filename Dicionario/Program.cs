Dictionary<int, string> estados = new Dictionary<int, string>();

estados.Add(1, "RJ");
estados.Add(2, "SP");
estados.Add(3, "SC");
estados.Add(4, "PR");
estados.Add(5, "RS");

if (!estados.ContainsKey(6))
    estados.Add(6, "MG");

foreach(string estado in estados.Values)
    Console.WriteLine(estado);

//string est = estados[3];

string est = null;

if (estados.TryGetValue(3, out est))
    Console.WriteLine(est);

