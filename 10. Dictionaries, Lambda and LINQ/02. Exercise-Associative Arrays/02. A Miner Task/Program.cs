Dictionary<string, int> materials = new Dictionary<string, int>();

while (true)
{
    string materialName=Console.ReadLine();
    
    if (materialName=="stop")
    {
        break;
    }
    int quantity = int.Parse(Console.ReadLine());
    if (!materials.ContainsKey(materialName))
    {
        materials.Add(materialName, 0);
    }
    materials[materialName] += quantity;
}
foreach (var material in materials)
{
    Console.WriteLine($"{material.Key} -> {material.Value}");
}