using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ArchivoDocumento
{
    public int Id { get; set; }

    public int? DocumentosId { get; set; }

    public int? ArchivoId { get; set; }

    public int? AuditoriaId { get; set; }

    public string? CreatedById { get; set; }

    public DateTime Created { get; set; }

    public string? Bitacora { get; set; }

    public virtual Archivo? Archivo { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual User? CreatedBy { get; set; }

    public virtual Documento? Documentos { get; set; }
}
