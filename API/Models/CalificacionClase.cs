using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CalificacionClase
{
    public int Id { get; set; }

    public int TipoAuditoriaId { get; set; }

    public int TipoClasificacionId { get; set; }

    public int? PonderacionId { get; set; }

    public int CalificacionesGlobalesId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int Ponderacion { get; set; }

    public double PonderacionObtenida { get; set; }

    public virtual ICollection<CalificacionCriterio> CalificacionCriterios { get; set; } = new List<CalificacionCriterio>();

    public virtual CalificacionesGlobale CalificacionesGlobales { get; set; } = null!;

    public virtual Ponderacion? PonderacionNavigation { get; set; }

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual TipoClasificacion TipoClasificacion { get; set; } = null!;
}
