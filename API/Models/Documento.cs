using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Documento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Anotaciones { get; set; }

    public string? Extension { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int ObservacionDocumentos { get; set; }

    public string? NotaAuditor { get; set; }

    public bool Protegido { get; set; }

    public string? UserId { get; set; }

    public bool Autorizado { get; set; }

    public bool InInforme { get; set; }

    public int TipoRespuestaId { get; set; }

    public int? PronunciamientoId { get; set; }

    public virtual ICollection<ArchivoDocumento> ArchivoDocumentos { get; set; } = new List<ArchivoDocumento>();

    public virtual Observacione ObservacionDocumentosNavigation { get; set; } = null!;

    public virtual ICollection<OficiosRespuesta> OficiosRespuesta { get; set; } = new List<OficiosRespuesta>();

    public virtual PronunciamientoObservacione? Pronunciamiento { get; set; }

    public virtual TipoRespuesta TipoRespuesta { get; set; } = null!;

    public virtual User? User { get; set; }
}
