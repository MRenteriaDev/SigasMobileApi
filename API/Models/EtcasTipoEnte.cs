using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EtcasTipoEnte
{
    public int Id { get; set; }

    public int TipoEnteId { get; set; }

    public int EtcasId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Etca Etcas { get; set; } = null!;

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
