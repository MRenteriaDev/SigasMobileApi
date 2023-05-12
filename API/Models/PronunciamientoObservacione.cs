using System;
using System.Collections.Generic;

namespace API.Models;

public partial class PronunciamientoObservacione
{
    public int Id { get; set; }

    public string? NumOficio { get; set; }

    public DateTime FechaOficio { get; set; }

    public int EnteId { get; set; }

    public int? AuditoriaId { get; set; }

    public string? Word { get; set; }

    public string? Pdf { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? FechaNotificacion { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual Ente Ente { get; set; } = null!;
}
