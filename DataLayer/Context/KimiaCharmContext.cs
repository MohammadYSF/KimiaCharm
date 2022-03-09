using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;


namespace DataLayer.Context
{
    public class KimiaCharmContext : DbContext
    {
        public KimiaCharmContext(DbContextOptions<KimiaCharmContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed data category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryID = 1,
                Name = "کیف"
            },
            new Category()
            {
                CategoryID = 2,
                Name = "جاهندزفری"
            });
            #endregion
            #region seed data product
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductID = 1,
                CategoryID = 1,
                Name = "کیف چرمی زنانه",
                Date = DateTime.Now,
                FullDescription = "کیف زنانه در رنگ های متنوع و ساخته شده با چرم طبیعی با قیمتی باور نکردنی ",
                ShortDescription = "یک کیف چرمی زنانه بسیار با کیفیت",
                HorizontalImageName = "1.jpg",
                VerticalImageName = "1.jpg",
                IsAvailable = true,
                Keywords = "کیف;کفش;کیف زنانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 200000
            }, new Product()
            {
                ProductID = 2,
                CategoryID = 2,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "2.jpg",
                VerticalImageName = "2.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 3,
                CategoryID = 1,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "3.jpg",
                VerticalImageName = "3.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 4,
                CategoryID = 2,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "4.jpg",
                VerticalImageName = "4.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 5,
                CategoryID = 1,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "5.jpg",
                VerticalImageName = "5.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 6,
                CategoryID = 1,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "6.jpg",
                VerticalImageName = "6.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 7,
                CategoryID = 2,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "7.jpg",
                VerticalImageName = "7.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            }, new Product()
            {
                ProductID = 8,
                CategoryID = 1,
                Name = "کیف چرمی مردانه",
                Date = DateTime.Now,
                FullDescription = "کیف مردانه در رنگ های متنوع و ساخته شده با چرم مصنوعی با قیمتی باور نکردنی ",
                ShortDescription = "کیف مردانه با چرم با کیفیت مخصوص قراردادن اسکناس و کارت",
                HorizontalImageName = "8.jpg",
                VerticalImageName = "8.jpg",
                IsAvailable = false,
                Keywords = "کیف;کفش;کیف مردانه;چرم;چرم طبیعی;کیمیا مهر",
                Price = 300000
            });
            #endregion

            #region seed data cart
            modelBuilder.Entity<Cart>().HasData(new Cart()
            {
                CartID = 1,
                PostingPrice = 30000,
                ProductsTotalPrice = 40000000,
                TotalPrice = 40000000+30000
            });
            #endregion
            #region seed data cart item
            modelBuilder.Entity<CartItem>().HasData(new CartItem()
            {
                CartItemID = 1,
                CartID = 1,
                ProductID = 1,
                Quantity = 2
            }, new CartItem()
            {
                CartItemID = 2,
                CartID = 1,
                ProductID = 2,
                Quantity = 1
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }
        

    }
}
