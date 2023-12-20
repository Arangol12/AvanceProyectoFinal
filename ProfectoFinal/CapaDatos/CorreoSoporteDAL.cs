using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public  class CorreoSoporteDAL:RecuperarPasswordDAL
    {
        public CorreoSoporteDAL()
        {
            remitenteCorreo = "arangollamocca12@gmail.com";
            password = "u b n t d f j g n n d x e m c c";
            host = "smpt.gmail.com";
            port = 587;
            ssl= true;
            initializeSmtpClient();
        }
    }
}
