using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Dias { get; set; }

    public string? Color { get; set; }

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual ICollection<StatusArea> StatusAreas { get; set; } = new List<StatusArea>();

    public virtual ICollection<StatusObservacion> StatusObservacions { get; set; } = new List<StatusObservacion>();
}
