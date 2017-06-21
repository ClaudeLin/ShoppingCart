using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCartTest
{
	[TestClass]
	public class PotterShoppingCartTest
	{
		private double expected;
		private double actual;
		private PotterShoppingCart target;
		private List<Book> books;
		[TestMethod]
		public void Buy_1_First_Volume_should_pay_100()
		{
			target = new PotterShoppingCart();
			books = new List<Book>
			{
				new Book
				{
					VolumeNo = 1,
					Price = 100
				}
			};
			expected = 100;

			target.AddCommodity(books);
			actual = target.CalculatePrice();
			
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_and_1_Second_Volume_should_pay_190()
		{
			target = new PotterShoppingCart();
			books = new List<Book>
			{
				new Book()
				{
					VolumeNo = 1,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 2,
					Price = 100
				}
			};
			expected = 190;

			target.AddCommodity(books);
			actual = target.CalculatePrice();
			
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_1_Second_Volume_and_1_Third_Volume_should_pay_270()
		{
			target=new PotterShoppingCart();
			books=new List<Book>()
			{
				new Book()
				{
					VolumeNo = 1,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 2,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 3,
					Price = 100
				}
			};
			expected = 270;

			target.AddCommodity(books);
			actual = target.CalculatePrice();

			Assert.AreEqual(expected,actual);
		}
		[TestMethod]
		public void Buy_1_First_Volume_1_Second_Volume_1_Third_Volume_and_1_Fourth_Volume_should_pay_320()
		{
			target = new PotterShoppingCart();
			books = new List<Book>()
			{
				new Book()
				{
					VolumeNo = 1,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 2,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 3,
					Price = 100
				},
				new Book()
				{
					VolumeNo = 4,
					Price = 100
				}
			};
			expected = 320;

			target.AddCommodity(books);
			actual = target.CalculatePrice();

			Assert.AreEqual(expected, actual);
		}
	}
}
