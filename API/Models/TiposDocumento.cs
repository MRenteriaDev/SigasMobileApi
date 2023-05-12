using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TiposDocumento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<DocumentosExpediente> DocumentosExpedientes { get; set; } = new List<DocumentosExpediente>();

    public virtual ICollection<FormatosDocumento> FormatosDocumentos { get; set; } = new List<FormatosDocumento>();
}
