using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Requerimiento
{
    public int Id { get; set; }

    public int? TipoRequerimientoId { get; set; }

    public bool Cumplimiento { get; set; }

    public string? SoporteDocumental { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int CedulaId { get; set; }

    public string? Documento { get; set; }

    public string? Nombre { get; set; }

    public virtual Cedula Cedula { get; set; } = null!;

    public virtual TipoRequerimiento? TipoRequerimiento { get; set; }
}
