using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace InternetData.Properties
{
    public class Recipes
    {
        //retrieves recipes from recipe API based on user inputted string
        public static RecipeInfo getRecipeInfo(string meal)
        {
            //sending API request to internet using client
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(
                HttpMethod.Get,
                string.Format("https://www.themealdb.com/api/json/v1/1/search.php?s={0}", meal)); //recipe API

            HttpResponseMessage response = client.SendAsync(request).Result;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RecipesList));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            //returning first recipe in the meals array from search
            return ((RecipesList)serializer.ReadObject(response.Content.ReadAsStreamAsync().Result)).meals[0];
        }
    }

    [DataContract]
    public class RecipesList //array of different meals
    {
        [DataMember]
        public List<RecipeInfo> meals;
    }

    [DataContract]
    public class RecipeInfo //declaring the class
    {
        [DataMember] //decoration (everything that comes from the API)
        public string strMeal; //property name must be identical to name in JSON file

        [DataMember]
        public string strCategory;

        [DataMember]
        public string strInstructions;

        [DataMember]
        public string strSource;

        //string ingredients
        [DataMember]
        public string strIngredient1;

        [DataMember]
        public string strIngredient2;

        [DataMember]
        public string strIngredient3;

        [DataMember]
        public string strIngredient4;

        [DataMember]
        public string strIngredient5;

        [DataMember]
        public string strIngredient6;

        [DataMember]
        public string strIngredient7;

        [DataMember]
        public string strIngredient8;

        [DataMember]
        public string strIngredient9;

        [DataMember]
        public string strIngredient10;

        [DataMember]
        public string strIngredient11;

        [DataMember]
        public string strIngredient12;

        [DataMember]
        public string strIngredient13;

        [DataMember]
        public string strIngredient14;

        [DataMember]
        public string strIngredient15;

        [DataMember]
        public string strIngredient16;

        [DataMember]
        public string strIngredient17;

        [DataMember]
        public string strIngredient18;

        [DataMember]
        public string strIngredient19;

        [DataMember]
        public string strIngredient20;

        //string measures
        [DataMember]
        public string strMeasure1;

        [DataMember]
        public string strMeasure2;

        [DataMember]
        public string strMeasure3;

        [DataMember]
        public string strMeasure4;

        [DataMember]
        public string strMeasure5;

        [DataMember]
        public string strMeasure6;

        [DataMember]
        public string strMeasure7;

        [DataMember]
        public string strMeasure8;

        [DataMember]
        public string strMeasure9;

        [DataMember]
        public string strMeasure10;

        [DataMember]
        public string strMeasure11;

        [DataMember]
        public string strMeasure12;

        [DataMember]
        public string strMeasure13;

        [DataMember]
        public string strMeasure14;

        [DataMember]
        public string strMeasure15;

        [DataMember]
        public string strMeasure16;

        [DataMember]
        public string strMeasure17;

        [DataMember]
        public string strMeasure18;

        [DataMember]
        public string strMeasure19;

        [DataMember]
        public string strMeasure20;
    }
}
