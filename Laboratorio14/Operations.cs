using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio14
{
    internal class Operations
    {
            public static int getEntero(string prefijo, string reemplazo)
            {
                int respuesta = 0;
                bool correcto = false;
                do
                {
                    string numeroTexto = getTextoPantalla(prefijo);
                    correcto = int.TryParse(numeroTexto, out respuesta);
                    if (!correcto)
                    {
                        Console.Clear();
                        print(reemplazo);
                        print("Ingresa un número válido");
                    }
                } while (!correcto);
                return respuesta;
            }
            public static float getDecimal(string prefijo)
            {
                float respuesta = 0;
                bool correcto = false;
                do
                {
                    string numeroTexto = getTextoPantalla(prefijo);
                    correcto = float.TryParse(numeroTexto, out respuesta);
                    if (!correcto)
                    {
                        print("Ingresa un número válido");
                    }
                } while (!correcto);
                return respuesta;
            }
            public static string getTextoPantalla(string prefijo)
            {
                print(prefijo);
                return Console.ReadLine();
            }
        public static void print(string text)
        {
            Console.WriteLine(text);
        }
    }
}

