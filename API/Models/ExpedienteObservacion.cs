using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ExpedienteObservacion
{
    public int Id { get; set; }

    public int ExpedienteId { get; set; }

    public int ObservacionId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Expediente Expediente { get; set; } = null!;

    public virtual Observacione Observacion { get; set; } = null!;
}
