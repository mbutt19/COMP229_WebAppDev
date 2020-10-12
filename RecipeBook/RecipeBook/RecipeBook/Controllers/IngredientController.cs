using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Controllers
{
    [Authorize]
    public class IngredientController : Controller
    {
        private IRecipeRepo repository;
        private IIngredientRepo ingRepository;
        public IngredientController(IRecipeRepo repo, IIngredientRepo ingRepo)
        {
            repository = repo;
            ingRepository = ingRepo;
        }

        public ViewResult Index() => View("IngList", ingRepository.Ingredients.OrderBy(i => i.RecipeID));

        public ViewResult IngEdit(int ingredientId)
        {
            ViewBag.InputType = "Edit";
            return View(ingRepository.Ingredients.FirstOrDefault(i => i.IngredientID == ingredientId));
        }
            
        [HttpPost]
        public IActionResult IngEdit(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                ingRepository.SaveIngredient(ingredient);
                TempData["message"] = $"{ingredient.Name} has been updated in your RecipeBook";
                return RedirectToAction("Index");
            }
            else
            {
                return View(ingredient);
            }
        }

        public ViewResult IngAddToRecipe(int RecipeID) => View();
        [HttpPost]
        public IActionResult IngAddToRecipe(Ingredient ingredient, int RecipeID)
        {
                ingredient.RecipeID = RecipeID;
                Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeID == ingredient.RecipeID);
                ingRepository.SaveIngredient(ingredient);
                TempData["message"] = $"{ingredient.Name} has been added to your Recipe";
                return RedirectToAction("View","Recipe", recipe);
        }

        [HttpPost]
        public IActionResult Delete(int ingredientId)
        {
            Ingredient deletedIngredient = ingRepository.DeleteIngredient(ingredientId);
            if (deletedIngredient != null)
            {
                TempData["message"] = $"{deletedIngredient.Name} was deleted from your RecipeBook";
            }
            return RedirectToAction("Index");
        }

        public ViewResult Create(int ingredientId)
        {
            ViewBag.InputType = "Add New";
            return View("IngEdit", new Ingredient());
        }
    }
}
