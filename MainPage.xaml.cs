﻿namespace StockPriceSimulator;

public partial class MainPage : ContentPage
{
	private double currentPrice = 150.00;
	private IDispatcherTimer timer;


	public MainPage()
	{
		InitializeComponent();
		SetUptimer();
	}

	private void SetUptimer()
	{
		timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(2);
		timer.Tick += UpdateStockPrice;
		timer.Start();
	}

	private void UpdateStockPrice(object sender,EventArgs e)
	{
		var random = new Random();
		var Change = Math.Round((random.NextDouble()-.05),2);
		var newPice = Math.Round(currentPrice+Change,2);

		StockPriceLabel.Text="${newPrice>[F2]}";

		if (newPice>currentPrice)
		{
			trendIndicastor.Text = "↑";
			trendIndicastor.TextColor = Colors.Green;
		}
		else if (newPice < currentPrice)
		{
            trendIndicastor.Text = "↓";
			trendIndicastor.TextColor = Colors.Red;
        }
		else
		{

		}
		
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}


