using Applib;

Class1.falseItemsNum = Class1.result < 0 && !Class1.trueItemsNum;
do
{
    System.Console.WriteLine("Enter number of items bought");
    string ItemsNum = Console.ReadLine();
    Class1.trueItemsNum = int.TryParse(ItemsNum, out Class1.result);
    if (Class1.trueItemsNum && Class1.result > 0) 
{
    Class1.numOfItems = Class1.result;
    if (Class1.trueItemsNum)
    {
        break;
    }
}else
{
    System.Console.WriteLine("Number of items must above 0 and must be a number.");
}
}while (!Class1.falseItemsNum);

int[] AmountForEveryItem = new int[Class1.result + 1];
System.Console.WriteLine("Enter amount for every item");
for (Class1.i  = 0; Class1.i < Class1.numOfItems; Class1.i++)
{
    Class1.Items += 1;
    System.Console.WriteLine("Price for Item {0}: ", Class1.Items);
    AmountForEveryItem[Class1.i] = int.Parse(Console.ReadLine());
    Class1.totalAmount += AmountForEveryItem[Class1.i];
}
System.Console.WriteLine("\n Total = " + Class1.totalAmount);
/*for (int i = 0; i < Class1.numOfItems; i++)
{
   System.Console.WriteLine(AmountForEveryItem[i]); 
}*/

Friends.SayHello();