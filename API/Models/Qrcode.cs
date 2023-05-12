using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Qrcode
{
    public int Id { get; set; }

    public int DocumentoId { get; set; }

    public string? Codigo { get; set; }

    public string? Resumen { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
