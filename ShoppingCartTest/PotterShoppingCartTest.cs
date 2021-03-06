﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCartTest
{
	[TestClass]
	public class PotterShoppingCartTest
	{
		private decimal expected;
		private decimal actual;
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

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

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

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_1_Second_Volume_and_1_Third_Volume_should_pay_270()
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
				}
			};
			expected = 270;

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
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

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_1_Second_Volume_1_Third_Volume_1_Fourth_Volume_and_1_Fifth_Voulme_should_pay_375()
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
				},
				new Book()
				{
					VolumeNo = 5,
					Price = 100
				}
			};
			expected = 375;

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_1_Second_Volume_and_2_Third_Volume_should_pay_370()
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
				},
				new Book()
				{
					VolumeNo = 3,
					Price = 100,
					Count = 2
				}
			};
			expected = 370;

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_2_Second_Volume_and_2_Third_Volume_should_pay_460()
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
					Price = 100,
					Count = 2
				},
				
				new Book()
				{
					VolumeNo = 3,
					Price = 100,
					Count=2
				}
			};
			expected = 460;

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_2_Second_Volume_and_3_Third_Volume_should_pay_560()
		{
			target = new PotterShoppingCart();
			books = new List<Book>
			{
				new Book()
				{
					VolumeNo = 1,
					Price = 100,
					Count = 1
				},
				new Book()
				{
					VolumeNo = 2,
					Price = 100,
					Count=2
				},
				new Book()
				{
					VolumeNo = 3,
					Price = 100,
					Count=3
				}
			};
			expected = 560;

			target.BuyBooks(books);
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Cart_Is_Empty_should_pay_0()
		{
			target = new PotterShoppingCart();
		
			actual = target.CalculateCartTotalPrice();

			Assert.AreEqual(expected, actual);
		}
	}
}
