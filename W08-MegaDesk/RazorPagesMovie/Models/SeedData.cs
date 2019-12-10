﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDesk.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(
                serviceProvider.GetRequiredService<DbContextOptions<MegaDeskContext>>()))
            {
                // Look for any Quotes.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Desk
                    {
                        name = "Paulo Dallastra",
                        width = 30.00,
                        depth = 30.00,
                        numDrawers = 2,
                        price = 1025.00M,
                        surfaceMat = "Rosewood",
                        rushOrd = "7",
                        DateAdded = DateTime.Parse("2018-11-5")
                    }
                
                );
                context.SaveChanges();
            }
        }
    }
}
