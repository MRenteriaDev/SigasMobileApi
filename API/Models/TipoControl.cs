using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoControl
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public bool Gabinete { get; set; }

    public bool FechaLimite { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int Dias { get; set; }

    public virtual ICollection<FechaControl> FechaControls { get; set; } = new List<FechaControl>();
}
