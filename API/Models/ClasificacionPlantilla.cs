using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ClasificacionPlantilla
{
    public int Id { get; set; }

    public int ClasificacionId { get; set; }

    public int PlantillaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Clasificacion Clasificacion { get; set; } = null!;

    public virtual Plantilla Plantilla { get; set; } = null!;
}
