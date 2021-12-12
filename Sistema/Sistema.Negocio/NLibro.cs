using System.Data;
using Sistema.Datos;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.Listar();
        }
        public static DataTable ListarDisponible()
        {
            DLibro Datos = new DLibro();
            return Datos.ListarDisponible();
        }

        public static DataTable Buscar(string Valor, int criterio)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(Valor, criterio);
        }

        public static string Insertar(int CantidadEjemplares,string ISBN,string Titulo,string Autor,
            string Editorial, int YearEdicion, int NumeroEdicion, string Pais, string Idioma,
            string Materia, int NumeroPaginas, int Ubicacion, string Descripcion)
        {
            DLibro Datos = new DLibro();

            string Existe = Datos.Existe(ISBN);
            if (Existe.Equals("1"))
            {
                return "El libro ya existe";
            }
            else
            {
                Libro Obj = new Libro();
                Obj.CantidadEjemplares = CantidadEjemplares;
                Obj.ISBN = ISBN;
                Obj.Titulo = Titulo;
                Obj.Autor = Autor;
                Obj.Editorial = Editorial;
                Obj.YearEdicion = YearEdicion;
                Obj.NumeroEdicion = NumeroEdicion;
                Obj.Pais = Pais;
                Obj.Idioma = Idioma;
                Obj.Materia = Materia;
                Obj.NumeroPaginas = NumeroPaginas;
                Obj.Ubicacion = Ubicacion;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int IdLibro, int CantidadEjemplares,string ISBN,string ISBNAnt, string Titulo,string Autor,
            string Editorial, int YearEdicion, int NumeroEdicion, string Pais, string Idioma,
            string Materia, int NumeroPaginas, int Ubicacion, string Descripcion)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();

            if (ISBNAnt.Equals(ISBN))
            {
                Obj.IdLibro = IdLibro;
                Obj.CantidadEjemplares = CantidadEjemplares;
                Obj.ISBN = ISBN;
                Obj.Titulo = Titulo;
                Obj.Autor = Autor;
                Obj.Editorial = Editorial;
                Obj.YearEdicion = YearEdicion;
                Obj.NumeroEdicion = NumeroEdicion;
                Obj.Pais = Pais;
                Obj.Idioma = Idioma;
                Obj.Materia = Materia;
                Obj.NumeroPaginas = NumeroPaginas;
                Obj.Ubicacion = Ubicacion;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(ISBN);
                if (Existe.Equals("1"))
                {
                    return "El libro ya existe";
                }
                else
                {
                    Obj.IdLibro = IdLibro;
                    Obj.CantidadEjemplares = CantidadEjemplares;
                    Obj.ISBN = ISBN;
                    Obj.Titulo = Titulo;
                    Obj.Autor = Autor;
                    Obj.Editorial = Editorial;
                    Obj.YearEdicion = YearEdicion;
                    Obj.NumeroEdicion = NumeroEdicion;
                    Obj.Pais = Pais;
                    Obj.Idioma = Idioma;
                    Obj.Materia = Materia;
                    Obj.NumeroPaginas = NumeroPaginas;
                    Obj.Ubicacion = Ubicacion;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DLibro Datos = new DLibro();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DLibro Datos = new DLibro();
            return Datos.Desactivar(Id);
        }
    }
}
