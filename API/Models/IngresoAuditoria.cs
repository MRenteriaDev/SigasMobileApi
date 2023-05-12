using System;
using System.Collections.Generic;

namespace API.Models;

public partial class IngresoAuditoria
{
    public int Id { get; set; }

    public long Devengado { get; set; }

    public long Revisado { get; set; }

    public int AuditoriaId { get; set; }

    public int ObjetoId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Objeto Objeto { get; set; } = null!;
}
