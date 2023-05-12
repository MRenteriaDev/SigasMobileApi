using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Area
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string ClaveArea { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Nombre { get; set; } = null!;

    public int? AuditorId { get; set; }

    public virtual Auditor? Auditor { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual ICollection<StatusArea> StatusAreas { get; set; } = new List<StatusArea>();

    public virtual ICollection<UnidadAdministrativa> UnidadAdministrativas { get; set; } = new List<UnidadAdministrativa>();
}
