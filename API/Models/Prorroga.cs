using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Prorroga
{
    public int Id { get; set; }

    public int Dias { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();
}
