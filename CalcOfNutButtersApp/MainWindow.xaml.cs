using System;
using System.Collections.Generic;
using System.Windows;
using CalcOfNutButtersApp.NuttyMorning;

namespace CalcOfNutButtersApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PeanutSalt_rB.IsChecked = true;
            massOfPast_tB.Text = "0";
        }
        List<string> ingred;
        List<double> recepts;

        private void Calculate_button_Click(object sender, RoutedEventArgs e)
        {
            CalcNutButter nb = new CalcNutButter(ingred, recepts, Int32.Parse(massOfPast_tB.Text));
            double[] calc = nb.CalculationIngredients();
            string[] output = nb.IngredientsPrint(calc);

            ListValues_tB.Clear();

            for (int i = 0; i < output.Length; i++)
                ListValues_tB.Text += output[i] + "\n";
        }

        private void PeanutSalt_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutSalt;
            recepts = KindOfPast.PeanutSalt;
        }

        private void PeanutPieces_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutPieces;
            recepts = KindOfPast.PeanutPieces;
        }

        private void PeanutHoney_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutHoney;
            recepts = KindOfPast.PeanutHoney;
        }

        private void PeanutDates_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutDates;
            recepts = KindOfPast.PeanutDates;
        }

        private void PeanutRaisin_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutRaisin;
            recepts = KindOfPast.PeanutRaisin;
        }

        private void PeanutMulberry_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutMulberry;
            recepts = KindOfPast.PeanutMulberry;
        }

        private void PeanutCarob_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutCarob;
            recepts = KindOfPast.PeanutCarob;
        }

        private void PeanutCacao_rB_Checked(object sender, RoutedEventArgs e)
        {
            ingred = Ingredients.PeanutChocolate;
            recepts = KindOfPast.PeanutChocolate;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
