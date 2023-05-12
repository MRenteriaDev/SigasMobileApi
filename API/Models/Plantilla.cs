using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Plantilla
{
    public int Id { get; set; }

    public int ContadorUso { get; set; }

    public int? TipoAuditoriaId { get; set; }

    public int? RubrosId { get; set; }

    public string? Clave { get; set; }

    public string? NombreCorto { get; set; }

    public string? Observacion { get; set; }

    public string? Normatividad { get; set; }

    public string? Solventacion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public int? TipoEnteId { get; set; }

    public bool Revisado { get; set; }

    public bool IsActiva { get; set; }

    public virtual ICollection<ClasificacionPlantilla> ClasificacionPlantillas { get; set; } = new List<ClasificacionPlantilla>();

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual Rubro? Rubros { get; set; }

    public virtual TipoAuditoria? TipoAuditoria { get; set; }

    public virtual TipoEnte? TipoEnte { get; set; }

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;
}
