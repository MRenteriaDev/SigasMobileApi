using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CuestionarioAuditoria
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int CuestionarioId { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Cuestionario Cuestionario { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Respuesta> Respuesta { get; set; } = new List<Respuesta>();

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();
}
