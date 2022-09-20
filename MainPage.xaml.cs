using Microsoft.Maui;
using System.Reflection;

namespace TestExceptions;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{        
        try {
            MethodInfo method = typeof(MainPage).GetMethod("Test");
            method.Invoke(this, null);
        }
        catch {
        }        
        CounterBtn.Text = Environment.StackTrace;
    }

    public void Test()    {
        
        throw new Exception("");
    }
}

