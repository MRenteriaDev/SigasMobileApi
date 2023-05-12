using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ImporteObservacione
{
    public int Id { get; set; }

    public int Importe { get; set; }

    public int ObservacionesId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Observacione Observaciones { get; set; } = null!;
}
