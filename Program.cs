// Brie Prater
// 02/08/2020
// CIS 243
// Assignment 9.1
// Create an console app that will change the prices of items based on user input

using System;

public class Prices
{
	public static void Main(string[] args) // main method for program
	{
		double pricePoint; // variable to hold user input for price cut off
		double percentage; // variable to hold user input for price percentage
		string[] item_name = { "Widget", "Thingy", "Ratchet", "Clanger", "Fracker" }; // array to hold product names
		double[] item_price = { 15.50, 50.99, 25.00, 115.49, 75.25 }; // array to hold product prices
		for (int y = 0; y < 5; y++) // for loop to display initial prices of items
		{
			printit(item_name[y], item_price[y]);
		}
		Console.WriteLine("Please enter the price cutoff point: "); // asks for user input for cut off price
		pricePoint = Convert.ToDouble(Console.ReadLine()); // sets user input to pricePoint variable
		Console.WriteLine("Please enter the price change percentage in decimal form (ex 0.15): "); // asks for user input for percent to increase
		percentage = Convert.ToDouble(Console.ReadLine()); // sets user input to percentage variable
		changePrices(ref item_name, ref item_price, pricePoint, percentage); // calls changePrices method
	}
	static void changePrices(ref string[] item_name, ref double[] item_price, double pricePoint, double percentage) // passes arrays by reference
	{
		for (int x = 0; x < 5; x++) // for loop to compare all prices in item_price
		{
			if (item_price[x] < pricePoint) // if statement to compare prices
			{
				item_price[x] = (item_price[x] * percentage) + item_price[x]; // if item_price is less than pricePoint, changes item_price
				printit(item_name[x], item_price[x]); // 
			}
			else
			{
				printit(item_name[x], item_price[x]); // if statement is false and does not change item_price
			}
		}
	}
	static void printit(string item_name, double item_price) // method used to print out statements
	{
		Console.WriteLine("The price for {0} is ${1}.", item_name, item_price); // uses array index to fill in statement
	}

}