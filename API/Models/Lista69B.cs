using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Lista69B
{
    public int Id { get; set; }

    public DateTime FechaSat { get; set; }

    public string? Archivo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Lista69Bdetalle> Lista69Bdetalles { get; set; } = new List<Lista69Bdetalle>();
}
