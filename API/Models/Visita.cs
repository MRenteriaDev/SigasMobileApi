using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Visita
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string? Visitante { get; set; }

    public string? Cargo { get; set; }

    public string? Empleado { get; set; }

    public string? Asunto { get; set; }

    public string? Identificacion { get; set; }

    public string? Gafete { get; set; }

    public int EnteId { get; set; }

    public virtual Ente Ente { get; set; } = null!;
}
