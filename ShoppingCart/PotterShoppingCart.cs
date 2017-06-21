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
		private readonly Dictionary<int, decimal> _discountTable = new Dictionary<int, decimal>()
		{
			{1,1m},
			{2,0.95m},
			{3,0.9m},
			{4,0.8m},
			{5,0.75m}
		};

		private decimal _totalPrice;

		public PotterShoppingCart()
		{
			_books = new List<Book>();
		}

		public void PutBooksToCart(List<Book> book)
		{
			_books = book;
		}

		public decimal CalculatePrice()
		{
			return _books.Count == 0 ? _totalPrice : CalculateDiscountPrice();
		}

		private decimal CalculateDiscountPrice()
		{
			while (_books.Count > 0)
			{
				CalculateSetPrice();
				UpdateRemainBooks();
			}
			return _totalPrice;
		}

		private void UpdateRemainBooks()
		{
			_books= _books.Where(i => i.Count > 1)
				.Select(b => new Book() { VolumeNo = b.VolumeNo, Count = b.Count - 1, Price = b.Price })
				.ToList();
		}

		private void CalculateSetPrice()
		{
			_totalPrice += _books.Sum(i => i.Price) * _discountTable[_books.Count];
		}
	}
}
