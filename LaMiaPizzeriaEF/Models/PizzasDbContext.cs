﻿namespace LaMiaPizzeriaEF.Models {
    public class PizzasDbContext : DbContext {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzaShop;" +
                                        "Integrated Security=True;TrustServerCertificate=True");
        }

        public int AddPizza(Pizza pizza) {
            Pizzas.Add(pizza);
            return SaveChanges();
        }
    }
}
