using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FondosFederalesRecibido
{
    public int Id { get; set; }

    public int EjercicioId { get; set; }

    public int FondosFederalesId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double MontoRecibido { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual FondosFederale FondosFederales { get; set; } = null!;
}
