using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EquipoAuditoria
{
    public int Id { get; set; }

    public int EquipoId { get; set; }

    public int AuditoriaId { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Equipo Equipo { get; set; } = null!;
}
