using System;
using System.Collections.Generic;

namespace API.Models;

public partial class OficiosRecepcionDocumentacion
{
    public int Id { get; set; }

    public int RecepcionDocumentacionId { get; set; }

    public string? NumeroOficio { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? AuditoriaId { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual RecepcionDocumentacion RecepcionDocumentacion { get; set; } = null!;
}
