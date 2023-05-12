using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Socio
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Direccion { get; set; }

    public string? Rfc { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<SocioProveedor> SocioProveedors { get; set; } = new List<SocioProveedor>();
}
