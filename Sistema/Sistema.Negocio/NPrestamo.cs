using System;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPrestamo
    {
        public static DataTable Listar()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Listar();
        }

        public static DataTable Buscar(int Valor)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(int IdUsuario,int IdLibro,string FechaPrestamo,string FechaDevolucion)
        {
            DPrestamo Datos = new DPrestamo();

            Prestamo Obj = new Prestamo();
            Obj.IdUsuario = IdUsuario;
            Obj.IdLibro = IdLibro;
            Obj.FechaPrestamo = Convert.ToDateTime(FechaPrestamo);
            Obj.FechaDevolucion = Convert.ToDateTime(FechaDevolucion);
            return Datos.Insertar(Obj);
        }

        public static string Eliminar(int Id)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Eliminar(Id);
        }
    }
}
