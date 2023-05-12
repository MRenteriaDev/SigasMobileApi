using System;
using System.Collections.Generic;

namespace API.Models;

public partial class GrupoRubrica
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual ICollection<GrupoRubricasAuditor> GrupoRubricasAuditors { get; set; } = new List<GrupoRubricasAuditor>();

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual ICollection<MemorandumSeccione> MemorandumSecciones { get; set; } = new List<MemorandumSeccione>();

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();
}
