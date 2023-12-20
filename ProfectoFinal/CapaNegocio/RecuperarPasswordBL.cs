using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class RecuperarPasswordBL
    {
        public string recoverPassword(string userRequesting)
        {
            return new RecuperarPasswordDAL().recoverPassword(userRequesting);
        }
    }
}
