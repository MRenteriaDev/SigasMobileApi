using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Auditoria
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public int EnteId { get; set; }

    public int? EquipoId { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int IdEjercicio { get; set; }

    public int TipoAuditoria { get; set; }

    public int ModoEjecucionId { get; set; }

    public int? UnidadAdministrativaId1 { get; set; }

    public string? Objetivo { get; set; }

    public bool Cumplio { get; set; }

    public bool Equidad { get; set; }

    public string? ObjetivoEspecifico { get; set; }

    public string? NormatividadAplicada { get; set; }

    public string? Desarrollo { get; set; }

    public string? Materialidad { get; set; }

    public string? Alcance { get; set; }

    public long TotalMaterialidad { get; set; }

    public string? InformePreliminar { get; set; }

    public string? InformePreliminarEscaneado { get; set; }

    public int ConsecutivoHallazgo { get; set; }

    public int ConsecutivoObservacion { get; set; }

    public int StatusAuditoriaId { get; set; }

    public double PorcentajeMaterialidad { get; set; }

    public double PorcentajeEjecucion { get; set; }

    public int PeriodoId { get; set; }

    public int? AuditorEncargadoId { get; set; }

    public int DiaAuditoria { get; set; }

    public DateTime? FechaActaInicio { get; set; }

    public virtual ICollection<ArchivoDocumento> ArchivoDocumentos { get; set; } = new List<ArchivoDocumento>();

    public virtual ICollection<AuditorAuditoria> AuditorAuditoria { get; set; } = new List<AuditorAuditoria>();

    public virtual Auditor? AuditorEncargado { get; set; }

    public virtual ICollection<AuditoriaPpra> AuditoriaPpras { get; set; } = new List<AuditoriaPpra>();

    public virtual ICollection<AuditoriasFuncionario> AuditoriasFuncionarios { get; set; } = new List<AuditoriasFuncionario>();

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<CriterioAuditoria> CriterioAuditoria { get; set; } = new List<CriterioAuditoria>();

    public virtual ICollection<CuestionarioAuditoria> CuestionarioAuditoria { get; set; } = new List<CuestionarioAuditoria>();

    public virtual Ente Ente { get; set; } = null!;

    public virtual Equipo? Equipo { get; set; }

    public virtual ICollection<EquipoAuditoria> EquipoAuditoria { get; set; } = new List<EquipoAuditoria>();

    public virtual ICollection<FechaControl> FechaControlAuditoria { get; set; } = new List<FechaControl>();

    public virtual ICollection<FechaControl> FechaControlAuditorias { get; set; } = new List<FechaControl>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<GastoAuditoria> GastoAuditoria { get; set; } = new List<GastoAuditoria>();

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual Ejercicio IdEjercicioNavigation { get; set; } = null!;

    public virtual ICollection<ImportesAuditoria> ImportesAuditoria { get; set; } = new List<ImportesAuditoria>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<IngresoAuditoria> IngresoAuditoria { get; set; } = new List<IngresoAuditoria>();

    public virtual ICollection<LogStorageFile> LogStorageFiles { get; set; } = new List<LogStorageFile>();

    public virtual ICollection<MemoPlaneacion> MemoPlaneacions { get; set; } = new List<MemoPlaneacion>();

    public virtual ModoEjecucion ModoEjecucion { get; set; } = null!;

    public virtual ICollection<NoConformidad> NoConformidads { get; set; } = new List<NoConformidad>();

    public virtual ICollection<NotsModel> NotsModels { get; set; } = new List<NotsModel>();

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<OficiosRecepcionDocumentacion> OficiosRecepcionDocumentacions { get; set; } = new List<OficiosRecepcionDocumentacion>();

    public virtual ICollection<Papele> PapeleAuditoria { get; set; } = new List<Papele>();

    public virtual ICollection<Papele> PapeleAuditorias { get; set; } = new List<Papele>();

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<PronunciamientoObservacione> PronunciamientoObservaciones { get; set; } = new List<PronunciamientoObservacione>();

    public virtual ICollection<Respuesta> Respuesta { get; set; } = new List<Respuesta>();

    public virtual ICollection<Revisione> Revisiones { get; set; } = new List<Revisione>();

    public virtual StatusAuditoria StatusAuditoria { get; set; } = null!;

    public virtual ICollection<StatusAuditoriaAuditoria> StatusAuditoriaAuditoria { get; set; } = new List<StatusAuditoriaAuditoria>();

    public virtual TipoAuditoria TipoAuditoriaNavigation { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;

    public virtual UnidadAdministrativa? UnidadAdministrativaId1Navigation { get; set; }
}
