int money = 100;

int coke = 15;
int milk = 10;
int candy = 20;
int readyFood = 45;
int amount = 0;

Console.WriteLine("Du ska till afären och handla lite När du är i afären hittar du bara fyra saker du vill köppa");

Console.WriteLine($"Du har {money} kr och du kan välja mellan");

Console.WriteLine("1: cola(15kr)  2: mjölk(10kr)  3: en påsse godis(20kr) 4: färdig mat(45kr)");
Console.WriteLine("skriv 1,2,3,4 för att välja");

string item = Console.ReadLine();
int itemSelected = 0;

int.TryParse(item, out itemSelected);

if (itemSelected == 1 && money > coke)
{
    Console.WriteLine("hur många vill du köppa");
    string howMany = Console.ReadLine();
    int.TryParse(howMany, out amount);
    while (amount * coke > money)
    {
        Console.WriteLine("Du har inte råd välj en annan mängd");
        string howManyRetry = Console.ReadLine();
        int.TryParse(howManyRetry, out amount);
    }
    
}





//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine("hej");
//    i++;
//}

//for (int j=0; j < 10; j++)
//{
////    Console.WriteLine("hej");
//}




//bool success = false;
//int ageNum = 0;

//while (success != true)
//{


//Console.WriteLine("Ålder:");
//string age = Console.ReadLine();


//success = int.TryParse(age, out ageNum);

//if (success == false)
//{
//    Console.WriteLine("Skriv en siffra, dumhuvve");
//}
//}

//if ( ageNum >= 18)
//{
//    Console.WriteLine("Välkommen!");
//}


Console.ReadLine();