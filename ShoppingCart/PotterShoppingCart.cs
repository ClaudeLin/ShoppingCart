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

	    public void AddCommodity(List<Book> book)
	    {
		    _books = book;
	    }

	    public double CalculatePrice()
	    {
		    if (_books.Count == 2)
		    {
			    return _books.Sum(p => p.Price)*0.95;
		    }
		    if (_books.Count == 3)
		    {
			    return _books.Sum(p => p.Price)*0.9;
		    }
		    return 100;
	    }
    }
}
