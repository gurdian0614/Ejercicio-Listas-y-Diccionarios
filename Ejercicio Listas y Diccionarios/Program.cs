

List<String> personasList = new List<string>();
List<String> personas2List = new List<string>()
{
    "Persona 1", "Persona 2", "Persona 3"
};
personasList.Add("Roger");
personasList.Add("David");
personasList.Add("Roger");
personasList.Add("Darwin");
personasList.Add("Roger");
personasList.Insert(personasList.Count, "Daniel");
personasList.Add("Roger");
personasList.Insert(personasList.Count, "Moises");
//personasList.Remove("Roger");
//personasList.RemoveAt(0);
//personasList.RemoveAt(personasList.Count - 1);
//personasList.RemoveAll(persona => persona == "Roger");
//personasList.Sort();
//Console.WriteLine(personasList.Find(persona => persona == "Roger"));

foreach (var persona in personasList)
{
    Console.WriteLine(persona);    
}

/*List<String> p = personasList.FindAll(persona => persona == "Roger");
foreach (string s in p)
{
    Console.WriteLine(s);
}*/

Dictionary<string, string> data = new Dictionary<string, string>()
{
    { "Pais", "Honduras" },
    { "Departamento", "Francisco Morazan" }
};
data.Add("Municipio", "Tegucigalpa");
//data.Remove("Pais");
//data["Pais"] = "Nicaragua";
foreach (var dato in data)
{
    Console.WriteLine($"Key: {dato.Key}, Value: {dato.Value}");
}