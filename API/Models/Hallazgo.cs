using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Hallazgo
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int AuditorId { get; set; }

    public string? Descripcion { get; set; }

    public string? Justificacion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool Atendido { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int RubroId { get; set; }

    public string? Adjunto { get; set; }

    public string? EvidenciaDocumental { get; set; }

    public double? Importe { get; set; }

    public string? DocumentoSolventado { get; set; }

    public string? Normatividad { get; set; }

    public string? MedidaSolventacion { get; set; }

    public string? AdjuntoHtml { get; set; }

    public bool Validado { get; set; }

    public int? PlantillaId { get; set; }

    public int? PadreId { get; set; }

    public int? HijoId { get; set; }

    public int Orden { get; set; }

    public int RubroAuditadoId { get; set; }

    public bool Autorizado { get; set; }

    public int? RespuestaId { get; set; }

    public bool Reincidencia { get; set; }

    public string? DescripcionReincidencia { get; set; }

    public int TipoObservacionId { get; set; }

    public int? GrupoRubricasId { get; set; }

    public bool PosibleDanoPatrimonial { get; set; }

    public int? NormatividadId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual ICollection<ClasificacionHallazgo> ClasificacionHallazgos { get; set; } = new List<ClasificacionHallazgo>();

    public virtual GrupoRubrica? GrupoRubricas { get; set; }

    public virtual Hallazgo? Hijo { get; set; }

    public virtual ICollection<Hallazgo> InverseHijo { get; set; } = new List<Hallazgo>();

    public virtual ICollection<Hallazgo> InversePadre { get; set; } = new List<Hallazgo>();

    public virtual Normatividad? NormatividadNavigation { get; set; }

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual Hallazgo? Padre { get; set; }

    public virtual Plantilla? Plantilla { get; set; }

    public virtual Respuesta? Respuesta { get; set; }

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual RubroAuditado RubroAuditado { get; set; } = null!;

    public virtual TipoObservacion TipoObservacion { get; set; } = null!;
}
