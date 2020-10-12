using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class EFRecipeRepo : IRecipeRepo
    {
        private ApplicationDbContext context;

        public EFRecipeRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public void AddRecipe(Recipe recipe)
        {
            if(recipe.RecipeID == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe dbEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeID == recipe.RecipeID);
                if(dbEntry != null)
                {
                    dbEntry.Name = recipe.Name;
                    dbEntry.PrepMinutes = recipe.PrepMinutes;
                    dbEntry.Servings = recipe.Servings;
                    dbEntry.CookMinutes = recipe.CookMinutes;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Directions = recipe.Directions;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int recipeID)
        {
            Recipe dbEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeID == recipeID);
            if(dbEntry != null)
            {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
