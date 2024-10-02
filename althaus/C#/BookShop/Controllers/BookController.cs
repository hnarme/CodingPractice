using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models;

namespace BookShop.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Book book;
        book = new Book();
        book.Id = 123;
        book.Name = "Life";
        book.Author = "Hannah Narme";

        Customer customer;
        customer = new Customer();
        customer.Id = 78;
        customer.Name = "John Doe";
        customer.Postcode = "B45 8TD";
        customer.PhoneNumber = 07389214365;

        Sale sale;
        sale = new Sale();
        sale.BookId = book.Id;
        sale.CustomerId = 223;
        sale.SaleDate = new DateOnly(02, 06, 24);

        return View(book);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
