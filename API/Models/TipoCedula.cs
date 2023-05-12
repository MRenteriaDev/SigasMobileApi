using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoCedula
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Descripcion { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int RubroTipoAuditoriaId { get; set; }

    public string? Documento { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual RubroTipoAuditoria RubroTipoAuditoria { get; set; } = null!;

    public virtual ICollection<TipoRequerimiento> TipoRequerimientos { get; set; } = new List<TipoRequerimiento>();
}
