using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoDictaman
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<SeccionesInforme> SeccionesInformes { get; set; } = new List<SeccionesInforme>();
}
