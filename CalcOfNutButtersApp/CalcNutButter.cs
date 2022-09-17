using CalcOfNutButtersApp.NuttyMorning;
using System.Collections.Generic;

namespace CalcOfNutButtersApp
{
    class CalcNutButter: NutPastes
    {
        private List<string> _ingredients;
        private List<double> _values;
        private int _massOfPast;

        public CalcNutButter(List<string> ingredients, List<double> values, int massOfPast) 
            : base(ingredients, values, massOfPast)
        {
            _ingredients = ingredients;
            _values = values;
            _massOfPast = massOfPast;
        }
    }
}
