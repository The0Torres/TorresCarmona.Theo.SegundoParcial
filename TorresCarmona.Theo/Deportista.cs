namespace Laburos
{
    [Serializable]

    /// <summary>
    /// La clase Deportista hereda de Trabajador y representa a un trabajador dedicado al ámbito deportivo.
    /// Contiene propiedades para el deporte practicado, el número de trofeos y el ranking mundial.
    /// Proporciona constructores para inicializar estos valores y métodos para operaciones específicas.
    /// También incluye métodos para comparar y mostrar información detallada del deportista.
    /// </summary>
    
    public class Deportista:Trabajador
    {
        protected string deporte;
        protected double trofeos;
        protected double rankingMundial;

        public double RankingMundial
        { 
            get { return rankingMundial; }
            set { rankingMundial = value; }
        }

        public double Trofeos
        {
            get { return trofeos; }
            set { trofeos = value;}
        }

        public string Deporte
        { 
            get { return deporte; }
            set { deporte = value; }
        }

        public Deportista() :base()
        {
            this.deporte = "N/N";
            this.trofeos = 0;
            this.rankingMundial = 100;
        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte) 
            : base(Nombre, Apellido, Salario, Tipo)
        {
            this.deporte = Deporte;
        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte, double Trofeos) 
            : this(Nombre, Apellido, Salario, Tipo, Deporte)
        {
            this.trofeos = Trofeos;
        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte, double Trofeos, double RankingMundial) 
            : this(Nombre, Apellido, Salario, Tipo, Deporte,Trofeos)
        {
            this.rankingMundial = RankingMundial;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Entrenando para la competicion");
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Deporte: {Deporte} - Trofeos: {Trofeos} - Ranking deportistas: {RankingMundial}";
        }


        public static bool operator ==(Deportista deportista1, Deportista deportista2)
        {
            return deportista1.Nombre == deportista2.Nombre && deportista1.Apellido == deportista2.Apellido;
        }

        public static bool operator !=(Deportista deportista1, Deportista deportista2)
        {
            return !(deportista1 == deportista2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Deportista otroDeportista)
            {
                return base.Equals(obj) && this.Deporte == otroDeportista.Deporte;
            }
            return false;
        }
    }
}
