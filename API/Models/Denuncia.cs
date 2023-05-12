using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Denuncia
{
    public int Id { get; set; }

    public int EjercicioId { get; set; }

    public int? EnteId { get; set; }

    public int StatusDenunciaId { get; set; }

    public int TipoDenunciaId { get; set; }

    public int? ObservacionId { get; set; }

    public string? Expediente { get; set; }

    public string? Causa { get; set; }

    public bool Procedencia { get; set; }

    public DateTime Fecha { get; set; }

    public double Monto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? StatusDenunciaId1 { get; set; }

    public string? Denunciado { get; set; }

    public virtual ICollection<DenunciaStatusDenuncia> DenunciaStatusDenuncia { get; set; } = new List<DenunciaStatusDenuncia>();

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente? Ente { get; set; }

    public virtual Observacione? Observacion { get; set; }

    public virtual ICollection<RespuestaDenuncia> RespuestaDenuncia { get; set; } = new List<RespuestaDenuncia>();

    public virtual StatusDenuncia StatusDenuncia { get; set; } = null!;

    public virtual StatusDenuncia? StatusDenunciaId1Navigation { get; set; }

    public virtual TipoDenuncia TipoDenuncia { get; set; } = null!;
}
