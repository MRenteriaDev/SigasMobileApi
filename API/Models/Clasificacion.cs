using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Clasificacion
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoClasificacionId { get; set; }

    public float? Ponderacion { get; set; }

    public bool? CuentaComoCriterio { get; set; }

    public string? Ambito { get; set; }

    public string? MayorA25mil { get; set; }

    public virtual ICollection<ClasificacionHallazgo> ClasificacionHallazgos { get; set; } = new List<ClasificacionHallazgo>();

    public virtual ICollection<ClasificacionPlantilla> ClasificacionPlantillas { get; set; } = new List<ClasificacionPlantilla>();

    public virtual ICollection<CriterioAuditoria> CriterioAuditoria { get; set; } = new List<CriterioAuditoria>();

    public virtual ICollection<CriteriosAcreditado> CriteriosAcreditados { get; set; } = new List<CriteriosAcreditado>();

    public virtual TipoClasificacion TipoClasificacion { get; set; } = null!;
}
