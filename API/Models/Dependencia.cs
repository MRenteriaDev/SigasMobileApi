using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Dependencia
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual Ente Ente { get; set; } = null!;

    public virtual ICollection<Meta> Meta { get; set; } = new List<Meta>();
}
