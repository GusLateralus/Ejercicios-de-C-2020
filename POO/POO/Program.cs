// Clases y objetos:
public class Program
{
    // Clase abstracta: Una clase que no puede ser instanciada en términos normales, sino que tiene que heredar
    abstract class Persona
    {
        // Atributos privados
        private string nombre;
        private int edad;

        /*  Una manera más C-sharpera de hacer getters y setters es;

        public string Nombre { get; set; }
        public int Edad { get; set; }
         
         
         */

        // Atributos públicos
        //public string Nombre;

        //Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            
        }
        public Persona()
        {

        }

        // Getters y Setter
        public string getNombre() {  
            return nombre; 
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;

        }

        // Métodos abstractos: No tiene una implementación directa, se hace en la clase heredera
        public abstract void Presentarse();
        // Métodos virtuales: son métodos definidos en una clase base que pueden ser sobreescritos en una clase derivada
        public virtual void Saludar()
        {

            Console.WriteLine("Hola");

        }
    }

    // Herencia:
    class Estudiante : Persona
    {
        // La clase estudiante hereda de la clase Persona
        // La palabra reservada base llama al constructor de la clase padre y se usa para acceder a métodos o propiedades de la clase padre que fueron
        // sobreescritos en la clase hija
        public string carrera;

        public Estudiante()
        {
        }

        public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad) {

            this.carrera = carrera;
        }


        

        public override void Presentarse()
        {
            Console.WriteLine("Mi nombre es " + base.getNombre() + " y tengo " + base.getEdad() + " años de edad");


        }

        public override void Saludar()
        {
            base.Saludar();
        }

    }

        // Clase principal:
    public static void Main(string[] args)
        {
            Estudiante estu = new Estudiante();

            estu.setNombre("Gus");
            estu.setEdad(27);

            estu.Presentarse();
            estu.Saludar();



        }


}
