using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Gramatica
{
    public int Id { get; set; }

    public string? TipoGramatical { get; set; }

    public string? Clase { get; set; }

    public string? Cuantitativo { get; set; }

    public string? Narrativa { get; set; }

    public string? Masculino { get; set; }

    public string? Femenino { get; set; }

    public string? Neutro { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CreatedBy { get; set; }
}
