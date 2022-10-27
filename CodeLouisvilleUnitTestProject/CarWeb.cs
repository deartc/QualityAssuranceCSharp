using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityAssuranceCSharp.CodeLouisvilleUnitTestProject
{
    internal class CarWeb
    {
        using Car;
using System.Text.Json;


string baseUrl = "https://vpic.nhtsa.dot.gov/api/ ";


    HttpClient client = new HttpClient
    {
        BaseAddress = new Uri(baseUrl)
    };


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



Console.WriteLine($"Word: {definitionInfoList.FirstOrDefault().Word}");


foreach (var definitionInfo in definitionInfoList)
{
    foreach (var meaning in definitionInfo.Meanings)
    {
        var partOfSpeech = meaning.PartOfSpeech;
        foreach (var definition in meaning.Definitions)
        {
            Console.WriteLine($"{partOfSpeech} : {definition.Definition}");
        }
    }
}


Console.WriteLine("Enter a word to receive the definition");
Console.WriteLine("Enter 'q' to quit");
userInput = Console.ReadLine();
}

    }
}
