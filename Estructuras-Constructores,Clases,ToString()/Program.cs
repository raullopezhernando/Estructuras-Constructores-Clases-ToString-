using System;
using System.Text;

namespace Estructuras_Constructores_Clases_ToString__
{
    class Program
    {
        static void Main(string[] args)
        {

            Agenda amigo = new Agenda("Pedro", 30, "5546789610", "Lomas", 32);
            Console.WriteLine(amigo.ToString());

            Agenda prueba = new Agenda("Juan", 25, "34567890", "Reforma", 1324);
            Console.WriteLine(prueba.ToString());

            Agenda prueba2 = new Agenda("Marco", 12);
            Console.WriteLine(prueba2.ToString());

            Agenda prueba3 = new Agenda("Hector");
            Console.WriteLine(prueba3.ToString());


        }//Cierre de Main  

        public struct Agenda
        {
            // Clase con los parametros Definidos
            public String Nombre;
            public int Edad;
            public String Telefono;
            public Direccion Domicilio;

            // Metodo ToString() que sobreescribe la clase string . Sirve para imprimir los objetos
            // ToString para Agenda. Incluye el Domicilio el cual ya se le ha ejecutado al final de este 
            // archivo el ToString()

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Telefono: {2}", Nombre, Edad, Telefono);

                //Agregando la cadena proveniente de Domicilio
                sb.Append(Domicilio.ToString());

                return (sb.ToString());
            }

            // Primer Constructor (Agenda 5 Parametros)
            public Agenda(String pNombre, int pEdad, String pTelefono, String pCalle, int pNumero)
            {
                //Llevando a cabo la asignación
                Nombre = pNombre;
                Edad = pEdad;

                if (pTelefono.Length == 10)
                {
                    Telefono = pTelefono;
                }
                else
                {
                    Telefono = "Teléfono no es válido";
                }

                // Instanciamos el objeto Domicilio con sus atributos. Atributos que son declarados como parametros
                // en el constructor


                Domicilio = new Direccion(pCalle, pNumero); 
            }

            // 2º Constructor (Agenda 2 Parametros)

            public Agenda(String pNombre, int pEdad)
            {
                //Llevamos a cabo la asignación
                Nombre = pNombre;
                Edad = pEdad;

                // Vemos que Telefono y los atributos de Domicilio no se pasan como parametros

                Telefono = "Sin Teléfono";

                Domicilio = new Direccion("Sin dirección", 0);
            }

            // Tercer constructor (1 Argumento) . Solo se pasa el nombre como parametro
            public Agenda(String pNombre)
            {
                //Llevando a cabo la asignación del nombre
                Nombre = pNombre;

                //Pedimos la edad
                Console.Write("Dame la edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());

                //Pedimos el teléfono
                Console.Write("Dame el teléfono: ");
                Telefono = Console.ReadLine();

                if (Telefono.Length != 10)
                {
                    Telefono = "Teléfono no valido";
                }

                Domicilio = new Direccion("Sin dirección", 0);
            }

        }

        // Clase Direccion que posteriormente se utiliza enlazada con la clase Agenda
        public struct Direccion
        {
            public String Calle;
            public int Numero;

            public Direccion(String pCalle, int pNumero)
            {
                Calle = pCalle;
                Numero = pNumero;
            }

            // TO STRING PARA " Direccion "
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(", Dirección: {0} #{1}", Calle, Numero);
                return (sb.ToString());
            }
        }

    }
}