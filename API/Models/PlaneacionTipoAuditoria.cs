using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PlaneacionTipoAuditoria
{
    public int Id { get; set; }

    public int TipoAuditoriaId { get; set; }

    public int PlaneacionId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public virtual Planeacion Planeacion { get; set; } = null!;

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;
}
