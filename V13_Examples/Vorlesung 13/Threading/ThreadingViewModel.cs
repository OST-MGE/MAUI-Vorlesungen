namespace Vorlesung_13.Threading
{
    public class ThreadingViewModel : BindableBase
    {
        private bool _isCalculating;

        public ThreadingViewModel()
        {
            CalculateCommand = new RelayCommand(CalculateCommandExecute, CalculateCommandCanExecute);
        }

        public bool IsCalculating
        {
            get => _isCalculating;
            set
            {
                SetProperty(ref _isCalculating, value);
                CalculateCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand CalculateCommand { get; }

        private void CalculateCommandExecute()
        {
            IsCalculating = true;

            Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IsCalculating = false;
            });
        }

        private bool CalculateCommandCanExecute() => !IsCalculating;
    }
}
