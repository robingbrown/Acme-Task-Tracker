using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ACMETaskTracker.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(
                    new AcmeTask
                    {
                        Title = "Kayak",
                        Content = "A boat for one person",
                        Category = "Concerns"
                    },
                    new AcmeTask
                    {
                        Title = "Lifejacket",
                        Content = "Protective and fashionable",
                        Category = "Concerns"
                    },
                    new AcmeTask
                    {
                        Title = "Jobs Ball",
                        Content = "FIFA-approved size and weight",
                        Category = "Jobs"
                    },
                    new AcmeTask
                    {
                        Title = "Corner Flags",
                        Content = "Give your playing field a professional touch",
                        Category = "Jobs"
                    },
                    new AcmeTask
                    {
                        Title = "Stadium",
                        Content = "Flat-packed 35,000-seat stadium",
                        Category = "Jobs"
                    },
                    new AcmeTask
                    {
                        Title = "Thinking Cap",
                        Content = "Improve brain efficiency by 75%",
                        Category = "Decisions"
                    },
                    new AcmeTask
                    {
                        Title = "Unsteady Chair",
                        Content = "Secretly give your opponent a disadvantage",
                        Category = "Decisions"
                    },
                    new AcmeTask
                    {
                        Title = "Human Decisions Board",
                        Content = "A fun game for the family",
                        Category = "Decisions"
                    },
                    new AcmeTask
                    {
                        Title = "Bling-Bling King",
                        Content = "Gold-plated, diamond-studded King",
                        Category = "Decisions"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}