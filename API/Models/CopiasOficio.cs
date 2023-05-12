using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CopiasOficio
{
    public int Id { get; set; }

    public int FuncionarioId { get; set; }

    public int TipoOficioId { get; set; }

    public string? Puesto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int EntesId { get; set; }

    public int? TipoFuncionariosId { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public virtual Ente Entes { get; set; } = null!;

    public virtual Funcionario Funcionario { get; set; } = null!;

    public virtual TipoFuncionario? TipoFuncionarios { get; set; }

    public virtual TipoOficio TipoOficio { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;
}
