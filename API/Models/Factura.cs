using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Factura
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public string? NumeroFactura { get; set; }

    public string? Concepto { get; set; }

    public string? Estado { get; set; }

    public string? Total { get; set; }

    public string? Emisor { get; set; }

    public string? Receptor { get; set; }

    public string? TimbreFiscalDigital { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Folio { get; set; }

    public string? Serie { get; set; }

    public string? FileName { get; set; }

    public DateTime Fecha { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Ente Ente { get; set; } = null!;
}
