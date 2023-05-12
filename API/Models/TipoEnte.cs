using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoEnte
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Adscripcion { get; set; }

    public string? Ambito { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<CriteriosRevisado> CriteriosRevisados { get; set; } = new List<CriteriosRevisado>();

    public virtual ICollection<Cuestionario> Cuestionarios { get; set; } = new List<Cuestionario>();

    public virtual ICollection<Ente> Entes { get; set; } = new List<Ente>();

    public virtual ICollection<EtcasTipoEnte> EtcasTipoEntes { get; set; } = new List<EtcasTipoEnte>();

    public virtual ICollection<Formato> Formatos { get; set; } = new List<Formato>();

    public virtual ICollection<Normatividad> Normatividads { get; set; } = new List<Normatividad>();

    public virtual ICollection<Plantilla> Plantillas { get; set; } = new List<Plantilla>();

    public virtual ICollection<RubroProcedimiento> RubroProcedimientos { get; set; } = new List<RubroProcedimiento>();

    public virtual ICollection<RubroTipoAuditoria> RubroTipoAuditoria { get; set; } = new List<RubroTipoAuditoria>();

    public virtual ICollection<SeccionesInforme> SeccionesInformes { get; set; } = new List<SeccionesInforme>();
}
