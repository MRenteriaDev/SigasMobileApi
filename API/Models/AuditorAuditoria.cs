using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AuditorAuditoria
{
    public int Id { get; set; }

    public string? Cargo { get; set; }

    public int AuditoriaId { get; set; }

    public int AuditorId { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public int? OficioComisionId { get; set; }

    public int? OficioNotificacionId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Oficio? OficioComision { get; set; }

    public virtual Oficio? OficioNotificacion { get; set; }
}
