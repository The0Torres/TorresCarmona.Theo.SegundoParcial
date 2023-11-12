namespace Laburos
{

    [Serializable]

    /// <summary>
    /// La clase Cirujano hereda de Trabajador y representa a un trabajador del ámbito médico.
    /// Contiene propiedades para el número de cirugías realizadas, especialidad y hospital de trabajo.
    /// Proporciona constructores para inicializar estos valores y métodos para operaciones específicas.
    /// Incluye métodos para comparar y mostrar información detallada del cirujano.
    /// </summary>
    
    public class Cirujano:Trabajador
    {
        protected double cirugias;
        protected string especialidad;
        protected EHospitales hospital;

        public double Cirugias
        { 
            get { return cirugias; } 
            set { cirugias = value; }
        }

        public EHospitales Hospital
        { 
            get { return hospital; } 
            set { hospital = value; }        
        }

        public string Especialidad
        { 
            get { return especialidad; }
            set { especialidad = value; }
        }
        public Cirujano() : base()
        {
            this.Cirugias = 0;
            this.especialidad = "N/N";
            this.hospital = EHospitales.Italiano;
        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo, string Especialidad)
            : base(Nombre, Apellido, Salario, Tipo)
        {
            this.especialidad = Especialidad;
        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo ,string Especialidad, EHospitales Hospital)
            : this(Nombre, Apellido , Salario, Tipo, Especialidad)
        {
            this.hospital = Hospital;
        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo ,string Especialidad, EHospitales Hospital, double Cirugias)
            : this(Nombre, Apellido, Salario, Tipo, Especialidad, Hospital)
        {
            this.cirugias = Cirugias;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Realizando cirugia a un paciente");
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Cirujano {Especialidad} - Cirugías realizadas: {Cirugias} - Hospital {Hospital}";
        }


        public static bool operator ==(Cirujano cirujano1, Cirujano cirujano2)
        {

            return cirujano1.Nombre == cirujano2.Nombre && cirujano1.Apellido == cirujano2.Apellido;
        }

        public static bool operator !=(Cirujano cirujano1, Cirujano cirujano2)
        {
            return !(cirujano1 == cirujano2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Cirujano otroCirujano)
            {
                return base.Equals(obj) && this.Especialidad == otroCirujano.Especialidad;
            }
            return false;
        }
    }
}
