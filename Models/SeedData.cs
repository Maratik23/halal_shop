using System;
using System.Linq;
using HalalDelivery.Data;
using Microsoft.EntityFrameworkCore;
using HalalDelivery.Models;


public static class SeedData
{
    public static void Initialize(HalalDeliveryDbContext HalalDeliveryDbContext)
    {
        if (HalalDeliveryDbContext == null || HalalDeliveryDbContext.Halals == null)
        {
            throw new ArgumentNullException("Null HalalDeliveryDbContext");
        }

        if (HalalDeliveryDbContext.Halals.Any())
        {
            return; // DB has been seeded
        }

        HalalDeliveryDbContext.Halals.AddRange(
            new Hala()
            {
                Id = 1,
                Name = "Тексель",
                Cost = 1349,
                Weight = 70,
                Description = @"Тексель – типично мясная порода, известна своими уникальными мясными качествами"
            },
            new Hala()
            {
                Id = 2,
                Name = "Шароле",
                Cost = 1369,
                Weight = 80,
                Description = @"Шароле – французская мясо-шерстная порода."
            },
            new Hala()
            {
                Id = 3,
                Name = "Мериноландшаф",
                Cost = 1445,
                Weight = 75,
                Description = "Мериноландшаф – это порода домашних овец из Германии."
            },
            new Hala()
            {
                Id = 4,
                Name = "Дорпер",
                Cost = 1599,
                Weight = 60,
                Description = "Мясо от особей этого вида очень нежное и мягкое на вкус, имеет тонкий слой жира."
            },
            new Hala()
            {
                Id = 5,
                Name = "Альпийская",
                Cost = 1829,
                Weight = 70,
                Description = "Родиной этих животных тоже является Швейцария, но окончательная селекция проводилась на территории Франции и Англии."
            },
            new Hala()
            {
                Id = 6,
                Name = "Бурская",
                Cost = 1779,
                Weight = 64,
                Description = @"В современном козоводстве важное место занимают козы мясных пород. Самыми популярными представителями этой группы стали бурские козы."
            },
            new Hala()
            {
                Id = 7,
                Name = "Тоггенбурская",
                Cost = 1399,
                Weight = 68,
                Description = @"Миниатюрная коза совершенно не подходит для мясного разведения в больших масштабах. Но если пришлось забить животное, то можно быть уверенным, что мясо будет высокого качества"
            },
            new Hala()
            {
                Id = 8,
                Name = "Зааненская",
                Cost = 1399,
                Weight = 68,
                Description = @"Зааненские козы родом из «молочного края» – Швейцарских Альп."
            });
        
        if (HalalDeliveryDbContext == null || HalalDeliveryDbContext.AdditionalProducts == null)
        {
            throw new ArgumentNullException("Null HalalDeliveryDbContext");
        }

        if (HalalDeliveryDbContext.AdditionalProducts.Any())
        {
            return; // DB has been seeded
        }

        HalalDeliveryDbContext.AdditionalProducts.AddRange(
            new AdditionalProduct()
            {
                Id = 9,
                Name = "Козье молоко",
                Cost = 99
            },
             new AdditionalProduct(){
                 Id = 10,
                 Name = "Овечья шерсть",
                 Cost = 199
            },
            new AdditionalProduct()
            {
                Id = 11,
                Name = "Ребра",
                Cost = 69
            });;
        HalalDeliveryDbContext.SaveChanges();
    }
}
