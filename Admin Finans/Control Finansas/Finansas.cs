using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Finans.Ingresos;
using Mis_finansas_Consola.General;
using Microsoft.VisualBasic;
using System.Data;

namespace Mis_finansas_Consola
{
    internal class Finansas
    {
        private string conexion = "Data Source = Finansas.db";
        private string sql;

        // Crear Tablas

        public void CrearTablas()
        {
            using (SqliteConnection ct = new SqliteConnection(conexion))
            {
                ct.Open();
                sql = @"CREATE TABLE IF NOT EXISTS  Ingresos(Codigo TEXT PRIMARY KEY, Fecha TEXT NOT NULL, Monto REAL NOT NULL, 
                        Tipo TEXT NOT NULL, Descripcion TEXT NOT NULL, Asignatura TEXT NOT NULL);";
                using (SqliteCommand crear = new SqliteCommand(sql, ct))
                {
                    crear.ExecuteNonQuery();
                }

                sql = @"CREATE TABLE IF NOT EXISTS  Egresos(Codigo TEXT PRIMARY KEY, Fecha TEXT NOT NULL, Monto REAL NOT NULL, 
                        Tipo TEXT NOT NULL, Descripcion TEXT NOT NULL, Asignatura TEXT NOT NULL);";
                using (SqliteCommand crear = new SqliteCommand(sql, ct))
                {
                    crear.ExecuteNonQuery();
                }

                sql = @"CREATE TABLE IF NOT EXISTS Global(Codigo INTEGER PRIMARY KEY, Nombre TEXT NOT NULL, Valor TEXT NOT NULL);";
                using (SqliteCommand crear = new SqliteCommand(sql, ct))
                {
                    crear.ExecuteNonQuery();
                }
            }
        }

        // Ingreso

        public void AgregarTransaccion(Transacciones datos, string tipo)
        {
            if (tipo == "Ingreso")
                sql = "INSERT INTO Ingresos(Codigo, Fecha, Monto, Tipo, Descripcion, Asignatura) " +
                       "VALUES(@codigo, @fecha, @monto, @tipo, @descripcion, @asignatura);";
            else if (tipo == "Egreso")
                sql = "INSERT INTO Egresos(Codigo, Fecha, Monto, Tipo, Descripcion, Asignatura) " +
                      "VALUES(@codigo, @fecha, @monto, @tipo, @descripcion, @asignatura);";
            else
                MessageBox.Show("Error Tabla no existente!");
            using (SqliteConnection at = new SqliteConnection(conexion))
            {
                at.Open();

                using (SqliteCommand agregar = new SqliteCommand(sql, at))
                {
                    agregar.Parameters.AddWithValue("@codigo", datos.Codigo);
                    agregar.Parameters.AddWithValue("@fecha", datos.Fecha);
                    agregar.Parameters.AddWithValue("@monto", datos.Monto);
                    agregar.Parameters.AddWithValue("@tipo", datos.Tipo);
                    agregar.Parameters.AddWithValue("@descripcion", datos.Descripcion);
                    agregar.Parameters.AddWithValue("@asignatura", datos.Asignatura);
                    agregar.ExecuteNonQuery();
                }
            }
        }

        //Mostrar Datos

        public DataTable MostarDatos(string tipo)
        {
            DataTable tabla = new DataTable();
            if (tipo == "Ingreso")
                sql = "SELECT Codigo, Fecha, Monto, Tipo, Descripcion, Asignatura FROM Ingresos";
            else if (tipo == "Egreso")
                sql = "SELECT Codigo, Fecha, Monto, Tipo, Descripcion, Asignatura FROM Egresos";
            else
                MessageBox.Show("Error Tabla no existente!");
            using (SqliteConnection md = new SqliteConnection(conexion))
            {
                md.Open();
                using (SqliteCommand datos = new SqliteCommand(sql,md))
                {
                    using (SqliteDataReader mostrar = datos.ExecuteReader())
                    {
                        tabla.Load(mostrar);
                    }
                }
            }
            return tabla;
        }

    }
}
