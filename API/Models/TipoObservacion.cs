using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoObservacion
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Plural { get; set; }

    public int VencimientodeCampo { get; set; }

    public int VencimientodeGabinete { get; set; }

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();
}
