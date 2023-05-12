using System;
using System.Collections.Generic;

namespace API.Models;

public partial class GrupoRubricasAuditor
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public int GrupoRubricasId { get; set; }

    public int TipoRubricaId { get; set; }

    public int AuditorId { get; set; }

    public virtual Auditor Auditor { get; set; } = null!;

    public virtual GrupoRubrica GrupoRubricas { get; set; } = null!;

    public virtual TipoRubrica TipoRubrica { get; set; } = null!;
}
