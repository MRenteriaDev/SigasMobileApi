using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Sancion
{
    public int Id { get; set; }

    public int FuncionarioId { get; set; }

    public int EnteId { get; set; }

    public int TipoSancionId { get; set; }

    public string? Oficio { get; set; }

    public string? Puesto { get; set; }

    public string? Observaciones { get; set; }

    public string? Resultado { get; set; }

    public bool Notificado { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FechaAcuerdo { get; set; }

    public DateTime? FechaTermino { get; set; }

    public double Importe { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double? ImportePagado { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? NombreCompleto { get; set; }

    public bool Recurrencia { get; set; }

    public virtual Ente Ente { get; set; } = null!;

    public virtual Funcionario Funcionario { get; set; } = null!;

    public virtual ICollection<PagoSancion> PagoSancions { get; set; } = new List<PagoSancion>();

    public virtual TipoSancion TipoSancion { get; set; } = null!;
}
