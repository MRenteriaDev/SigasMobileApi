using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ModoEjecucion
{
    public int Id { get; set; }

    public string Clave { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();
}
