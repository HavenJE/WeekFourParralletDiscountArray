

// Creating parallel array with ranage match for discount 

class discountParrallelArray
{
    static void Main()
    {
        int[] numOfItemsOrdered = { 1, 10, 20, 30, 40, 50 };
        double[] discount = { 0, 0.10, 0.20, 0.30, 0.40, 0.50};

        int userItemsOrder = 0;
        bool isValid = false;
        double userDiscount = 0;

        Console.WriteLine("Place your number of items order below: ");
        userItemsOrder = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numOfItemsOrdered.Length; i++)
            if (userItemsOrder == numOfItemsOrdered[i])
        {
            isValid = true;
            userDiscount = discount[i];
        }
        if (isValid)
        {
            Console.WriteLine("For that {0} of order you made, you have {1} price discount.", userItemsOrder, userDiscount);
        }
        else
        {
            Console.WriteLine("for that {0}, there is no discount.");
        }
    }
}

