using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Equipo
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int AreaId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<EquipoAuditoria> EquipoAuditoria { get; set; } = new List<EquipoAuditoria>();

    public virtual ICollection<EquipoAuditor> EquipoAuditors { get; set; } = new List<EquipoAuditor>();
}
