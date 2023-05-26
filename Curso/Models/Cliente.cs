namespace Curso.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? cuil { get; set; }
        public string? tipoDocumento { get; set; }
        public int nroDocuemnto { get; set; }    
        public Boolean esEmpleado { get; set; }
        public string? paisOrigen { get; set; }
 
    }
}
