using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Maui_Github_Actions_KeyVault_Test;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
