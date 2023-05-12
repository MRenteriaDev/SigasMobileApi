using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ImportesAuditoria
{
    public int Id { get; set; }

    public long ImporteObservadoDano { get; set; }

    public long ImporteSolventadoDano { get; set; }

    public long ImportePorSolventarDano { get; set; }

    public long Devengado { get; set; }

    public long ImporteObservado { get; set; }

    public long ImporteSolventado { get; set; }

    public long ImportePorSolventar { get; set; }

    public int CalificacionId { get; set; }

    public int AuditoriaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? CalificacionId1 { get; set; }

    public int TotalObservaciones { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Calificacion Calificacion { get; set; } = null!;

    public virtual Calificacion? CalificacionId1Navigation { get; set; }
}
