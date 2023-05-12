using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FechaControl
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int TipoControlId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public int? AuditoriasId { get; set; }

    public int Dias { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Auditoria? Auditorias { get; set; }

    public virtual TipoControl TipoControl { get; set; } = null!;
}
