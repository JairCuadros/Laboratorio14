using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio14
{
    internal class Screens
    {
        public static int[] edades = new int[1000];
        public static bool[] vacunados = new bool[1000];
        public static int contadorEncuestas = 0;
        public static int menu()
        {
            Console.Clear();
            string texto = "================================\n" +
                           "Encuesta Covid-19\n" +
                           "================================\n" +
                           "1: Realizar Encuesta\n" +
                           "2: Mostrar Datos de la encuesta\n" +
                           "3: Mostrar Resultados\n" +
                           "4: Buscar Personas por edad\n" +
                           "5: Salir\n" +
                            "================================\n";
            Operations.print(texto);
            return Operations.getEntero("Ingrese una opción: ", texto);
        }
        public static int Survey()
        {
            string texto = "===================================\n" +
                           "Encuesta de vacunación\n" +
                           "===================================";
            Operations.print(texto);
            int age = Operations.getEntero("¿Qué edad tienes?: ", "");
            Console.Clear();
            Operations.print("===================================\n" +
                             "Encuesta de vacunación\n" +
                             "===================================");
            bool CVacuno = Operations.getEntero("¿Te has vacunado?\n" +
                           "1: Sí\n" +
                           "2: No\n" +
                           "===================================\n" +
                           "Ingrese una opcion: ", "") == 1;
            edades[contadorEncuestas] = age;
            vacunados[contadorEncuestas] = CVacuno;
            contadorEncuestas++;
            Console.Clear();
            Operations.print("===================================\n" +
                             "Encuesta de vacunación\n" +
                             "===================================\n" +
                             "¡Gracias por participar!\n" +
                             "===================================\n");
            Operations.print("Presione una tecla para volver al menú...");
            Console.ReadKey();
            return menu();
        }
        public static int ShowDates()
        {
            Operations.print("===================================\n" +
                             "Datos de la encuesta\n" +
                             "===================================\n" +
                             "ID    | Edad | Vacunado\n" +
                             "=======================");
            for (int i = 0; i < contadorEncuestas; i++)
            {
                Operations.print($"{i:D4}  |  {edades[i]:D2}  |   {(vacunados[i] ? "Si" : "No")}");
            }
            Operations.print("===================================\n" +
                             "Presione una tecla para regresar ...\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }
        public static int ShowAnswers()
        {
            Operations.print("===================================\n" +
                             "Resultados de la encuesta\n" +
                             "===================================");
            int personasVacunadas = 0;
            int personasNoVacunadas = 0;
            int[] distribucionEdades = new int[6];
            for (int i = 0; i < contadorEncuestas; i++)
            {
                if (vacunados[i])
                {
                    personasVacunadas++;
                }
                else
                {
                    personasNoVacunadas++;
                }
                if (edades[i] >= 1 && edades[i] <= 20)
                {
                    distribucionEdades[0]++;
                }
                else if (edades[i] >= 21 && edades[i] <= 30)
                {
                    distribucionEdades[1]++;
                }
                else if (edades[i] >= 31 && edades[i] <= 40)
                {
                    distribucionEdades[2]++;
                }
                else if (edades[i] >= 41 && edades[i] <= 50)
                {
                    distribucionEdades[3]++;
                }
                else if (edades[i] >= 51 && edades[i] <= 60)
                {
                    distribucionEdades[4]++;
                }
                else
                {
                    distribucionEdades[5]++;
                }
            }
            Operations.print($"{personasVacunadas:D2} personas se han vacunado"+
                             $"{personasNoVacunadas:D2} personas no se han vacunado\n"+
                             "Existen:"+
                             $"{distribucionEdades[0]:D2} personas entre 01 y 20 años\n"+
                             $"{distribucionEdades[1]:D2} personas entre 21 y 30 años\n" +
                             $"{distribucionEdades[2]:D2} personas entre 31 y 40 años\n" +
                             $"{distribucionEdades[3]:D2} personas entre 41 y 50 años\n" +
                             $"{distribucionEdades[4]:D2} personas entre 51 y 60 años\n" +
                             $"{distribucionEdades[5]:D2} personas de más de 61 años\n");
            Operations.print("===================================\n" +
                             "Presione una tecla para regresar ...\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }
        public static int lookForAges()
        {
            Operations.print("================================\n" +
                             "Busca a personas por edad\n" +
                             "================================\n");
            int edadBuscada = Operations.getEntero("¿Qué edad quieres buscar?: ", "");
            int personasVacunadas = 0;
            int personasNoVacunadas = 0;
            for (int i = 0; i < contadorEncuestas; i++)
            {
                if (edades[i] == edadBuscada)
                {
                    if (vacunados[i])
                    {
                        personasVacunadas++;
                    }
                    else
                    {
                        personasNoVacunadas++;
                    }
                }
            }
            Operations.print($"{personasVacunadas:D2} se vacunaron\n"+
                             $"{personasNoVacunadas:D2} no se vacunaron\n"+
                             "================================\n" +
                             "Presione una tecla para regresar ...\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }
    }
}
