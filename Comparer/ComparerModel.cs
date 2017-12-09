namespace Comparer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class ComparerModel : DbContext
    {
        // Your context has been configured to use a 'ComparerModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Comparer.ComparerModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ComparerModel' 
        // connection string in the application configuration file.
        public ComparerModel()
            : base("name=ComparerModel")
        {
        }
        public DbSet<Price> Price { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Customer> Customer { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }


    public class Price
    {
        [Key]
        public string ProductID { get; set; }
        public string ShopID { get; set; }
        public DateTime DateT { get; set; }
        public float PriceD { get; set; }

    }
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Shop { get; set; }
        public DateTime Date { get; set; }
        public bool Accept { get; set; }
    }

    public class Shop
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class Customer
    {
        [Key]
        public string CardID { get; set; }
        public string Name { get; set; }
        public float Spent { get; set; }
        public string Password { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}