using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoClasificacion
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TipoAuditoriaId { get; set; }

    public float? Ponderacion { get; set; }

    public string? NombreHomologado { get; set; }

    public string? Ambito { get; set; }

    public virtual ICollection<CalificacionClase> CalificacionClases { get; set; } = new List<CalificacionClase>();

    public virtual ICollection<Clasificacion> Clasificacions { get; set; } = new List<Clasificacion>();

    public virtual ICollection<CriteriosRevisado> CriteriosRevisados { get; set; } = new List<CriteriosRevisado>();

    public virtual TipoAuditoria? TipoAuditoria { get; set; }
}
