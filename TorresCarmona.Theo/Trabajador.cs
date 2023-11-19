using System.Xml.Serialization;

namespace Laburos
{
    [Serializable]
    [XmlInclude(typeof(Cirujano))]
    [XmlInclude(typeof(Deportista))]
    [XmlInclude(typeof(Periodista))]

    /// <summary>
    /// La clase Trabajador es una clase abstracta que representa a un trabajador genérico.
    /// Contiene propiedades para el nombre, apellido, salario y tipo de trabajador.
    /// La clase implementa la serialización XML
    /// Sobrecarga los métodos ToString y Equals para comparaciones de igualdad.
    /// Es la base para diferentes tipos de trabajadores, como Cirujano,Trabajador y Periodista, que heredan de esta clase.
    /// </summary>

    public abstract class Trabajador
    {
        protected string nombre;
        protected string apellido;
        protected double salario;
        protected ETipo tipo;
        protected double id;
        
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }        
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }                   
        }

        public double Salario
        { 
            get { return salario; } 
            set { salario = value; }       
        }

        public ETipo Tipo
        { 
            get { return tipo; }
            set { tipo = value; }
        }
        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        public Trabajador()
        {
            this.nombre = "N/N";
            this.apellido = "N/N";
            this.salario = 1;
            this.tipo = ETipo.Tiempocompleto;
            this.id = 0;    
        }

        public Trabajador(string Nombre, string Apellido)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
        }

        public Trabajador(string Nombre, string Apellido, double Salario)
            : this(Nombre, Apellido)
        {
            this.salario = Salario;
        }

        public Trabajador(string Nombre, string Apellido, double Salario, ETipo Tipo, double Id)
            : this(Nombre, Apellido, Salario)
        {
            this.tipo = Tipo;
            this.id = Id;
        }

        protected abstract void RealizarTarea();

        protected virtual string MostrarDatos()
        {
            return $"Id: {Id} - Nombre: {Nombre} {Apellido} - Trabajador: {Tipo} - Sueldo: {Salario}$";
        }
        public override string ToString()
        {
            return MostrarDatos();
        }

        static public implicit operator double(Trabajador trabajador)
        {
            return trabajador.salario;
        }

        public static bool operator ==(Trabajador trabajador1, Trabajador trabajador2)
        {
            return trabajador1.Nombre == trabajador2.Nombre && trabajador1.Apellido == trabajador2.Apellido || trabajador1.Id == trabajador2.Id;
        }

        public static bool operator !=(Trabajador trabajador1, Trabajador trabajador2)
        {
            return !(trabajador1 == trabajador2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Trabajador otroTrabajador = (Trabajador)obj;
            return this.nombre == otroTrabajador.Nombre && this.apellido == otroTrabajador.Apellido || this.id == otroTrabajador.Id;
        }

    }
}