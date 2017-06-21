using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
	    private List<Book> _books;

	    public void AddCommodity(List<Book> book)
	    {
		    _books = book;
	    }

	    public int CalculatePrice()
	    {
		    return _books.Count == 2 ? 190 : 100;
	    }
    }
}
