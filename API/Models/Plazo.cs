using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Plazo
{
    public int Id { get; set; }

    public int ObservacionId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Observacione Observacion { get; set; } = null!;
}
