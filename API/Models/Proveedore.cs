using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string? Rfc { get; set; }

    public string? Razonsocial { get; set; }

    public string? Direccion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? EntidadFederativa { get; set; }

    public string? RepresentanteLegal { get; set; }

    public string? Giro { get; set; }

    public DateTime? FechaInicioOperaciones { get; set; }

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<ProveedorMonto> ProveedorMontos { get; set; } = new List<ProveedorMonto>();

    public virtual ICollection<SocioProveedor> SocioProveedors { get; set; } = new List<SocioProveedor>();
}
