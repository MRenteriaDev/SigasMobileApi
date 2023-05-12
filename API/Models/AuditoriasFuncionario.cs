using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AuditoriasFuncionario
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int FuncionarioId { get; set; }

    public string? Rol { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Funcionario Funcionario { get; set; } = null!;
}
