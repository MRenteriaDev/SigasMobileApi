using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusAuditoria
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<StatusAuditoriaAuditoria> StatusAuditoriaAuditoria { get; set; } = new List<StatusAuditoriaAuditoria>();
}
