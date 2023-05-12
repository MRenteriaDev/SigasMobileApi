using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AccionesTipoRubrica
{
    public int Id { get; set; }

    public int AccionesId { get; set; }

    public int TipoRubricaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Accione Acciones { get; set; } = null!;

    public virtual TipoRubrica TipoRubrica { get; set; } = null!;
}
