using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Ponderacion
{
    public int Id { get; set; }

    public int Poderacion { get; set; }

    public int TipoAuditoriaId { get; set; }

    public bool SinDeuda { get; set; }

    public bool SinObra { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<CalificacionClase> CalificacionClases { get; set; } = new List<CalificacionClase>();

    public virtual ICollection<CriterioAuditoria> CriterioAuditoriaPonderacionId1Navigations { get; set; } = new List<CriterioAuditoria>();

    public virtual ICollection<CriterioAuditoria> CriterioAuditoriaPonderacions { get; set; } = new List<CriterioAuditoria>();

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;
}
