using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RubroAuditado
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public string? Descripcion { get; set; }

    public string? Conclusion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int Orden { get; set; }

    public int RevisionId { get; set; }

    public string? Nombre { get; set; }

    public int? CuestionarioAuditoriaId { get; set; }

    public int? FondoFederalId { get; set; }

    public double? MontoAuditadoFondoFederal { get; set; }

    public int? RubroTipoAuditoriaId { get; set; }

    public int? RubroProcedimientoId { get; set; }

    public string? ArchivoConclusion { get; set; }

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual CuestionarioAuditoria? CuestionarioAuditoria { get; set; }

    public virtual FondosFederale? FondoFederal { get; set; }

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual ICollection<NoConformidad> NoConformidads { get; set; } = new List<NoConformidad>();

    public virtual Revisione Revision { get; set; } = null!;

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual RubroProcedimiento? RubroProcedimiento { get; set; }

    public virtual RubroTipoAuditoria? RubroTipoAuditoria { get; set; }

    public virtual ICollection<SeccionesInformeRubroAuditado> SeccionesInformeRubroAuditados { get; set; } = new List<SeccionesInformeRubroAuditado>();
}
