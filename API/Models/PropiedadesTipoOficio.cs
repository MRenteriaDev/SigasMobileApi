using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PropiedadesTipoOficio
{
    public int Id { get; set; }

    public int TipoOficioId { get; set; }

    public string? Propiedad { get; set; }

    public string? TipoDato { get; set; }

    public bool Requerido { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CampoTabla { get; set; }

    public virtual TipoOficio TipoOficio { get; set; } = null!;
}
