using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoOficio
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool RequiereFolio { get; set; }

    public bool? Activo { get; set; }

    public int EtapaId { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<CopiasOficio> CopiasOficios { get; set; } = new List<CopiasOficio>();

    public virtual EtapasAuditoria Etapa { get; set; } = null!;

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<PropiedadesTipoOficio> PropiedadesTipoOficios { get; set; } = new List<PropiedadesTipoOficio>();
}
