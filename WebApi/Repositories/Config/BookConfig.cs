﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new Book { Id = 1, Title = "Book1", Price = 175});
            builder.HasData(new Book { Id = 2, Title = "Book2", Price = 275 });
            builder.HasData(new Book { Id = 3, Title = "Book3", Price = 375 });
        }
    }
}
