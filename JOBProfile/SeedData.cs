

using JOBProfile.Core.Entities;
using JOBProfile.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace JOBProfile;

public static class SeedData
{
  public static readonly DBRecipies ButterChicken = new DBRecipies()
  {
    Name = "Butter Chicken Curry",
  };
  public static readonly DBRecipies CottagePie = new DBRecipies()
  {
    Name = "Cottage Pie"
  };

  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var dbContext = new RecipiesContext(
        serviceProvider.GetRequiredService<DbContextOptions<RecipiesContext>>(), null))
    {
      
      if (dbContext.Recipies.Any())
      {
        return;   // DB has been seeded
      }
            PopulateDishes(dbContext);


    }
  }
  
  public static void PopulateDishes(RecipiesContext dbContext)
  {
    foreach (var item in dbContext.Recipies)
    {
      dbContext.Remove(item);
    }
    dbContext.SaveChanges();


    ButterChicken.AddItem(new List<string>() { "butter", "cream", "tomato sause", "chicken", "onion", "garlic", "curry powder", "potatoes" });
    dbContext.Recipies.Add(ButterChicken);

    dbContext.SaveChanges();
  }
}
