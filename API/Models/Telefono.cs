using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Telefono
{
    public int Id { get; set; }

    public int? FuncionarioId { get; set; }

    public int? EnteId { get; set; }

    public string? Tipo { get; set; }

    public string? Numero { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Ente? Ente { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
