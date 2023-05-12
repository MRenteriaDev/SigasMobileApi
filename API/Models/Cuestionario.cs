using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Cuestionario
{
    public int Id { get; set; }

    public int TipoAuditoriaId { get; set; }

    public int TipoEnteId { get; set; }

    public string? Nombre { get; set; }

    public string? Procedimiento { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double Valor { get; set; }

    public int TipoCuestionarioId { get; set; }

    public int RubroId { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<CuestionarioAuditoria> CuestionarioAuditoria { get; set; } = new List<CuestionarioAuditoria>();

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual TipoCuestionario TipoCuestionario { get; set; } = null!;

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
