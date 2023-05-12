using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusAuditoriaAuditoria
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public int AuditoriaId { get; set; }

    public int StatusAuditoriaId { get; set; }

    public string? Motivo { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual StatusAuditoria StatusAuditoria { get; set; } = null!;
}
