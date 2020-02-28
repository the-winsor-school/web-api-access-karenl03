using System;
using System.Net.Http;
using InternetData.Properties;

namespace InternetData
{
    class MainClass
    {
        public static void GetRecipesFromSearch()
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("What meal's recipe would you like to search for?");
            string meal = Console.ReadLine();

            try
            {
                RecipeInfo recipe = Recipes.getRecipeInfo(meal); //referencing Recipes.cs

                Console.WriteLine(); //printing the different recipe info
                Console.WriteLine(recipe.strMeal);
                Console.WriteLine("Meal category: " + recipe.strCategory);
                if(!string.IsNullOrEmpty(recipe.strSource))
                {
                    Console.WriteLine("Link to original recipe: " + recipe.strSource);
                }
                Console.WriteLine();
                Console.WriteLine(recipe.strInstructions);
                Console.WriteLine();

                Console.WriteLine("Ingredients needed:");
                //printing out the different ingredients
                //checking if the ingredients are null

                if (!string.IsNullOrEmpty(recipe.strIngredient1))
                {
                    Console.WriteLine(recipe.strIngredient1 + ": " + recipe.strMeasure1);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient2))
                {
                    Console.WriteLine(recipe.strIngredient2 + ": " + recipe.strMeasure2);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient3))
                {
                    Console.WriteLine(recipe.strIngredient3 + ": " + recipe.strMeasure3);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient4))
                {
                    Console.WriteLine(recipe.strIngredient4 + ": " + recipe.strMeasure4);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient5))
                {
                    Console.WriteLine(recipe.strIngredient5 + ": " + recipe.strMeasure5);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient6))
                {
                    Console.WriteLine(recipe.strIngredient6 + ": " + recipe.strMeasure6);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient7))
                {
                    Console.WriteLine(recipe.strIngredient7 + ": " + recipe.strMeasure7);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient8))
                {
                    Console.WriteLine(recipe.strIngredient8 + ": " + recipe.strMeasure8);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient9))
                {
                    Console.WriteLine(recipe.strIngredient9 + ": " + recipe.strMeasure9);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient10))
                {
                    Console.WriteLine(recipe.strIngredient10 + ": " + recipe.strMeasure10);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient11))
                {
                    Console.WriteLine(recipe.strIngredient11 + ": " + recipe.strMeasure11);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient12))
                {
                    Console.WriteLine(recipe.strIngredient12 + ": " + recipe.strMeasure12);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient13))
                {
                    Console.WriteLine(recipe.strIngredient13 + ": " + recipe.strMeasure13);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient14))
                {
                    Console.WriteLine(recipe.strIngredient14 + ": " + recipe.strMeasure14);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient15))
                {
                    Console.WriteLine(recipe.strIngredient15 + ": " + recipe.strMeasure15);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient16))
                {
                    Console.WriteLine(recipe.strIngredient16 + ": " + recipe.strMeasure16);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient17))
                {
                    Console.WriteLine(recipe.strIngredient17 + ": " + recipe.strMeasure17);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient18))
                {
                    Console.WriteLine(recipe.strIngredient18 + ": " + recipe.strMeasure18);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient19))
                {
                    Console.WriteLine(recipe.strIngredient19 + ": " + recipe.strMeasure19);
                }
                if (!string.IsNullOrEmpty(recipe.strIngredient20))
                {
                    Console.WriteLine(recipe.strIngredient20 + ": " + recipe.strMeasure20);
                }
            }
            catch //catching an exception if there is no recipe for the inputted meal
            {
                Console.WriteLine("No results found for " + meal + ".");
            }
            
        }


        public static void Main(string[] args)
        {
            GetRecipesFromSearch(); //calling the above function
        }
    }
}
