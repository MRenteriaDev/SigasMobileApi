using System;
using System.Collections.Generic;

namespace API.Models;

public partial class GastoAuditoria
{
    public int Id { get; set; }

    public long? Revisado { get; set; }

    public int GastoId { get; set; }

    public int AuditoriaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int RevisionId { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Gasto Gasto { get; set; } = null!;

    public virtual Revisione Revision { get; set; } = null!;
}
