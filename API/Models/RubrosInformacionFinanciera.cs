using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RubrosInformacionFinanciera
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Createdby { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Clave { get; set; }

    public string? Descripcion { get; set; }

    public string? NoCuenta { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Balanza> Balanzas { get; set; } = new List<Balanza>();
}
