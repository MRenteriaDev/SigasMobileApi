using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PagoSancion
{
    public int Id { get; set; }

    public int SancionId { get; set; }

    public DateTime FechaPago { get; set; }

    public double ImportePago { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Sancion Sancion { get; set; } = null!;
}
