using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusDenuncia
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Denuncia> DenunciaStatusDenuncia { get; set; } = new List<Denuncia>();

    public virtual ICollection<Denuncia> DenunciaStatusDenunciaId1Navigations { get; set; } = new List<Denuncia>();

    public virtual ICollection<DenunciaStatusDenuncia> DenunciaStatusDenunciaNavigation { get; set; } = new List<DenunciaStatusDenuncia>();
}
