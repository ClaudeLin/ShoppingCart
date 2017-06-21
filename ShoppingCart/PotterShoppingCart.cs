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

		public void AddCommodity(List<Book> book)
		{
			_books = book;
		}

		public double CalculatePrice()
		{
			List<Book> tempBooks=new List<Book>();
			foreach (var book in _books)
			{
				if (!tempBooks.Exists(v => v.VolumeNo == book.VolumeNo))
				{
					tempBooks.Add(book);
				}
			}
			var tempPrice = 0.0;
			if (_books.Count != tempBooks.Count)
			{
				foreach (var tempBook in tempBooks)
				{
					if (_books.Exists(v => v.VolumeNo == tempBook.VolumeNo))
					{
						_books.Remove(tempBook);
					}
				}
				tempPrice = tempBooks.Sum(p => p.Price) * _discountTable[tempBooks.Count];
			}
			
			return _books.Sum(p => p.Price) * _discountTable[_books.Count]+ tempPrice;
		}
	}
}
