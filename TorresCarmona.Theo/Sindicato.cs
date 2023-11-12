namespace Laburos
{
    /// <summary>
    /// La clase Sindicato representa una colección de trabajadores de las diferentes clases y proporciona métodos para gestionarlos.
    /// Permite agregar, quitar y verificar la existencia de trabajadores en la colección.
    /// Proporciona métodos para ordenar la lista de trabajadores por nombre, apellido y salario en orden ascendente o descendente.
    /// </summary>

    public class Sindicato
    {
        private List<Trabajador> trabajadores;

        public List<Trabajador> Trabajadores
        {
            get { return trabajadores; }
            set { trabajadores = value; }
        }

        public Sindicato()
        {
            Trabajadores = new List<Trabajador>();
        }

        public static Sindicato operator +(Sindicato coleccion, Trabajador trabajador)
        {
            if (!coleccion.Trabajadores.Contains(trabajador))
            {
                coleccion.Trabajadores.Add(trabajador);
            }
            return coleccion;
        }

        public static Sindicato operator -(Sindicato coleccion, Trabajador trabajador)
        {
            if (coleccion.Trabajadores.Contains(trabajador))
            {
                coleccion.Trabajadores.Remove(trabajador);
            }
            return coleccion;
        }

        public static bool operator ==(Sindicato coleccion, Trabajador trabajador)
        {
            return coleccion.Trabajadores.Contains(trabajador);
        }

        public static bool operator !=(Sindicato coleccion, Trabajador trabajador)
        {
            return !(coleccion == trabajador);
        }

        public void OrdenarPorNombreAscendente()
        {
            Trabajadores.Sort((t1, t2) => t1.Nombre.CompareTo(t2.Nombre));
        }

        public void OrdenarPorNombreDescendente()
        {
            Trabajadores.Sort((t1, t2) => t2.Nombre.CompareTo(t1.Nombre));
        }

        public void OrdenarPorApellidoAscendente()
        {
            Trabajadores.Sort((t1, t2) => t1.Apellido.CompareTo(t2.Apellido));
        }

        public void OrdenarPorApellidoDescendente()
        {
            Trabajadores.Sort((t1, t2) => t2.Apellido.CompareTo(t1.Apellido));
        }

        public void OrdenarPorSalarioAscendente()
        {
            Trabajadores.Sort((t1, t2) => t1.Salario.CompareTo(t2.Salario));
        }

        public void OrdenarPorSalarioDescendente()
        {
            Trabajadores.Sort((t1, t2) => t2.Salario.CompareTo(t1.Salario));
        }

    }
}
