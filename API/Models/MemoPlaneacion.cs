using System;
using System.Collections.Generic;

namespace API.Models;

public partial class MemoPlaneacion
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public string? Objeto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual ICollection<MemorandumSeccione> MemorandumSecciones { get; set; } = new List<MemorandumSeccione>();
}
