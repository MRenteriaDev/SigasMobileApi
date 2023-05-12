using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EtapasAuditoria
{
    public int Id { get; set; }

    public int Orden { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Apartado> Apartados { get; set; } = new List<Apartado>();

    public virtual ICollection<FormatosDocumentosdeTrabajo> FormatosDocumentosdeTrabajos { get; set; } = new List<FormatosDocumentosdeTrabajo>();

    public virtual ICollection<TipoOficio> TipoOficios { get; set; } = new List<TipoOficio>();
}
