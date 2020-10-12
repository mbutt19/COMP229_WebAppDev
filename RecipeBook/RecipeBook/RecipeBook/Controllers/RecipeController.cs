using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;
using RecipeBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Controllers
{ 
    [Authorize]
    public class RecipeController : Controller
    {
        private IRecipeRepo repository;
        private IIngredientRepo ingRepository;
        public RecipeController(IRecipeRepo repo, IIngredientRepo ingRepo)
        {
            repository = repo;
            ingRepository = ingRepo;
        }

        public ViewResult ReviewRecipe() => View();
        public ViewResult List() => View(repository.Recipes.OrderBy(r => r.Name));
           
        public ViewResult View(int recipeId)
        {
            RecipeViewModel vm = new RecipeViewModel();
            vm.Recipe = repository.Recipes.FirstOrDefault(r => r.RecipeID == recipeId);
            vm.Ingredients = ingRepository.Ingredients.Where(i => i.RecipeID == recipeId)
                .OrderBy(i=>i.IngredientID).ToList();

            return View(vm);
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            GreetingTime();
            return View();
        }

        public ViewResult Edit(int recipeId)
        {
            RecipeViewModel recipeViewModel = new RecipeViewModel();
            recipeViewModel.Recipe = repository.Recipes.FirstOrDefault(r => r.RecipeID == recipeId);
            recipeViewModel.Ingredients = ingRepository.Ingredients.Where(i => i.RecipeID == recipeId).ToList();
            ViewBag.InputType = "Edit";
            return View(recipeViewModel);
        }
            
        [HttpPost]
        public IActionResult Edit(RecipeViewModel recipeViewModel)
        {
            if (ModelState.IsValid)
            {
                repository.AddRecipe(recipeViewModel.Recipe);
                foreach(Ingredient i in recipeViewModel.Ingredients)
                {
                    ingRepository.SaveIngredient(i);
                }
                TempData["message"] = $"{recipeViewModel.Recipe.Name} has been updated in your RecipeBook";
                return RedirectToAction("List");
            }
            else
            {
                return View(recipeViewModel);
            }
        }

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeId);
            List<int> deletables = new List<int>();
            foreach (Ingredient ing in ingRepository.Ingredients.Where(i=>i.RecipeID == recipeId))
            {
                deletables.Add(ing.IngredientID);
            }
            foreach(int ingID in deletables)
            {
                Ingredient deleteIngredient = ingRepository.DeleteIngredient(ingID);
            }
            if(deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.Name} was deleted from your RecipeBook";
            }
            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            RecipeViewModel recipeViewModel = new RecipeViewModel();
            for (int i = 0; i < 5; i++)
            {
                recipeViewModel.Ingredients.Add(new Ingredient { RecipeID=recipeViewModel.Recipe.RecipeID });
            }
            ViewBag.InputType = "Add New";
            return View(recipeViewModel); ;
        }
            
        [HttpPost]
        public IActionResult Create(RecipeViewModel recipeViewModel)
        {

            if (ModelState.IsValid)
            {
                repository.AddRecipe(recipeViewModel.Recipe);
                foreach (Ingredient i in recipeViewModel.Ingredients)
                {
                    i.RecipeID = repository.Recipes.FirstOrDefault(r => r.Name == recipeViewModel.Recipe.Name).RecipeID;
                    ingRepository.SaveIngredient(i);
                }
                TempData["message"] = $"{recipeViewModel.Recipe.Name} has been added to your RecipeBook";
                return RedirectToAction("List");
            }
            else
            {
                return View(recipeViewModel);
            }
        }

        //method to return greeting based on time
        public void GreetingTime()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
                ViewBag.Greeting = "Good Morning";
            else if (hour >= 12 && hour < 17)
                ViewBag.Greeting = "Good Afternoon";
            else if (hour >= 17 && hour < 22)
                ViewBag.Greeting = "Good Evening";
            else
                ViewBag.Greeting = "Good Night";
        }
    }
}
