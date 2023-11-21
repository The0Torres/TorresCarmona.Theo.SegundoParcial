﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laburos
{
    public interface IAccesoDatos
    {
        bool InsertarPeriodista(Periodista periodista);
        bool InsertarCirujano(Cirujano cirujano);
        bool InsertarDeportista(Deportista deportista);
        bool EliminarRegistro<T>(T entidad) where T : class;
        bool ModificarPeriodista(Periodista periodista);
        bool ModificarCirujano(Cirujano cirujano);
        bool ModificarDeportista(Deportista deportista);
        void CargarLista<T>(List<T> lista, string consulta) where T : class, new();
        List<Periodista> ObtenerListaPeriodistas();
        List<Cirujano> ObtenerListaCirujanos();
        List<Deportista> ObtenerListaDeportistas();
        
    }
}
