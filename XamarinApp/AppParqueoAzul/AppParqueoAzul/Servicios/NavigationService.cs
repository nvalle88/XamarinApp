using AppParqueoAzul.Pages;
using AppParqueoAzul.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParqueoAzul.Services
{
   public class NavigationService
    {
        public void  NavigateBack()
        {
             App.Navigator.PopAsync();
        }

        public async Task Navigate()
        {
            //   App.Master.IsPresented = false;

            var main = MainViewModel.GetInstance();
            main.LoadMenu();
            App.Current.MainPage = new MasterPage();

            await App.Navigator.PopToRootAsync();
           
        }

        internal void SetMainPage(UsuarioViewModel usuarioActual)
        {
            App.UsuarioActual = usuarioActual;
            App.Current.MainPage = new MasterPage();
        }

        public UsuarioViewModel  GetUsuarioActual()
        {
            return App.UsuarioActual;
        }
    }
}
