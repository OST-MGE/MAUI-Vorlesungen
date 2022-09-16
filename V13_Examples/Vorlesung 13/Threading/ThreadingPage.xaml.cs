namespace Vorlesung_13.Threading;

public partial class ThreadingPage : ContentPage
{
    public ThreadingPage()
    {
        InitializeComponent();

        RelayCommand.Dispatch = MainThread.BeginInvokeOnMainThread;

        BindingContext = new ThreadingViewModel();
    }

    private static void SimulateLongRunningOperation() => Thread.Sleep(TimeSpan.FromSeconds(3));

    private void SetOutput(bool isRunning, string operation = null)
    {
        ProgressIndicator.IsRunning = isRunning;
        OutputLabel.Text = operation != null ? $"{operation} abgeschlossen" : string.Empty;
    }

    private void BlockingOperation_OnClicked(object sender, EventArgs e)
    {
        SetOutput(true);
        SimulateLongRunningOperation();
        SetOutput(false, "Blockierende Operation");
    }

    private void NonBlockingOperationWithException_OnClicked(object sender, EventArgs e)
    {
        SetOutput(true);

        Task.Run(SimulateLongRunningOperation)
            .ContinueWith(_ =>
            {
                SetOutput(false, "Nicht-blockierende Operation mit Exception");
            });
    }

    private void NonBlockingOperationWithoutException_OnClicked(object sender, EventArgs e)
    {
        SetOutput(true);

        Task.Run(SimulateLongRunningOperation)
            .ContinueWith(_ => MainThread.BeginInvokeOnMainThread(() =>
            {
                SetOutput(false, "Nicht-blockierende Operation ohne Exception");
            }));
    }
}