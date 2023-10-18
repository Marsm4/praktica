using Newtonsoft.Json;
int b = 0;

tovar Tovar = new tovar(true, 50, 10, 15, "vase"); 
tovar Tovar2 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar3 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar4 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar5 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar6 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar7 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar8 = new tovar(true, 50, 10, 15, "vase"); 
tovar Tovar9 = new tovar(true, 50, 10, 15, "vase");
tovar Tovar10 = new tovar(true, 50, 10, 15, "vase");

List<string> jsonList = new List<string>();


    
List<tovar> Tovari = new List<tovar>();
Tovari.Add(Tovar);
Tovari.Add(Tovar2);
Tovari.Add(Tovar3);
Tovari.Add(Tovar4);
Tovari.Add(Tovar5);
Tovari.Add(Tovar6);
Tovari.Add(Tovar7);
Tovari.Add(Tovar8);
Tovari.Add(Tovar9);
Tovari.Add(Tovar10);

foreach (tovar c in Tovari)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}

Console.WriteLine();

b = Convert.ToInt32(Console.ReadLine());
switch(b)
{
    case 1:
        foreach (tovar c in Tovari)
        {
            string json = JsonConvert.SerializeObject(c); 
            Console.WriteLine(json);
        }
        break;
}

class tovar
{
    public bool fragility;
    public int price;
    public int weight;
    public int scope;
    public string name;


    public tovar(bool fragility, int price, int weight, int scope, string name)
    {
        this.fragility = fragility;
        this.price = price;
        this.weight = weight;
        this.scope = scope;
        this.name = name;
        Console.WriteLine("tovar created!");
    }
  
}
