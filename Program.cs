// See https://aka.ms/new-console-template for more information
List<Plant> plants = new List<Plant>() 
{
    new Plant()
    {
        Species = "Monstera",
        LightNeeds = 1,
        AskingPrice = 2.00,
        City = "Nashville",
        Zip = 37211,
        Sold = false
    },
    new Plant()
    {
        Species = "Fiddle Leaf Fig",
        LightNeeds = 3,
        AskingPrice = 15.00,
        City = "Houston",
        Zip = 77001,
        Sold = false
    },
    new Plant()
    {
        Species = "Snake Plant",
        LightNeeds = 2,
        AskingPrice = 10.00,
        City = "Pittsburgh",
        Zip = 15217,
        Sold = true
    },
    new Plant()
    {
        Species = "Spider Plant",
        LightNeeds = 1,
        AskingPrice = 5.00,
        City = "Chicago",
        Zip = 60614,
        Sold = false
    },
    new Plant()
    {
        Species = "Peace Lily",
        LightNeeds = 2,
        AskingPrice = 8.00,
        City = "Seattle",
        Zip = 98101,
        Sold = true
    }
};

Console.WriteLine("Hello! Welcome to ExtraVert, a CLI-Based Plant Shop.");

for (int i = 0; i < plants.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plants[i].Species}");
}