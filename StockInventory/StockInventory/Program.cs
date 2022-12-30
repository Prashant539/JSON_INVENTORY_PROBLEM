using StockInventory.StockManagement;
using System;
namespace StockInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory Stock Management");
            string stockFilePath = @"E:\JSON\JSON_INVENTORY_PROBLEM\StockInventory\StockInventory\StockManagement\Stock.json";
            string customerFilePath = @"E:\JSON\JSON_INVENTORY_PROBLEM\StockInventory\StockInventory\StockManagement\Customer.json";
            StockAccountManagement management = new StockAccountManagement();
            management.ReadStockJsonFile(stockFilePath);
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Flipkart");
            management.WritetoStockJsonFile(stockFilePath);
            management.WritetoCustomerJsonFile(customerFilePath);
            management.SellStock("Amazon");
            management.WritetoStockJsonFile(stockFilePath);
            management.WritetoStockJsonFile(customerFilePath);
        }

    }
}
    