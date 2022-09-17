using System;
using System.Collections.Generic;

namespace CalcOfNutButtersApp.NuttyMorning
{

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

        public string[] IngredientsPrint(double[] calculatedIngredients)  //Вывод игредиентов
        {
            int count = _ingredients.Count;
            string[] nameOfIngred = new string[count];

            try
            {
                for (int i = 0; i < count; i++)
                {
                    nameOfIngred[i] = _ingredients[i] + " " + (int)calculatedIngredients[i];
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