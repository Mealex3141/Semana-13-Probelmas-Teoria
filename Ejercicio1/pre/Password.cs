using System;
using System.Collections.Generic;
using System.Text;

namespace pre
{
    internal class Password
    {
        private int longitud;
        private string contraseña;

        public Password()
        {
            longitud = 8;
            contraseña = "12345678";
        }

        public int getLongitud()
        {
            return longitud;
        }

        public string getContraseña()
        {
            return contraseña;
        }

        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public void generarPassword()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            contraseña = "";

            for (int i = 0; i < longitud; i++)
            {
                int posicion = random.Next(caracteres.Length);

                contraseña += caracteres[posicion];
            }
        }

        public bool esFuerte()
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            foreach (char caracter in contraseña)
            {
                if (char.IsUpper(caracter))
                {
                    mayusculas++;
                }
                else if (char.IsLower(caracter))
                {
                    minusculas++;
                }
                else if (char.IsDigit(caracter))
                {
                    numeros++;
                }
            }

            return mayusculas > 2 && minusculas > 1 && numeros > 5;
        }
    }
}
