using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Informe
{
    public int Id { get; set; }

    public long? TotalMaterialidad { get; set; }

    public int? AuditoriaId { get; set; }

    public string? Informe1 { get; set; }

    public string? InformeEscaneado { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? RevisionId { get; set; }

    public int TipoInformeId { get; set; }

    public int? EnteId { get; set; }

    public int? EjercicioId { get; set; }

    public string? InformeNoTestado { get; set; }

    public bool ValidadoVinculacion { get; set; }

    public int? FondoFederalId { get; set; }

    public string? Nombre { get; set; }

    public string? Ambito { get; set; }

    public string? InformeTestado { get; set; }

    public bool? VisibleEnSitioWeb { get; set; }

    public int? TipoAuditoriaId { get; set; }

    public int? TipoDictamenId { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual Ejercicio? Ejercicio { get; set; }

    public virtual Ente? Ente { get; set; }

    public virtual FondosFederale? FondoFederal { get; set; }

    public virtual ICollection<InformeSeccionesInforme> InformeSeccionesInformes { get; set; } = new List<InformeSeccionesInforme>();

    public virtual Revisione? Revision { get; set; }

    public virtual TipoAuditoria? TipoAuditoria { get; set; }

    public virtual TipoDictaman? TipoDictamen { get; set; }

    public virtual TipoInforme TipoInforme { get; set; } = null!;
}
