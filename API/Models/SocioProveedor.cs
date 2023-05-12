using System;
using System.Collections.Generic;

namespace API.Models;

public partial class SocioProveedor
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int SocioId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;
}
