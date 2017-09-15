using AppParqueoAzul.Data;
using AppParqueoAzul.Entidades.Negocio;
using AppParqueoAzul.Entidades.Utils;
using AppParqueoAzul.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParqueoAzul.Services
{
   public class DataService
    {


        public Response InsertarUsuario(Usuario usuario)
        {
            try
            {
                using (var db = new DataAccess())
                {
                    db.Insert(usuario);
                }

                return new Response
                {
                    IsSuccess = true,
                    Message = "Usuario Registrado Ok",
                    Result=usuario,
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }

        }

       
    }
}
