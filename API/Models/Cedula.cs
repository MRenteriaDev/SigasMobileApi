using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Cedula
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? ConceptoId { get; set; }

    public double Monto { get; set; }

    public int AuditoriaId { get; set; }

    public int AuditorId { get; set; }

    public string? Documento { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TipoCedulaId { get; set; }

    public int RubroId { get; set; }

    public string? Evidencia { get; set; }

    public bool Autorizada { get; set; }

    public string? Conclusion { get; set; }

    public int Orden { get; set; }

    public int RubroAuditadoId { get; set; }

    public int? GrupoRubricasId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Concepto? Concepto { get; set; }

    public virtual GrupoRubrica? GrupoRubricas { get; set; }

    public virtual ICollection<Requerimiento> Requerimientos { get; set; } = new List<Requerimiento>();

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual RubroAuditado RubroAuditado { get; set; } = null!;

    public virtual TipoCedula? TipoCedula { get; set; }
}
