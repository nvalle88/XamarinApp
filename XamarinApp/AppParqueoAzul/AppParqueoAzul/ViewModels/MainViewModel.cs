using GalaSoft.MvvmLight.Command;
using AppParqueoAzul.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.Maps;
using System.ComponentModel;
using Xamarin.Forms;
using System.Diagnostics;
using AppParqueoAzul.Servicios;

namespace AppParqueoAzul.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Singleton

        static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }



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

        #region Propeties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }


        public LoginViewModel NewLogin { get; set; }


        public ObservableCollection<Pin> Pins { get; set; }

        public UsuarioViewModel UsuarioRegister { get; set; }

      

        public bool IsRefreshing
        {
            set
            {
                if (isRefreshing != value)
                {
                    isRefreshing = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
                }
            }
            get
            {
                return isRefreshing;
            }
        }

        #endregion

        #region Attributes
        private bool isRefreshing = false;
        private NavigationService navigationService;
        private DataService dataService;


        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Services

        public ApiService apiService;

        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;

            Pins = new ObservableCollection<Pin>();
            apiService = new ApiService();
          
            Menu = new ObservableCollection<MenuItemViewModel>();
            dataService = new DataService();
            navigationService = new NavigationService();
            NewLogin = new LoginViewModel();
          

        }





        private void LoadTarjetas()
        {

        }



        #endregion

     


        #region Methods
        public void LoadMenu()
        {
            Menu.Clear();
            Menu.Add(new MenuItemViewModel
            {
                PageName = "ParquearPage",
                Icon = "ic_Comprar.png",
                Title = "Compra de tiempo ahora",
                SubTitle = "Subtitulo",

            });

            Menu.Add(new MenuItemViewModel
            {
                PageName = "CarrosPage",
                Icon = "ic_Carro.png",
                Title = "Administración de Vehículos ",
                SubTitle = "Subtitulo",
            });

            Menu.Add(new MenuItemViewModel
            {

                PageName = "ComprarSaldoPage",
                Icon = "ic_Recarga_Prepago.png",
                Title = "Recarga de tarjeta prepago",
                SubTitle = "Subtitulo",
            });

            Menu.Add(new MenuItemViewModel
            {

                PageName = "PromocionesPage",
                Icon = "ic_Historial_Compras.png",
                Title = "Historial de compras",
                SubTitle = "",
            });

            Menu.Add(new MenuItemViewModel
            {

                PageName = "TarjetasPage",
                Icon = "ic_Tarjeta_Credito.png",
                Title = "Administraciòn tarjetas de crédito",
                SubTitle = "Subtitulo",
            });

        }




        #endregion


    }
}
