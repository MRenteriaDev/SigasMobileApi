using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EquipoAuditor
{
    public int Id { get; set; }

    public string? Cargo { get; set; }

    public int EquipoId { get; set; }

    public int AuditorId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual Equipo Equipo { get; set; } = null!;
}
