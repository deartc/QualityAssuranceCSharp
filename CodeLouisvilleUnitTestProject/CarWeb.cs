using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace QualityAssuranceCSharp.CodeLouisvilleUnitTestProject
{
    class CarWeb
    {
      
string baseUrl = "https://vpic.nhtsa.dot.gov/api/ ";


    HttpClient client = new HttpClient
    {
        BaseAddress = new Uri(baseUrl)
    };


    GetRequest("https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/480?format=json");

    Console.WriteLine("Make and Model of Car");
Console.WriteLine("Enter 'q' to quit");
var userInput = Console.ReadLine();




while(userInput != "q")
{
    var response = await client.GetAsync(userInput);
    var content = await response.Content.ReadAsStringAsync();
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };


    List<CarItem> CarInfoList;
    try
    {
        CarInfoList = JsonSerializer.Deserialize<List<CarItem>>(content, options);
    }
    catch (JsonException)
{
    Console.WriteLine("Make Model don't match sorry");
    Console.WriteLine("Enter a car to receive the information");
    Console.WriteLine("Enter 'q' to quit");
    userInput = Console.ReadLine();
    continue;
}



Console.WriteLine($"Car: {definitionInfoList.FirstOrDefault().Car}");


foreach (var makeInfo in makeInfoList)
{
    foreach (var model in modelInfo.Model)
    {
        var AssemblyYear = model.AssemblyYear;
        foreach (var model in model.AssemblyYear)
        {
            Console.WriteLine($"{model} : {assemblyYear.AssemblyYear}");
        }
    }
}


Console.WriteLine("Enter a word to receive the definition");
Console.WriteLine("Enter 'q' to quit");
userInput = Console.ReadLine();
}

    }
}
