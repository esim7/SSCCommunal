using Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace EF
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Abonent> Abonents { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RM1NBDJ;Database=Communal;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var firstAbonent = new Abonent { FullName = "Сидоров Петр Иванович", IIN = "891521456632", Address = @"ул. Улы-Дала 18\1" };
            var secondAbonent = new Abonent { FullName = "Пупкина Снежана Евгеньевна", IIN = "651258630002", Address = @"ул. Ташенова 7\57" };
            var thirdAbonent = new Abonent { FullName = "Батыров Серик Батырович", IIN = "785563221011", Address = @"пр-т Тауельсыздык 20\1" };
            modelBuilder.Entity<Abonent>().HasData(firstAbonent, secondAbonent, thirdAbonent);

            var firstReceipt = new Receipt { AbonentId = firstAbonent.Id, BillingMonth = "Ноябрь 2019", ElectricityDebt = 9985, WaterDebt = 6328, InternetDebt = 13615, GasDebt = 2358 };
            var secondReceipt = new Receipt { AbonentId = secondAbonent.Id, BillingMonth = "Ноябрь 2019", ElectricityDebt = 8898, WaterDebt = 9922, InternetDebt = 18000, GasDebt = 5018 };
            var thirdReceipt = new Receipt { AbonentId = thirdAbonent.Id, BillingMonth = "Ноябрь 2019", ElectricityDebt = 11625, WaterDebt = 8839, InternetDebt = 15420, GasDebt = 4568 };
            modelBuilder.Entity<Receipt>().HasData(firstReceipt, secondReceipt, thirdReceipt);
        }
    }
}
