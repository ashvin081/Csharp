using System;
class HotelMenu
{
    static void Main()
    {
        int choice;
        char continueOrder;

        int qty1 = 0, qty2 = 0, qty3 = 0;
        int price1 = 50, price2 = 40, price3 = 20;

        do
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("            HOTEL MENU           ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Sev-Tameta - 50");
            Console.WriteLine("2. Thepla     - 40");
            Console.WriteLine("3. Chhas      - 20");
            Console.WriteLine("---------------------------------");

            Console.Write("Enter Your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYou choose Sev-Tameta");
                    qty1 += AddQuantity("Sev-Tameta", price1);
                    break;

                case 2:
                    Console.WriteLine("\nYou choose Thepla");
                    qty2 += AddQuantity("Thepla", price2);
                    break;

                case 3:
                    Console.WriteLine("\nYou choose Chhas");
                    qty3 += AddQuantity("Chhas", price3);
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.Write("\nDo you want to continue press(y/n): ");
            continueOrder = Convert.ToChar(Console.ReadLine());

        } while (continueOrder == 'y' || continueOrder == 'Y');

        // ===== FINAL BILL =====
        int total1 = qty1 * price1;
        int total2 = qty2 * price2;
        int total3 = qty3 * price3;

        int grandTotal = total1 + total2 + total3;

        Console.WriteLine("----------------------------------");
        Console.WriteLine("              FINAL BILL          ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Item\tQty\tPrice\tAmount");
        Console.WriteLine("----------------------------------");

        if (qty1 > 0)
            Console.WriteLine("Sev-Tameta\t" + qty1 + "\t" + price1 + "\t" + total1);

        if (qty2 > 0)
            Console.WriteLine("Thepla\t\t" + qty2 + "\t" + price2 + "\t" + total2);

        if (qty3 > 0)
            Console.WriteLine("Chhas\t\t" + qty3 + "\t" + price3 + "\t" + total3);

        Console.WriteLine("----------------------------------");
        Console.WriteLine("Grand Total : " + grandTotal);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("\nYour total paybill is " + grandTotal);

        Console.ReadLine();
    }

    static int AddQuantity(string itemName, int price)
    {
        int totalQty = 0;
        char addMore;

        do
        {
            Console.Write("Quantity : ");
            int q = Convert.ToInt32(Console.ReadLine());

            totalQty += q;

            Console.WriteLine("Price : " + price);

            Console.Write("Do you want to add more " + itemName + " quantity? (y/n) : ");
            addMore = Convert.ToChar(Console.ReadLine());

        } while (addMore == 'y' || addMore == 'Y');

        int total = totalQty * price;
        Console.WriteLine("Total : " + total);

        return totalQty;
    }
}
