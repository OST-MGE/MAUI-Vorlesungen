namespace Vorlesung_14.CustomControls;

public partial class AlertBox : ContentView
{
	public AlertBox()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty MessageProperty = BindableProperty.Create(
        nameof(Message),
        typeof(string),
        typeof(AlertBox),
        string.Empty);


    public string Message
    {
        get => (string)GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }
}