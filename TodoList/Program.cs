using TodoList;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var random = new Random();

var tommy = new Hond();
tommy.Naam = "Tommy";
tommy.GewichtInKilo = 40;

var zipper = new Hond();
zipper.Naam = "Sipper";
zipper.GewichtInKilo = 15;

var mijnHonden = new List<Hond>();
mijnHonden.Add(tommy);
mijnHonden.Add(zipper);

mijnHonden.Add(new Hond{ Naam = "Ficky", GewichtInKilo = 4});
for (var i = 0; i < random.Next(4, 10); i++)
{
    mijnHonden.Add(new Hond{ Naam = "Mijn hond " + i, GewichtInKilo = 4 + i});
}

string result = "Mijn honden zijn: " + "\n";
for (var i = 0; i < mijnHonden.Count; i++)
{
    result = result + mijnHonden[i].Naam + "\n";
}
    
app.MapGet(pattern: "/", handler: () => result); 
//app.MapGet(pattern: "/", handler: () => "mijn honden zijn: " + "\n" + tommy.Naam + "\n" + zipper.Naam + "\n" + mijnHonden.Last().Naam); 

// app.MapGet("/", () => "Hello World!");

app.Run();