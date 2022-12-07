using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TodoList;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
Random random = new Random();

/*var tommy = new Hond();
tommy.Naam = "Tommy";
tommy.GewichtInKilo = 40;

var zipper = new Hond();
zipper.Naam = "Zipper";
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
*/

var yetToDo = new ToDoCategory();

var currentlyDoing = new ToDoCategory();

var doneDoing = new ToDoCategory();

var ToDoCategory = new List<ToDoCategory>();
ToDoCategory.Add(yetToDo);
ToDoCategory.Add(currentlyDoing);
ToDoCategory.Add(doneDoing);


app.MapGet(pattern: "/", handler: (HttpContext ctx) =>
{
    ctx.Response.Headers.ContentType = "text/html";
    return "<input/>" + yetToDo + "<input type=\"submit\" value\"Send\" />";  
});


    
//app.MapGet(pattern: "/", handler: () => result); 
//app.MapGet(pattern: "/", handler: () => "mijn honden zijn: " + "\n" + tommy.Naam + "\n" + zipper.Naam + "\n" + mijnHonden.Last().Naam); 

// app.MapGet("/", () => "Hello World!");

app.Run();