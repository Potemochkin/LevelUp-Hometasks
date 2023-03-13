using Lesson3.Hierarchy.Item;

Console.WriteLine("Let's play with C#\nThis is hometask 3");

DateTime expirationData = new(2023, 3, 14);

var protein = new Protein("Протеиновый батончик C# Extra+", "Специализированное спортивное питание",101,435423,99);
var jacket = new Jacket("Куртка C# Extra+", "Специализированная спортивная экипировка", 201, 435555, 3599, 46, "Весна");
var skis = new Skis("Лыжи C# Extra+", "Специализированное спортивное оборудование", 301, 435699, 7999);

protein.PrintInfo();
protein.ExpirationDate(expirationData);

Console.Write("\n");

jacket.PrintInfo();

Console.Write("\n");

skis.PrintInfo();