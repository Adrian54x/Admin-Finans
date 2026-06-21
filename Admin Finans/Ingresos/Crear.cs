using Mis_finansas_Consola.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_finansas_Consola
{
    internal abstract class Crear
    {
        private string codigo;
        private DateTime fecha;
        private decimal monto;

        public string Codigo
        {
            get => codigo;
            set => codigo = (value.StartsWith("#I") || value.StartsWith("#E") || value.StartsWith("#D") || value.StartsWith("#P")) ? value : throw new ArgumentException("Error de ingreso de código!");
        }

        public DateTime Fecha 
        { 
            get => fecha; 
            set => fecha = (value.Year > 2025 && value.Date <= DateTime.Today) ? value : throw new ArgumentException("Error de ingreso de fecha!"); 
        }

        public decimal Monto 
        { 
            get => monto; 
            set => monto = (value > 0.00m && decimal.TryParse(value.ToString(), out decimal x)) ? value : throw new ArgumentException("Error de ingreso de monto!"); 
        }
        public Crear(string codigo, DateTime fecha, decimal monto, string tipo, string descripcion, string asignatura)
        {
            Codigo = codigo;
            Fecha = fecha;
            Monto = monto;
        }
    }
}
