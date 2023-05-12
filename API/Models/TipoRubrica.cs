using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoRubrica
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Infinitivo { get; set; }

    public virtual ICollection<AccionesTipoRubrica> AccionesTipoRubricas { get; set; } = new List<AccionesTipoRubrica>();

    public virtual ICollection<GrupoRubricasAuditor> GrupoRubricasAuditors { get; set; } = new List<GrupoRubricasAuditor>();
}
