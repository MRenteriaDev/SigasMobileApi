using System;
using System.Collections.Generic;

namespace API.Models;

public partial class DenunciaStatusDenuncia
{
    public int Id { get; set; }

    public int DenunciaId { get; set; }

    public int StatusDenunciaId { get; set; }

    public DateTime Fecha { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Denuncia Denuncia { get; set; } = null!;

    public virtual StatusDenuncia StatusDenuncia { get; set; } = null!;
}
