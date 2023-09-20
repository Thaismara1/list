// See https://aka.ms/new-console-template for more information
using list.models;

Console.WriteLine("Hello, World!");

const int price_apple = 10;
const int price_orange = 15;

product p1 = new product("apple", price_apple);
product p2 = new product("orange", price_orange);

List<product> products = new List<product>();

products.Add(p1);
products.Add(p2);

foreach (product currentProduct in products)
{
    Console.WriteLine(currentProduct.ToString());

}
