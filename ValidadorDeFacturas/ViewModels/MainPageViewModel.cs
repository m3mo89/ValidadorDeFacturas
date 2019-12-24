using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValidadorDeFacturas.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
                OnValidarCommand.ChangeCanExecute();
            }
        }

        public Command OnValidarCommand { get; private set; }

        public MainPageViewModel()
        {
            OnValidarCommand = new Command(async () => await ValidarAsync(), () => !IsBusy);
        }

        private async Task ValidarAsync()
        {
            if (IsBusy)
            {
                return;
            }

            Exception error = null;

            try
            {
                IsBusy = true;

                Console.WriteLine("Comando bindeado");
            }
            catch (Exception ex)
            {
                error = ex;
            }
            finally
            {
                IsBusy = false;
            }

            if (error != null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", error.Message, "OK");
            }
        }
    }
}
