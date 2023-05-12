using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CalificacionCriterio
{
    public int Id { get; set; }

    public int ObservacionId { get; set; }

    public int AuditoriaId { get; set; }

    public int Codigo { get; set; }

    public int ClasificacionId { get; set; }

    public int CalificacionClasesId { get; set; }

    public string? NoObservacion { get; set; }

    public string? ClasificacionNombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual CalificacionClase CalificacionClases { get; set; } = null!;
}
