namespace BookShop.Models;

public class Sale()
{
    public int BookId { get; set; }
    public int CustomerId { get; set; }
    public DateOnly SaleDate { get; set; }
}