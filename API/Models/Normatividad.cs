using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Normatividad
{
    public int Id { get; set; }

    public int? TipoEnteId { get; set; }

    public string? NombreCorto { get; set; }

    public string? Descripcion { get; set; }

    public string? Leyes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? UnidadAdministrativaId { get; set; }

    public bool IsFederal { get; set; }

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual TipoEnte? TipoEnte { get; set; }

    public virtual UnidadAdministrativa? UnidadAdministrativa { get; set; }
}
