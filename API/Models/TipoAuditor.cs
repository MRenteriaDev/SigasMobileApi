using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoAuditor
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Auditor> Auditors { get; set; } = new List<Auditor>();
}
