using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CriteriosAcreditado
{
    public int Id { get; set; }

    public int? ObservacionId { get; set; }

    public int ClasificacionId { get; set; }

    public string? Codigo { get; set; }

    public string? NoObservacion { get; set; }

    public string? Criterio { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Acreditado { get; set; }

    public int NumeroCriterios { get; set; }

    public double PonderacionTipoAuditoria { get; set; }

    public double CalificacionTipoAuditoria { get; set; }

    public int EnteId { get; set; }

    public virtual Clasificacion Clasificacion { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Observacione? Observacion { get; set; }
}
