using System;
using System.Threading.Tasks;
using ValidadorDeFacturas.Data;
using Xamarin.Forms;

namespace ValidadorDeFacturas.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ConsultaCFDIManager _manager;
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
            _manager = new ConsultaCFDIManager();
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

                var expresionimpresa = $"?re=test&rr=test&tt=test&id=test";

                var result = await _manager.ConsultaAsync(expresionimpresa);

                await Application.Current.MainPage.DisplayAlert(result.CodigoEstatus, result.Estado, "OK");
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
