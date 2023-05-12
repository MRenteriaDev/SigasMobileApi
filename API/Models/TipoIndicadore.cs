using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoIndicadore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Simbolo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();
}
