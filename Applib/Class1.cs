namespace Applib;
public class Class1
{
    public static bool trueItemsNum;
    public static bool falseItemsNum;
    public static int numOfItems;
    public static int result;
    public static int i;
    public static int totalAmount = 0;
        public static int Items = 0;

    public static void CalculateTotal(int[]prices)
    {
        int totalAmount = 0;
        foreach (int price in prices)
        {
            totalAmount += price;   
        }
        System.Console.WriteLine("Total amount of the items is {0} ", totalAmount);
    }
}

