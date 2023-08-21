namespace Bookstore.Domain.Entities;

public class OrderEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public List<BookEntity>? Books { get; set; }
}
