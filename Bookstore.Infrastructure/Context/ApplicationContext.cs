using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Context;

public class ApplicationContext : DbContext
{
    public DbSet<BookEntity> bookEntities { get; set; }

    public DbSet<OrderEntity> orderEntities { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
}
