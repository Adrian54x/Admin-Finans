using Mis_finansas_Consola;
using Mis_finansas_Consola.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace Admin_Finans.Ingresos
{
    internal class Transacciones : Crear
    {
        private string tipo;
        private string descripcion;
        private string asignatura;

        public string Tipo
        {
            get => tipo;
            set => tipo = (DatosGlobales.tipo.Contains(value)) ? value : throw new ArgumentException("Error de ingreso de tipo!");
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = (value.Length > 5) ? value : throw new ArgumentException("Error de ingreso de descripción!");    
        }

        public string Asignatura
        {
            get => asignatura;
            set => asignatura = (DatosGlobales.asignatuaIngreso.Contains(value) || DatosGlobales.asignatuaEgreso.Contains(value)) ? value : throw new ArgumentException("Error de ingreso de asignatura!");
        }

        public Transacciones(string codigo, DateTime fecha, decimal monto, string tipo, string descripcion, string asignatura) : base(codigo, fecha, monto, tipo, descripcion, asignatura)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            Asignatura = asignatura;
        }
    }
}
