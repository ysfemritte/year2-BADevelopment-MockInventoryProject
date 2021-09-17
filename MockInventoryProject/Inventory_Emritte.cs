using System;

namespace MockInventoryProject
{
    class Inventory_Emritte
    {
        static void Main(string[] args)
        {
            try
            {
                //1. Create 2 different ogjects of class inventory
                //ClassName objName = new Constructor(parameter list)
                MockInventory objInv1 = new MockInventory("001", "Pencils", 50, 200.0, 10.0);
                MockInventory objInv2 = new MockInventory("002", "Copybook", 40, 100.0, 5.0);



                //2. For each object
                //2a. Display all values
                Console.WriteLine($"Item Number: {objInv1.ItemNumber}, Description: {objInv1.Description}, Stock: {objInv1.Stock}, Price: {objInv1.Price}, GST = {objInv1.GST}");

                //Item Number: 002, Description: Copybook, Stock: 40, Price: 100.0, GST: 5.0 
                Console.WriteLine($"Item Number: {objInv2.ItemNumber}, Description: {objInv2.Description}, Stock: {objInv2.Stock}, Price: {objInv2.Price}, GST = {objInv2.GST}");
                Console.WriteLine("");


                //2b. Call the method for the Total value of stock and display the value 
                Console.WriteLine("Total Value of Stock of Item 1 is: " + objInv1.Total().ToString());
                Console.WriteLine("Total Value of Stock of Item 2 is: " + objInv2.Total().ToString());
                Console.WriteLine("");


                //2c. Call the method for the Retail value of an item and display the value
                Console.WriteLine("Retail Value of Item 1 is: " + objInv1.Retail().ToString());
                Console.WriteLine("Retail Value of Item 2 is: " + objInv2.Retail().ToString());
                Console.WriteLine("");



                //3. For the first object
                //3a. Decrease the quantity of stock by 1
                objInv1.Stock = objInv1.Stock - 1;

                //3b. Call the method for the value of stock and display the value.
                Console.WriteLine("New Total Value of Stock of Item 1 is: " + objInv1.Total().ToString());
                Console.WriteLine("");



                //4. For the 2nd object:
                //4a. Change the item description
                objInv2.Description = "Exercise Book";

                //4b. Change the price per item
                objInv2.Price = 120.0;

                //4c. Display the following:
                //4ci. New item description name
                //4cii. New Price per item
                Console.WriteLine($"Item {objInv2.Description}, New Price: {objInv2.Price}");

                //4ciii. the retail value per item
                Console.WriteLine("New Retail Value per Item 2 is: " + objInv2.Retail().ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }// End Main
    }
}
