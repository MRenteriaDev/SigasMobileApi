using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CriterioAuditoria
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int ClasificacionId { get; set; }

    public int PonderacionId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? PonderacionId1 { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Clasificacion Clasificacion { get; set; } = null!;

    public virtual Ponderacion Ponderacion { get; set; } = null!;

    public virtual Ponderacion? PonderacionId1Navigation { get; set; }
}
