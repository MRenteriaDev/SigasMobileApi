using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RubroProcedimiento
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public int TipoEnteId { get; set; }

    public int TipoAuditoriaId { get; set; }

    public string? Procedimiento { get; set; }

    public string? Conclusion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Nombre { get; set; }

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();

    public virtual ICollection<RubroTipoAuditoria> RubroTipoAuditoria { get; set; } = new List<RubroTipoAuditoria>();

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
