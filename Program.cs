// ......................................................
// Task: Cook fried chicken (eggs, meat, flour) and feed Cat
// Flour: vegetables & vegetables
// Walking to get ingredients
// for (int i = 0; i < 11; i++)
// {
//     Console.Clear();
//     var lines = Maps.Home(i);

//     Console.WriteLine("________________________________________________________");
//     foreach (var line in lines)
//     {
//         Console.Write("|");
//         Console.Write(string.Join("", line));
//         Console.Write("|");
//         Console.WriteLine();
//     }
//     Console.WriteLine("________________________________________________________");

//     Console.ReadKey(true);
// }


for (int i = 0; i < 13; i++)
{
    Console.Clear();
    var lines = Maps.RanchForward(i);

    Console.WriteLine("________________________________________________________");
    foreach (var line in lines)
    {
        Console.Write("|");
        Console.Write(string.Join("", line));
        Console.Write("|");
        Console.WriteLine();
    }
    Console.WriteLine("________________________________________________________");

    Console.ReadKey(true);
}

for (int i = 1; i < 13; i++)
{
    Console.Clear();
    var lines = Maps.RanchBackward(i);

    Console.WriteLine("________________________________________________________");
    foreach (var line in lines)
    {
        Console.Write("|");
        Console.Write(string.Join("", line));
        Console.Write("|");
        Console.WriteLine();
    }
    Console.WriteLine("________________________________________________________");

    Console.ReadKey(true);
}

for (int i = 0; i < 16; i++)
{
    Console.Clear();
    var lines = Maps.HomeBackward(i);

    Console.WriteLine("________________________________________________________");
    for (int j = 0; j < lines.Count; j++)
    {
        string[] line = lines[j];
        // last step; i = 15: Print "Press F to Cook" on like row 8
        Console.Write("|");
        Console.Write(string.Join("", line));
        Console.Write("|");
        if (i == 15 && j == 8)
        {
            Console.Write("     Press F to Cook");
        }
        Console.WriteLine();
    }
    Console.WriteLine("________________________________________________________");

    Console.ReadKey(true);
}

// Cooking Screen
Console.Clear();
Console.WriteLine("Cat's Request: Fried Chicken (egg, meat, flour)");
Console.WriteLine("Inventory: Egg (1), Meat (1), Vegetable (2)");
Console.WriteLine("What you'd like to make?");
Console.WriteLine("1. Steak");
Console.WriteLine("2. Salt");
Console.WriteLine("3. Flour");
Console.WriteLine("4. Sugar");
Console.WriteLine("5. Fried Chicken");

// You click 3
Console.ReadLine();

Console.WriteLine("\nFlour: vegetable + vegetable. Proceed? (Y/N)");
// You enter Y
Console.ReadLine();

Console.WriteLine("+ Flour (1)");
Console.WriteLine("- Vegetable (2)");
Console.ReadKey();

// Cooking screen again. This time make the dish!
Console.Clear();
Console.WriteLine("Cat's Request: Fried Chicken (egg, meat, flour)");
Console.WriteLine("Inventory: Egg (1), Meat (1), Flour (1)");
Console.WriteLine("What you'd like to make?");
Console.WriteLine("1. Steak");
Console.WriteLine("2. Salt");
Console.WriteLine("3. Flour");
Console.WriteLine("4. Sugar");
Console.WriteLine("5. Fried Chicken");

// You click 5
Console.ReadLine();

Console.WriteLine("Fried Chicken: egg + meat + flour. Proceed? (Y/N)");
// You enter Y
Console.ReadLine();

Console.WriteLine("\n+ Fried Chicken (1)");
Console.WriteLine("- Meat (1)");
Console.WriteLine("- Flour (1)");
Console.ReadKey();

// Go back home. Press "E" to feed
Console.Clear();
var lines1 = Maps.HomeBackward(15);

Console.WriteLine("________________________________________________________");
for (int j = 0; j < lines1.Count; j++)
{
    string[] line = lines1[j];
    // last step; i = 15: Print "Press F to Cook" on like row 8
    Console.Write("|");
    Console.Write(string.Join("", line));
    Console.Write("|");
    if (j == 8)
    {
        Console.Write("     Press E to Feed");
    }
    Console.WriteLine();
}
Console.WriteLine("________________________________________________________");

Console.ReadKey(true);

Console.Clear();
Console.WriteLine("Cat liked your Fried Chicken!");
Console.WriteLine("You made Cat happy (for today)");