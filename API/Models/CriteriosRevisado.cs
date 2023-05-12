using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CriteriosRevisado
{
    public int Id { get; set; }

    public int Total { get; set; }

    public int? EntesId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoEnteId { get; set; }

    public int TipoClasificacionId { get; set; }

    public bool? Mayor25000 { get; set; }

    public virtual Ente? Entes { get; set; }

    public virtual TipoClasificacion TipoClasificacion { get; set; } = null!;

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
