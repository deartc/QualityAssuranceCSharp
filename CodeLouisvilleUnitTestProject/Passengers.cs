using CodeLouisvilleUnitTestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeLouisvilleUnitTestProject
{
    internal class Passengers
    {///passenger console

//passenger 
	

	using Car;
	using System.Text.Json;
	

	Console.WriteLine("This is passenger menu. Please choose from the following menu options:");
Console.WriteLine("1: Add an passenger");
Console.WriteLine("2: View all current passengers");
Console.WriteLine("3: Remove an passenger by name");
Console.WriteLine("4: Exit");


List<Passenger> passengers = new List<Passenger>();


    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };


    var fileText = File.ReadAllText("passengers.json");
    var deserialized = JsonSerializer.Deserialize<List<Passenger>>(fileText, options);
    passengers.AddRange(deserialized);


string userInput = Console.ReadLine();


while (userInput != "4")
{
    if (userInput == "1")
    {
        passengers = Menu.AddPassenger(passengers);
    }
    else if (userInput == "2")
{
    Menu.DisplayPassengers(passengers);
}
else if (userInput == "3")
{
    Console.WriteLine("Enter the name of the passenger to remove");
    var name = Console.ReadLine();
    Menu.RemovePassenger(passengers, name);
}
else if (userInput == "4") //Exit
{


}
Console.WriteLine("What next?");
userInput = Console.ReadLine();
}


var json = JsonSerializer.Serialize(passengers);
File.WriteAllText("passengers.json", json);


Console.WriteLine("Please add or remove  passengers by  the following menu options:");
Console.WriteLine("1: Add a passenger");
Console.WriteLine("2: View all current passengers");
Console.WriteLine("3: Remove a passenger by name");
Console.WriteLine("Enter the name of the passenger to remove");


Console.WriteLine("4: Exit");


    }
}
