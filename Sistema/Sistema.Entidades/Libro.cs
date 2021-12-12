namespace Sistema.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public int CantidadEjemplares { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int YearEdicion { get; set; }
        public int NumeroEdicion { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Materia { get; set; }
        public int NumeroPaginas { get; set; }
        public int Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
