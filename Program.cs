using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULOSSWICH
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.Title = "TRABAJANDO CON PROCEDIMIENTOS"; // colocamos el titulo
            asteriscos('*'); // llamando procedimiento asteriscos 
            Console.WriteLine(); // saltamos linea
            //entrada del usuario 
            Console.WriteLine("   INGRESE SU NOMBRE ");//pedir al usuario que ingrese su nombre
            asteriscos('*'); // llamando procedimiento asteriscos 
            Console.WriteLine(); // saltamos linea
            string nombre = Console.ReadLine();//leer datos
            Console.WriteLine("HOLA " + nombre + " BIENVENIDO AMI CALCULADORA ");
            //entrada bucle
            bool continuar = true;// variable para controlar el bucle while lo inicialisamos como verdadero oo true
            while(continuar)
            { //inicio del bucle while
            // Menú principal
            Console.WriteLine("   seleccione una operacion ");//seleccionamos una oopcion 
            asteriscos('*'); // llamando procedimiento asteriscos 
            Console.WriteLine(); // saltamos linea
            Console.WriteLine("1.  Sumar");//opcion sumar
            Console.WriteLine("2.  Resta");//opcion restar
            Console.WriteLine("3.  multiplicacion");// opcion multiplicacion
            Console.WriteLine("4.  division");// opcion division
            Console.WriteLine("5.  mayor de tres numeros");//opcion mayor de tres numeros
            Console.WriteLine("6.  area de un triangulo");//opcion calcular el area de un triangulo
            Console.WriteLine("7.  volumen de una esfera");//opcion calcular volumen de una esfera
            Console.WriteLine("8.  Par o Impar");//opcion par o inpar
            Console.WriteLine("9.  secuencia de fibonacci");//opcion secuencia fibonacci
            Console.WriteLine("10. area de un cuadrado");//opcion  area de un cuadrado 
            Console.WriteLine("11. invertir numero");//opcion invertir numeroo
            Console.WriteLine("12. arreglos");//opcion arreglos 
            Console.WriteLine("13. promedio de tres cursos ");//opcion nota de dos alumnos 
            Console.WriteLine("14. promedio de Nnotas ");
            Console.WriteLine("15. salir");
            Console.WriteLine("    Ingrese el numero de la opcion deseada:");//seleccione una opcion 
            string opcion = Console.ReadLine();//leer datos 
                switch (opcion)
                {//inicio de la centecia condicional switch case
                    case "1":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO SUMAR");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        suma(); // llamando procedimiento sumar
                        break;
                    case "2":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO RESTA");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        resta(); // llamando procedimiento resta
                        break;
                    case "3":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO MULTIPLICACION");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        multiplicacion(); // llamando procedimiento multiplicacion
                        break;
                    case "4":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO DIVISION");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        division(); // llamando procedimiento division
                        break;
                    case "5":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO MAYOR DE TRES NUMEROS");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        mayor(); // llamando procedimiento mayor
                        break;
                    case "6":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO AREA DE UN TRIANGULO");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        areatriangulo(); // llamando procedimiento  area de un triangulo
                        break;
                    case "7":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO VOLUMEN DE UNA ESFERA");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        volumen(); // llamando procedimiento volumen de una esfera
                        break;
                    case "8":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO PAR O INPAR");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        par(); // llamando procedimiento par
                        break;
                    case "9":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO  SECUENCIA DE FIBONACCI ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        fibonacci(); // llamando procedimiento secuencia de fibonaci 
                        break;
                    case "10":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO AREA DE UN CUADRADO  ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        areacuadrado(); // llamando procedimiento area de un cuadrado
                        break;
                    case "11":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO INVERTIR NUMEROS  ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        invertir(); // llamando procedimiento invertir numeros
                        break;
                    case "12":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO ARREGLOS O ARRAYS ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        arreglos(); // llamando procedimiento arreglos
                        break;
                    case "13":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO PROMEDIO ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        promedio(); // llamando procedimiento promedios
                        break;
                    case "14":
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Console.WriteLine("  PROCEDIMIENTO PROMEDIO DE Nnotas ");
                        asteriscos('*'); // llamando procedimiento asteriscos 
                        Console.WriteLine(); // saltamos linea
                        Nnotas(); // llamando procedimiento  Nnotas
                        break;
                    case "15":
                        continuar = false; //Cambiar la variable a false para salir del bucle while....
                        Console.WriteLine("ssaliendo de la calculadora ¡hasta luego!");
                        break;
                        
                    default:
                        Console.WriteLine("opcion no valida.");
                        break;
                }// fin...............................................
                Console.WriteLine(); // saltamos linea
                Console.WriteLine(" ¿Deseas realizar otra operacion mass? (s/n)");//escribir s/n 
                string respuesta = Console.ReadLine().ToLower();//leer datos 
                if (respuesta != "s")
                {
                    continuar = false; // salir del bucle si la respuesta no es S
                }
                Console.Clear(); // limpiamos pantalla 
            }//fin del bucle while
            Console.ReadKey(); // le damos una pausa 
            Console.Clear(); // limpiamos pantalla 
        }//fin

        static void suma()
        {
            // inicio
            // declarar variables
            double n1, n2, resultado;
            // leer datos 
            Console.WriteLine("Ingrese el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            // calcular la suma de los números
            resultado = n1 + n2;
            // escribir resultado
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }//fin

        static void resta()
        {
            // inicio
            // declarar variables
            double n1, n2, resultado;
            // leer datos 
            Console.WriteLine("Ingrese el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            // calcular la resta de los números
            resultado = n1 - n2;
            // escribir resultado
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }//fin

        static void multiplicacion()
        {
            // inicio
            // declarar variables
            double n1, n2, resultado;
            // leer datos 
            Console.WriteLine("Ingrese el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            // calcular la multiplicacion de los números
            resultado = n1 * n2;
            // escribir resultado
            Console.WriteLine("El resultado de la mulplicacion  es: " + resultado);
        }//fin

        static void division()
        {
            // inicio
            // declarar variables
            double n1, n2, resultado;
            // leer datos 
            Console.WriteLine("Ingrese el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            // calcular la division de los números
            resultado = n1 / n2;
            // escribir resultado
            Console.WriteLine("El resultado de la division  es: " + resultado);
        }//fin

        static void mayor()
        {
            // inicio
            // declarar variables
            double n1, n2, n3, mayor; ;
            // leer datos 
            Console.WriteLine("Ingrese el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            n3 = double.Parse(Console.ReadLine());
            // calcular el mayor de los números
            if(n1>n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }
            if(mayor<n3)
            {
                mayor = n3;
            }
            else
            {
                n3= mayor;
            }
            // escribir resultado
            Console.WriteLine("El numero mayor es: " + mayor);
        }//fin

        static void areatriangulo()
        {
            // inicio
            // declarar variables
            double Base, altura, area;
            // leer datos 
            Console.WriteLine("Ingrese  la base del triangulo:");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo:");
            altura = double.Parse(Console.ReadLine());
            // calcular el area del triangulo 
            area = (Base*  altura)/2;
            // escribir resultado
            Console.WriteLine("El  area del triangulo es: " + area);
        }//fin

        static void volumen()
        {
            // inicio
            // declarar variables
            double radio,volumen;
            // leer datos 
            Console.WriteLine("Ingrese el radio de la esfera:");
            radio = double.Parse(Console.ReadLine());    
            // calcular el volumen de la esfera
            volumen = (4/3.0)*Math.PI*Math.Pow(radio,3);
            // escribir resultado
            Console.WriteLine("El volumen de la esfera es: " + volumen);
        }//fin

        public static void asteriscos(char k)
        {//inicio
            // declarar variables 
            int i; // contador
                   // generar asteriscos 
            for (i = 0; i < 30; i++) // para i desde cero 
            {
                Console.Write(k);
            }
        }//finn

        public static void par()
        {
            // inicio
            // declarar variables
            int num1;
            // leer datos 
            Console.WriteLine("Ingrese el número:");
            num1 = int.Parse(Console.ReadLine());

            // calcular si el número es par o impar
            if (num1 % 2 == 0)
            {
                Console.WriteLine("El número " + num1 + " es par");
            }
            else
            {
                Console.WriteLine("El número " + num1 + " es impar");
            }
            Console.ReadKey();//le damos una pausa
        }//fin

        public static void fibonacci()
        {// inicio 
            //declarar variables 
            int n;
            //leer datos 
            Console.Write("ingrese el nmero de terminos de la secuencia de fibonacci: ");
            n = int.Parse(Console.ReadLine());

            // inicializamos los primerosterminos 
            long a = 0, b = 1;//a como 0 y b como 1  

            Console.WriteLine("Secuencia de fibonacci:");
            for (int i = 0; i < n; i++)//ste ciclo se repite n veces i empieza en 0 y se incrementa en 1 en cada repetición hasta que lleggue a n
            {
                Console.WriteLine(a);//aqui estamos mostrando en la pantalla el número actual de la secuencia que al principio es 0
                long temp = a;//guardamos el número actual (a) en una variable llamada temp esto es para que podamos usarlo más tarde
                a = b;
                b = temp + b; 
            }
        }//fin
        static void areacuadrado()
        {
            // inicio
            // declarar variables
            double lado, area;
            // leer datos 
            Console.WriteLine("Ingrese  un  lado del cuadrado :");
            lado = double.Parse(Console.ReadLine());

            // calcular el area del triangulo 
            area = Math.Pow(lado , 2);
            // escribir resultado
            Console.WriteLine("El  area del  cuadrado es: " + area);
        }//fin
        static void invertir()
        {
            // inicio
            // declarar variables
            int n1, dijito;
            // leer datos 
            Console.WriteLine("ingrese el numero:");
            n1 = int.Parse(Console.ReadLine());
            int numinvertido = 0;//inicalizamos el numeroinvertido en 0
            // calcular la division de los númerostyy
           while(n1>0)
            {
                dijito = n1 % 10;//obtener el ultimoo  numero
                numinvertido = numinvertido * 10 + dijito;//agregar al numero invertido 
                n1 /= 10;//eliminar el ultimo dijito del numero original 
            }
            // escribir resultado
            Console.WriteLine("el numero invertido es:" + numinvertido);
        }//fin 
        static void arreglos()
        {
            // inicio
            // declarar variables
            string[] alumnos = new string[5];//puede almacenar hasta 5 nombres de alumnos
            int[] notasfinales = new int[5];//puede almacenar hasta 5 notasfinales
            //resolver el arreglo
            for (int a = 0; a < alumnos.Length; a++)
            {
                Console.WriteLine($"Ingrese el nombre del {0}ª alumno", a+1);
                alumnos[a] = Console.ReadLine();
                Console.WriteLine("Ingrese su nota final");
                notasfinales[a] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            Console.WriteLine("resulatados: ");
            for(int a = 0; a < alumnos.Length; a++)
            {
                Console.WriteLine($"Nombre==> {0}, Nota==> {1}", alumnos[a], notasfinales[a]);
            }
            Console.ReadKey();
        }//fin 
        static void promedio()
        {
            //inicio
            //declarar variables
            double n1 = 1, n2 = 2, n3 = 3;//entrada
            double promedio;//salida
            //leer datos 
            n1 = LeerNota(n1);
            n2 = LeerNota(n2);
            n3 = LeerNota(n3);
            //calculaer promedio y estado del alumno
            promedio = (n1 + n2 + n3) / 3;
            string estado = Console.ReadLine();
            if (promedio>10)
            {
                estado = "aprobado";
            }
            else
            {
                estado = "desaprobado";
            }
            //escribir resultado
            Console.WriteLine("El promedio de las 3 notas es==> " + Math.Round(promedio) );
            Console.WriteLine("i el estado  de alumno es==> " + estado);
            Console.ReadLine();

        }//fin
        static int LeerNota(double k)
        {//inicio
            //DECLARAR VARIABLES
            int n;
            //leemos variables
            do
            {
                Console.Write("ingrese la nota "  +  k  +  " entre 0 y 20: ");//ingresamos la notan
                n = int.Parse(Console.ReadLine());//leeer nota
            } while (n < 0 || n > 20);
            return n;
            
         }//fin 
        static void Nnotas()
        {//inicio
            //declarar variables
            int k = 0;// contador 
            double suma = 0;
            double Nnotas;//entrada dew datos 
            double notaBaja = 21, notaAlta = -1, promedio;
            double notaAprobada = 0, notaDesaprobada = 0, notaReprobada = 0;
            //leer variables
            Console.WriteLine("ingrese el numero de las notas: ");//entrada de datos
            int totalnotas = int.Parse(Console.ReadLine());//salida 
            // calcular notas
            while (k < totalnotas)
            {//inicio bucle principal
                
                Console.WriteLine($"ingrese la nota: {k + 1} (entre 0 y 20)");//entrada
                Nnotas = Convert.ToDouble(Console.ReadLine());//salida
                //bucle para controlar el rango de los numero entre 0 y 20
                while (Nnotas < 0 || Nnotas > 20)
                {//inicio bucle
                    Console.WriteLine("Nota inválida. Por favor ingrese una nota entre 0 y 20:");//entrada
                    Nnotas = Convert.ToDouble(Console.ReadLine());//salida
                }//fin bucle
                //calcular la nota mas baja 
                if (Nnotas < notaBaja)
                {
                    notaBaja = Nnotas;
                }
                //calcular nota mas alta
                if (Nnotas > notaAlta)
                {
                    notaAlta = Nnotas;
                }
                //sumar nota para calcular el promedio
                suma += Nnotas;
                //contar notas aprobadas y desaprobados
                if (Nnotas >= 10)
                {
                    notaAprobada++;
                }
                else
                {
                    notaDesaprobada++;
                }
                //contas notas reprobadas
                if (Nnotas < 8)
                {
                    notaReprobada++;
                }
                k++;//incrementamos el contador hasta que k sea igual al numero dijitado
            }//fin bucle principal
            //calcular promedio
            promedio = suma / k;
            // Mostrar resultados
            Console.WriteLine($"Nota más baja: {notaBaja}");
            Console.WriteLine($"Nota más alta: {notaAlta}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Notas aprobadas: {notaAprobada}");
            Console.WriteLine($"Notas desaprobadas: {notaDesaprobada}");
            Console.WriteLine($"Notas reprobadas: {notaReprobada}");
            Console.ReadLine();
        }//fin 
    }
}
