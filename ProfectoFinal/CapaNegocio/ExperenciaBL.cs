﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class ExperenciaBL
    {
        ExperenciaDAL unExperencia= new ExperenciaDAL();
        
        public string RegistrarExprencia (Experencia experencia)
        {
            return unExperencia.registrarExperencia (experencia);
        }
    }
}
