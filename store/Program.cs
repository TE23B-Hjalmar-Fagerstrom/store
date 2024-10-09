int money = 100;

int coke = 15;
int milk = 10;
int candy = 20;
int readyFood = 45;
int amount = 0;
int itemSelected = 0;
int boughtCoke = 0;
int boughtMilk = 0;
int boughtCandy = 0;
int boughtReadyFood = 0;

Console.WriteLine("Du ska till afären och handla lite När du är i afären hittar du bara fyra saker du vill köppa");

while (itemSelected != 5 && money != 0)
{
    Console.WriteLine($"Du har {money} kr och du kan välja mellan");

    Console.WriteLine("1: cola(15kr)  2: mjölk(10kr)  3: en påsse godis(20kr) 4: färdig mat(45kr) 5: lämna afären");
    Console.WriteLine("skriv 1,2,3,4 eller 5 för att välja");

    string item = Console.ReadLine();


    int.TryParse(item, out itemSelected);

    if (itemSelected == 1 && money >= coke)
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
        money -= amount * coke;
        boughtCoke += amount;
    }

    if (itemSelected == 2 && money >= milk)
    {
        Console.WriteLine("hur många vill du köppa");
        string howMany = Console.ReadLine();
        int.TryParse(howMany, out amount);
        while (amount * milk > money)
        {
            Console.WriteLine("Du har inte råd välj en annan mängd");
            string howManyRetry = Console.ReadLine();
            int.TryParse(howManyRetry, out amount);
        }
        money -= amount * milk;
        boughtMilk += amount;
    }

    if (itemSelected == 3 && money >= candy)
    {
        Console.WriteLine("hur många vill du köppa");
        string howMany = Console.ReadLine();
        int.TryParse(howMany, out amount);
        while (amount * candy > money)
        {
            Console.WriteLine("Du har inte råd välj en annan mängd");
            string howManyRetry = Console.ReadLine();
            int.TryParse(howManyRetry, out amount);
        }
        money -= amount * candy;
        boughtCandy += amount;
    }

    if (itemSelected == 4 && money >= readyFood)
    {
        Console.WriteLine("hur många vill du köppa");
        string howMany = Console.ReadLine();
        int.TryParse(howMany, out amount);
        while (amount * readyFood > money)
        {
            Console.WriteLine("Du har inte råd välj en annan mängd");
            string howManyRetry = Console.ReadLine();
            int.TryParse(howManyRetry, out amount);
        }
        money -= amount * readyFood;
        boughtReadyFood += amount;

    }


}
Console.WriteLine("Du går hem efter dina val och funderar om du värkligen hade gjort rätt val");
Console.WriteLine($"Du köpte {boughtCoke} color, {boughtMilk} mjölk kartonger, {boughtCandy} påsar godis, {boughtReadyFood} färdig mat och hade {money}kr kvar");
Console.WriteLine("Tryck ENTER för att stänga spelet");



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