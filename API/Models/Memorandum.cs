using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Memorandum
{
    public int Id { get; set; }

    public int TipoAuditoriaId { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public string? Nombre { get; set; }

    public string? Archivo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;
}
