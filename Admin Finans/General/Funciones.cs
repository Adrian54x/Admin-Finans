using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mis_finansas_Consola.General
{
    internal class Funciones
    {
        //Funciones Basicas

        public int Rango(int inicio, int fin, int pocicionX, int pocicionY, int pocicionE)
        {
            int numero;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out numero) && numero >= inicio && numero <= fin)
                    return numero;
            }
        }

        public string ValidarTexto(int cantidadMinimaCaracters, int pocicionX, int pocicionY)
        {
            while (true)
            {
                string texto = Console.ReadLine();
                if (texto.Length >= cantidadMinimaCaracters)
                    return texto;
            }
        }

        public bool SIoNO(int pocicionX, int pocicionY)
        {
            string SioNo;
            bool SIoNO = false;
            while (true)
            {
                SioNo = Console.ReadLine();
                if (string.Equals(SioNo, "si", StringComparison.OrdinalIgnoreCase) || string.Equals(SioNo, "no", StringComparison.OrdinalIgnoreCase))
                {
                    return SIoNO;
                }
            }
        }


        public void EscribirTexto(ConsoleColor color, string texto, bool Line, int pocicionX, int pocicionY)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(pocicionX, pocicionY);
            Console.ForegroundColor = color;
            if (Line)
                Console.WriteLine(texto);
            else
                Console.Write(texto);
            Console.ResetColor();
            Console.CursorVisible = true;
        }

        public uint ValidarEnterosPositivos(int pocicionX, int pocicionY)
        {
            uint entero;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out entero))
                    return entero;
            }
        }


        // Opciones de agregar

        public string GeneradorCodigos(uint codigoActual)
        {
            return "0" + (codigoActual + 1).ToString();
        }

        public DateTime ValidarFecha(int pocicionX, int pocicionY)
        {
            DateTime fecha;
            while(true)
            {
                if(DateTime.TryParse(Console.ReadLine(), out fecha) && fecha.Year > 2025 && fecha.Date <= DateTime.Today)
                    return fecha;
            }
        }

        public decimal ValidarCantidad(int pocicionX, int pocicionY)
        {
            decimal cantidad;
            while (true)
            {
                if(decimal.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0.00m)
                    return cantidad;
            }
        }

        public Crear AgregarFinanza(string categoria)
        {
                return null;
        }

        

    }
}
