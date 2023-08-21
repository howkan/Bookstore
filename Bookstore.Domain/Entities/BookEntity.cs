namespace Bookstore.Domain.Entities;
public class BookEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Author { get; set; }

    public string Genre { get; set; }

    public decimal Price { get; set; }

    public DateTime RealeseDate { get; set; }

    public Guid OrdersId { get; set; }

    public OrderEntity Order { get; set; }
}
