using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusObservacion
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public bool Autorizado { get; set; }

    public int ObservacionId { get; set; }

    public int StatusId { get; set; }

    public virtual Observacione Observacion { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
