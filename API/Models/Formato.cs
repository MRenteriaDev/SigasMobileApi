using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Formato
{
    public int Id { get; set; }

    public int TipoEnteId { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool FormatoEspecial { get; set; }

    public string? Archivo { get; set; }

    public string? TipoPeriodo { get; set; }

    public string? Formato1 { get; set; }

    public bool? Publico { get; set; }

    public int? Orden { get; set; }

    public bool Fisico { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<InformacionFinanciera> InformacionFinancieras { get; set; } = new List<InformacionFinanciera>();

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
