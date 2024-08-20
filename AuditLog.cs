using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectorioDeArchivos.Shared;

[Table("AuditLogs")]
public class AuditLog
{
    [Key] public int Id { get; set; }

    [Required] public DateTime Timestamp { get; set; }

    [Required] [MaxLength(100)] public string Accion { get; set; }

    [MaxLength(50)] public string? IdUsuario { get; set; }

    [MaxLength(100)] public string? NombreUsuario { get; set; }

    [Required] [MaxLength(100)] public string NombreTabla { get; set; }

    [Required] public string ClavesPrimarias { get; set; }

    public string? ValoresAntiguos { get; set; }

    public string? ValoresNuevos { get; set; }
}