using System;
using System.Collections.Generic;

namespace API.Models;

public partial class SeccionesInforme
{
    public int Id { get; set; }

    public int TipoInformesId { get; set; }

    public int? TipoAuditoriaId { get; set; }

    public string? NombreSeccion { get; set; }

    public string? Createdby { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? TextoSeccion { get; set; }

    public int Orden { get; set; }

    public string? NombreCorto { get; set; }

    public int? TipoEnteId { get; set; }

    public int? UnidadAdministrativaId { get; set; }

    public bool Eliminable { get; set; }

    public int? Subtitulo { get; set; }

    public bool MayorA25mil { get; set; }

    public bool Deshabilitada { get; set; }

    public int? TipoDictamenId { get; set; }

    public virtual ICollection<InformeSeccionesInforme> InformeSeccionesInformes { get; set; } = new List<InformeSeccionesInforme>();

    public virtual ICollection<RubroSeccionesInforme> RubroSeccionesInformes { get; set; } = new List<RubroSeccionesInforme>();

    public virtual TipoAuditoria? TipoAuditoria { get; set; }

    public virtual TipoDictaman? TipoDictamen { get; set; }

    public virtual TipoEnte? TipoEnte { get; set; }

    public virtual TipoInforme TipoInformes { get; set; } = null!;

    public virtual UnidadAdministrativa? UnidadAdministrativa { get; set; }
}
