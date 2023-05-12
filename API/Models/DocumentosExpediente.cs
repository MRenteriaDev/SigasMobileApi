using System;
using System.Collections.Generic;

namespace API.Models;

public partial class DocumentosExpediente
{
    public int Id { get; set; }

    public int ExpedienteId { get; set; }

    public string? UserId { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Archivo { get; set; }

    public int TipoDocumentoId { get; set; }

    public int? FormatoDocumentoId { get; set; }

    public virtual Expediente Expediente { get; set; } = null!;

    public virtual FormatosDocumento? FormatoDocumento { get; set; }

    public virtual TiposDocumento TipoDocumento { get; set; } = null!;

    public virtual User? User { get; set; }
}
