using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RubroTipoAuditoria
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public int TipoAuditoriaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoEnteId { get; set; }

    public int? Orden { get; set; }

    public string? Nombre { get; set; }

    public int? RubroProcedimientoId { get; set; }

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();

    public virtual RubroProcedimiento? RubroProcedimiento { get; set; }

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual ICollection<TipoCedula> TipoCedulas { get; set; } = new List<TipoCedula>();

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
