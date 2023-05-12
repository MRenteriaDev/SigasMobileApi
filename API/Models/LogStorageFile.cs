using System;
using System.Collections.Generic;

namespace API.Models;

public partial class LogStorageFile
{
    public int Id { get; set; }

    public string? UsuarioId { get; set; }

    public int AuditoriasId { get; set; }

    public string? Nombre { get; set; }

    public string? Accion { get; set; }

    public bool IsFolder { get; set; }

    public DateTime Fecha { get; set; }

    public int ElementoId { get; set; }

    public virtual Auditoria Auditorias { get; set; } = null!;

    public virtual User? Usuario { get; set; }
}
