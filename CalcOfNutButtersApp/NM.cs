using System;
using System.Collections.Generic;

namespace NuttyMorning
{
    public static class KindOfPast //Рецепты ореховых паст
    {
        //Рецепт арахисовой пасты с солью
        public static List<double> PeanutSalt = new List<double>() { 200 };
        //Рецепт арахисовой пасты с солью и кусочками
        public static List<double> PeanutPieces = new List<double>() { 200, 5.66 };
        //Рецепт арахисовой пасты с медом
        public static List<double> PeanutHoney = new List<double>() { 9 };
        //Рецепт арахисовой пасты с финиками
        public static List<double> PeanutDates = new List<double>() { 5.66 };
        //Рецепт арахисовой пасты с кусочками арахиса, шелковицей и корицей
        public static List<double> PeanutMulberry = new List<double>() { 10, 4.2, 90 };
        //Рецепт арахисовой пасты с кэробом и финиками
        public static List<double> PeanutCarob = new List<double>() { 24, 5.66 };
        //Рецепт арахисовой пасты с какао, медом и фундуком
        public static List<double> PeanutChocolate = new List<double>() { 24, 9, 5.66 };
        //Рецепт арахисовой пасты с изюмом и курагой
        public static List<double> PeanutRaisin = new List<double>() { 11.32, 11.32 };
        //Кунжутная паста с медом
        public static List<double> Sesame = new List<double>() { 5.66 };
        //Паста из грецкого ореха с финиками и черносливом
        public static List<double> Wallnut = new List<double>() { 5, 7.5 };
    }
    public static class Ingredients //Строковые значения ингредиентов ореховых паст
    {
        public static List<string> PeanutSalt = new List<string>() { "соль - " };
        public static List<string> PeanutPieces = new List<string>() { "соль - ", "кусочки арахиса - " };
        public static List<string> PeanutHoney = new List<string>() { "мед - " };
        public static List<string> PeanutDates = new List<string>() { "финики - " };
        public static List<string> PeanutMulberry = new List<string>() { "кусочки - ", "шелковица - ", "корица - " };
        public static List<string> PeanutCarob = new List<string>() { "кэроб - ", "финики - " };
        public static List<string> PeanutChocolate = new List<string>() { "какао - ", "мед - ", "фундук - " };
        public static List<string> PeanutRaisin = new List<string>() { "изюм - ", "курага - " };
        public static List<string> Sesame = new List<string>() { "мед - " };
        public static List<string> Wallnut = new List<string>() { "финики - ", "чернослив - " };
    }

    class NutPastes
    {
        private List<string> _ingredients;
        private List<double> _values;
        private int _massOfPast;

        public NutPastes(List<string> ingredients, List<double> values, int massOfPast)
        {
            _ingredients = ingredients;
            _values = values;
            _massOfPast = massOfPast;
        }

        public double[] CalculationIngredients()  //Расчет ингредиентов
        {
            int count = _ingredients.Count;
            double[] valueOfIngred = new double[count];

            for (int i = 0; i < count; i++)
            {
                valueOfIngred[i] = _massOfPast / _values[i];
            }
            return valueOfIngred;
        }

        public string[] IngredientsOutput(double[] argum1)  //Вывод игредиентов
        {
            int count = _ingredients.Count;
            string[] nameOfIngred = new string[count];

            try
            {
                for (int i = 0; i < count; i++)
                {
                    nameOfIngred[i] = _ingredients[i] + " " + (int)argum1[i];
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            return nameOfIngred;
        }
    }
}