using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_finansas_Consola
{
    internal class Cuenta
    {
        private string codigo;
        private DateTime fecha;
        private decimal monto;
        private string tipo;
        private string descripcion;
        private string asignatura;

        public string Codigo
        {
            get => codigo;
            set => codigo = (value.StartsWith("#I") || value.StartsWith("#E") || value.StartsWith("#D")) ? value : throw new ArgumentException("Ingreso de código no válido!");
        }

        public DateTime Fecha 
        { 
            get => fecha; 
            set => fecha = (value.Year > 2025 && value.Date <= DateTime.Today) ? value : throw new ArgumentException("Ingreso de fecha no inválida!"); 
        }

        public decimal Monto 
        { 
            get => monto; 
            set => monto = (value > 0.00m && decimal.TryParse(value.ToString(), out decimal x)) ? value : throw new ArgumentException("Ingreso de monto no inválida!"); 
        }

        public string Tipo 
        { 
            get => tipo; 
            set => tipo = value; 
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = (value.Length > 5) ? value : throw new ArgumentException("Ingreso de descripción no válida!");
        }

        public string Asignatura
        {
            get => asignatura;
            set => asignatura = value;
        }

        public Cuenta(string codigo, DateTime fecha, decimal monto, string tipo, string descripcion, string asignatura)
        {
            Codigo = codigo;
            Fecha = fecha;
            Monto = monto;
            Tipo = tipo;
            Descripcion = descripcion;
            Asignatura = asignatura;
        }
    }
}
