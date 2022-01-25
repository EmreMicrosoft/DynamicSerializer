using DynamicSerializer;


// FUNDAMENTALS:
dynamic dynamicObject = new Dynamic();

dynamicObject.FirstName = "John";
Console.WriteLine(dynamicObject.FirstName);

dynamicObject.AddProperty("LastName", "Doe");
Console.WriteLine(dynamicObject.LastName);

dynamicObject["Age"] = 41;
Console.WriteLine(dynamicObject["Age"]);

Console.WriteLine();


// INTERMEDIATE:
var jsonString = CsvParser.GetJsonString();
Console.WriteLine(jsonString);