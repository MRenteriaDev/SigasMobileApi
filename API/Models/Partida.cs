using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Partida
{
    public int Id { get; set; }

    public int ConceptoId { get; set; }

    public string? Clave { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool? Activo { get; set; }

    public string? Ambito { get; set; }

    public virtual Concepto Concepto { get; set; } = null!;

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<ObraPublica> ObraPublicas { get; set; } = new List<ObraPublica>();
}
