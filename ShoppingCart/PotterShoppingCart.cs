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
		private List<Book> _booksCart;
		private readonly Dictionary<int, decimal> _discount = new Dictionary<int, decimal>()
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
			_booksCart = new List<Book>();
		}

		public void BuyBooks(List<Book> books)
		{
			_booksCart = books;
		}

		public decimal CalculateCartTotalPrice()
		{
			while (_booksCart.Count > 0)
			{
				CalculateBookPrice();
				UpdateRemainBooks();
			}

			return _totalPrice;
		}

		private void UpdateRemainBooks()
		{
			_booksCart= _booksCart.Where(i => i.Count > 1)
				.Select(b => new Book() { VolumeNo = b.VolumeNo, Count = b.Count - 1, Price = b.Price })
				.ToList();
		}

		private void CalculateBookPrice()
		{
			_totalPrice += _booksCart.Sum(i => i.Price) * _discount[_booksCart.Count];
		}
	}
}
