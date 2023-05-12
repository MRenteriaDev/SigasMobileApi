using System;
using System.Collections.Generic;

namespace API.Models;

public partial class UsuarioEnte
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int EnteId { get; set; }

    public virtual Ente Ente { get; set; } = null!;

    public virtual User? User { get; set; }
}
