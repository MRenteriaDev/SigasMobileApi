using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Deceso
{
    public int Id { get; set; }

    public string? Pk { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Curp { get; set; }

    public DateTime Fecha { get; set; }

    public string? Causa { get; set; }

    public int Edad { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? FechaNacimiento { get; set; }

    public DateTime FechaNacimientoValue { get; set; }

    public string? Clave { get; set; }
}
