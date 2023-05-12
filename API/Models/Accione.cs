using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Accione
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<AccionesTipoRubrica> AccionesTipoRubricas { get; set; } = new List<AccionesTipoRubrica>();
}
