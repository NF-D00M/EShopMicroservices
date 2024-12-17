﻿using OrderingDomain.Models;
using Microsoft.EntityFrameworkCore;
namespace OrderingApplication.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; }
        DbSet<Product> Products { get; }
        DbSet<Order> Orders { get; }
        DbSet<OrderItem> OrderItems { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
