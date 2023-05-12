using System;
using System.Collections.Generic;

namespace API.Models;

public partial class UsuarioExpediente
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int ExpedienteId { get; set; }

    public virtual Expediente Expediente { get; set; } = null!;

    public virtual User? User { get; set; }
}
