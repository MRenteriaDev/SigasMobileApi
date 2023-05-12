using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Inhabile
{
    public int Id { get; set; }

    public string? Motivo { get; set; }

    public DateTime Dia { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
