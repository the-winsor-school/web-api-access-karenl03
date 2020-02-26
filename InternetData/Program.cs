using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using InternetData.Properties;

namespace InternetData
{
    class MainClass
    {
        public static void GetRecipesFromSearch()
        {
            HttpClient client = new HttpClient();

            //Console.Write("What meal do you want to search for?  ");
            //int count = Convert.ToInt32(Console.ReadLine());
            string meal = "pasta";

            RecipeInfo recipe = Recipes.getRecipeInfo(meal);
            
            Console.WriteLine(recipe.strMeal);
        }


        public static void Main(string[] args)
        {
            GetRecipesFromSearch();
        }
    }
}
