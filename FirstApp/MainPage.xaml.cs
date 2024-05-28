﻿namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        int count = 10;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
                count = 10;
            if (count == 10)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
