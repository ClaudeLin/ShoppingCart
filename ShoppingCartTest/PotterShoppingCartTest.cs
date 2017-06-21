﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCartTest
{
	[TestClass]
	public class PotterShoppingCartTest
	{
		[TestMethod]
		public void Buy_1_First_Volume_should_pay_100()
		{
			var target = new PotterShoppingCart();
			var book = new List<Book>
			{
				new Book
				{
					VolumeNo = 1,
					Price = 100
				}
			};
			target.AddCommodity(book);
			var actual = target.CalculatePrice();
			var expected = 100;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Buy_1_First_Volume_and_1_Second_Volume_should_pay_190()
		{
			var target = new PotterShoppingCart();
			var books = new List<Book>
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

			target.AddCommodity(books);

			var actual = target.CalculatePrice();
			var expected = 190;

			Assert.AreEqual(expected,actual);
		}
	}
}
