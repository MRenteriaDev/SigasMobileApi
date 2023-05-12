using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FormatosDocumento
{
    public int Id { get; set; }

    public int TiposDocumentoId { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Archivo { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<DocumentosExpediente> DocumentosExpedientes { get; set; } = new List<DocumentosExpediente>();

    public virtual TiposDocumento TiposDocumento { get; set; } = null!;
}
