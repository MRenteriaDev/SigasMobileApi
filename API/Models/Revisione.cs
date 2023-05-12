using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Revisione
{
    public int Id { get; set; }

    public int PeriodoId { get; set; }

    public int AuditoriaId { get; set; }

    public string? NombreRevision { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TipoAuditoriaId { get; set; }

    public bool Terminada { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual ICollection<GastoAuditoria> GastoAuditoria { get; set; } = new List<GastoAuditoria>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<MemorandumSeccione> MemorandumSecciones { get; set; } = new List<MemorandumSeccione>();

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();

    public virtual TipoAuditoria? TipoAuditoria { get; set; }
}
