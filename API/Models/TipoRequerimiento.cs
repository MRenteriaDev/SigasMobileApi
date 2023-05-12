using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoRequerimiento
{
    public int Id { get; set; }

    public int TipoCedulaId { get; set; }

    public string? Nombre { get; set; }

    public string? Documento { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Requerimiento> Requerimientos { get; set; } = new List<Requerimiento>();

    public virtual TipoCedula TipoCedula { get; set; } = null!;
}
