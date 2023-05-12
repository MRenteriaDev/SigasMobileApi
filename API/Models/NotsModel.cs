using System;
using System.Collections.Generic;

namespace API.Models;

public partial class NotsModel
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string? Message { get; set; }

    public DateTime Created { get; set; }

    public bool IsChecked { get; set; }

    public string? UserId { get; set; }

    public int? AuditoriaId { get; set; }

    public int? AuditorId { get; set; }

    public virtual Auditor? Auditor { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual User? User { get; set; }
}
