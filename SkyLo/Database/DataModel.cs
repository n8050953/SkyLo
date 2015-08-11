namespace SkyLo
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class DataModel : DbContext
  {
    public DataModel()
      : base("name=DataModel")
    {
    }

    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Stock> Stocks { get; set; }
    public virtual DbSet<StockType> StockTypes { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Order>()
          .Property(e => e.Order_Id)
          .IsFixedLength();

      modelBuilder.Entity<Order>()
          .Property(e => e.Order_User)
          .IsFixedLength();

      modelBuilder.Entity<Order>()
          .Property(e => e.Order_Quantity)
          .IsFixedLength();

      modelBuilder.Entity<Order>()
          .Property(e => e.Stock_Id)
          .IsFixedLength();

      modelBuilder.Entity<Stock>()
          .Property(e => e.Stock_Name)
          .IsFixedLength();

      modelBuilder.Entity<Stock>()
          .Property(e => e.Stock_Type)
          .IsFixedLength();

      modelBuilder.Entity<StockType>()
          .Property(e => e.StockType_Code)
          .IsFixedLength();

      modelBuilder.Entity<StockType>()
          .Property(e => e.StockType_Desc)
          .IsFixedLength();
    }
  }
}
