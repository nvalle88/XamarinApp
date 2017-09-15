using GalaSoft.MvvmLight.Command;
using AppParqueoAzul.Pages;
using AppParqueoAzul.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using AppParqueoAzul.Servicios;

namespace AppParqueoAzul.ViewModels
{
   public class LoginViewModel:INotifyPropertyChanged
    {

        #region Properties
        public string Usuario { get; set; }

        public string Contrasena { get; set; }

        public bool Recuerdame { get; set; }

        public bool isRunning;



        public bool IsRunning
        {
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                }
            }
            get { return isRunning; }
        }

        #endregion

        #region Services
        private NavigationService navigationService;
        private DialogService dialogService;
        private ApiService apiService;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors
        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            apiService = new ApiService();
            Recuerdame = true;
        }

        #endregion

        #region Commands

        public ICommand NavigateRegisterCommand { get { return new RelayCommand(Navigate); } }

        private  void Navigate()
        {
           // App.Current.MainPage = new RegisterPage();
            //await navigationService.Navigate("RegisterPage");
        }

        public ICommand LoginCommand { get {return new RelayCommand(Login) ; } }

        private async void Login()
        {
           

            await navigationService.Navigate();


           

           


            //  main.LoadTiempo();

            IsRunning = false;
            return;

            //IsRunning = true;
            //if (string.IsNullOrEmpty(Usuario))
            //{
            //    IsRunning = false;
            //    await dialogService.ShowMessage("Error", "Debe ingresar el nombre de Usuario");
            //    return;
            //}

            //if (string.IsNullOrEmpty(Contrasena))
            //{
            //    IsRunning = false;
            //    await dialogService.ShowMessage("Error", "Debe ingresar la Contraseña");
            //    return;
            //}



        }

        #endregion

    }
}
