using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShoppingCart
{
	public class PotterShoppingCart
	{
		private List<Book> _books;
		private readonly Dictionary<int, double> _discountTable = new Dictionary<int, double>()
		{
			{1,1},
			{2,0.95},
			{3,0.9},
			{4,0.8},
			{5,0.75}
		};

		public PotterShoppingCart()
		{
			_books = new List<Book>();
		}

		public void AddCommodity(List<Book> book)
		{
			_books = book;
		}

		public double CalculatePrice()
		{
			return _books.Count == 0 ? 0.0 : CalculateDiscountPrice();
		}

		private double CalculateDiscountPrice()
		{
			var totalPrice = CalculateSetPrice(_books);
			var remainBooks = GetRemainBooks(_books);

			while (remainBooks.Count > 0)
			{
				totalPrice += CalculateSetPrice(remainBooks);
				remainBooks = GetRemainBooks(remainBooks);
			}
			return totalPrice;
		}

		private List<Book> GetRemainBooks(List<Book> books)
		{
			return books.Where(i => i.Count > 1)
				.Select(b => new Book() { VolumeNo = b.VolumeNo, Count = b.Count - 1, Price = b.Price })
				.ToList();
		}

		private double CalculateSetPrice(List<Book> books)
		{
			return books.Sum(i => i.Price) * _discountTable[books.Count];
		}
	}
}
