using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laburos
{
    public interface IAccesoDatos
    {
        bool InsertarTrabajador<T>(T trabajador, string nombreTabla) where T : Trabajador;
        bool EliminarRegistro<T>(T entidad) where T : class;
        bool ModificarTrabajador<T>(T trabajador) where T : Trabajador;
        void CargarLista<T>(List<T> lista, string consulta) where T : class, new();
        List<Periodista> ObtenerListaPeriodistas();
        List<Cirujano> ObtenerListaCirujanos();
        List<Deportista> ObtenerListaDeportistas();
        
    }
}
