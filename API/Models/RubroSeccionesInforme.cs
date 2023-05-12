using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RubroSeccionesInforme
{
    public int Id { get; set; }

    public int SeccionesInformesId { get; set; }

    public int RubroId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int Orden { get; set; }

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual SeccionesInforme SeccionesInformes { get; set; } = null!;
}
