using System;
using System.Collections.Generic;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public partial class ObservacionesWebDbContext : DbContext
{
    public ObservacionesWebDbContext(DbContextOptions<ObservacionesWebDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accione> Acciones { get; set; }

    public virtual DbSet<AccionesTipoRubrica> AccionesTipoRubricas { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<Anexo> Anexos { get; set; }

    public virtual DbSet<Anuncio> Anuncios { get; set; }

    public virtual DbSet<Apartado> Apartadoes { get; set; }

    public virtual DbSet<Archivo> Archivos { get; set; }

    public virtual DbSet<ArchivoDocumento> ArchivoDocumentoes { get; set; }

    public virtual DbSet<ArchivoPermanente> ArchivoPermanentes { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuditLogDetail> AuditLogDetails { get; set; }

    public virtual DbSet<Auditor> Auditors { get; set; }

    public virtual DbSet<AuditorAuditoria> AuditorAuditorias { get; set; }

    public virtual DbSet<Auditoria> Auditorias { get; set; }

    public virtual DbSet<AuditoriaPpra> AuditoriaPpras { get; set; }

    public virtual DbSet<AuditoriasFuncionario> AuditoriasFuncionarios { get; set; }

    public virtual DbSet<Balanza> Balanzas { get; set; }

    public virtual DbSet<Calificacion> Calificacions { get; set; }

    public virtual DbSet<CalificacionClase> CalificacionClases { get; set; }

    public virtual DbSet<CalificacionCriterio> CalificacionCriterios { get; set; }

    public virtual DbSet<CalificacionDesempeno> CalificacionDesempenoes { get; set; }

    public virtual DbSet<CalificacionesGlobale> CalificacionesGlobales { get; set; }

    public virtual DbSet<Cedula> Cedulas { get; set; }

    public virtual DbSet<Clasificacion> Clasificacions { get; set; }

    public virtual DbSet<ClasificacionHallazgo> ClasificacionHallazgoes { get; set; }

    public virtual DbSet<ClasificacionNoConformidad> ClasificacionNoConformidads { get; set; }

    public virtual DbSet<ClasificacionPlantilla> ClasificacionPlantillas { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Concepto> Conceptoes { get; set; }

    public virtual DbSet<ConfiguracionInformeResultado> ConfiguracionInformeResultados { get; set; }

    public virtual DbSet<CopiasOficio> CopiasOficios { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<CriterioAuditoria> CriterioAuditorias { get; set; }

    public virtual DbSet<CriteriosAcreditado> CriteriosAcreditados { get; set; }

    public virtual DbSet<CriteriosRevisado> CriteriosRevisados { get; set; }

    public virtual DbSet<Cuestionario> Cuestionarios { get; set; }

    public virtual DbSet<CuestionarioAuditoria> CuestionarioAuditorias { get; set; }

    public virtual DbSet<CumplimientoEtca> CumplimientoEtcas { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<CursoDocumento> CursoDocumentos { get; set; }

    public virtual DbSet<DatosIndicadore> DatosIndicadores { get; set; }

    public virtual DbSet<Deceso> Decesoes { get; set; }

    public virtual DbSet<Denuncia> Denuncias { get; set; }

    public virtual DbSet<DenunciaStatusDenuncia> DenunciaStatusDenuncias { get; set; }

    public virtual DbSet<Dependencia> Dependencias { get; set; }

    public virtual DbSet<DespachosExterno> DespachosExternos { get; set; }

    public virtual DbSet<DeudaFormato> DeudaFormatoes { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<DocumentosExpediente> DocumentosExpedientes { get; set; }

    public virtual DbSet<Egreso> Egresos { get; set; }

    public virtual DbSet<Ejercicio> Ejercicios { get; set; }

    public virtual DbSet<Encuesta> Encuestas { get; set; }

    public virtual DbSet<Ente> Entes { get; set; }

    public virtual DbSet<EnteCalificacion> EnteCalificacions { get; set; }

    public virtual DbSet<Equipo> Equipoes { get; set; }

    public virtual DbSet<EquipoAuditor> EquipoAuditors { get; set; }

    public virtual DbSet<EquipoAuditoria> EquipoAuditorias { get; set; }

    public virtual DbSet<EtapasAuditoria> EtapasAuditorias { get; set; }

    public virtual DbSet<Etca> Etcas { get; set; }

    public virtual DbSet<EtcasTipoEnte> EtcasTipoEntes { get; set; }

    public virtual DbSet<Expediente> Expedientes { get; set; }

    public virtual DbSet<ExpedienteMovimientosExpediente> ExpedienteMovimientosExpedientes { get; set; }

    public virtual DbSet<ExpedienteObservacion> ExpedienteObservacions { get; set; }

    public virtual DbSet<ExpedienteStatusExpediente> ExpedienteStatusExpedientes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FechaControl> FechaControls { get; set; }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<FondosFederale> FondosFederales { get; set; }

    public virtual DbSet<FondosFederalesRecibido> FondosFederalesRecibidos { get; set; }

    public virtual DbSet<Formato> Formatos { get; set; }

    public virtual DbSet<FormatosDocumento> FormatosDocumentoes { get; set; }

    public virtual DbSet<FormatosDocumentosdeTrabajo> FormatosDocumentosdeTrabajoes { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<Gasto> Gastoes { get; set; }

    public virtual DbSet<GastoAuditoria> GastoAuditorias { get; set; }

    public virtual DbSet<Gramatica> Gramaticas { get; set; }

    public virtual DbSet<GrupoRubrica> GrupoRubricas { get; set; }

    public virtual DbSet<GrupoRubricasAuditor> GrupoRubricasAuditors { get; set; }

    public virtual DbSet<Hallazgo> Hallazgos { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<ImporteObservacione> ImporteObservaciones { get; set; }

    public virtual DbSet<ImportesAuditoria> ImportesAuditorias { get; set; }

    public virtual DbSet<InformacionFinanciera> InformacionFinancieras { get; set; }

    public virtual DbSet<InformacionTrimestralEntregada> InformacionTrimestralEntregadas { get; set; }

    public virtual DbSet<Informe> Informes { get; set; }

    public virtual DbSet<InformeSeccionesInforme> InformeSeccionesInformes { get; set; }

    public virtual DbSet<Ingreso> Ingresos { get; set; }

    public virtual DbSet<IngresoAuditoria> IngresoAuditorias { get; set; }

    public virtual DbSet<Inhabile> Inhabiles { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Lista69B> Lista69Bs { get; set; }

    public virtual DbSet<Lista69Bdetalle> Lista69Bdetalles { get; set; }

    public virtual DbSet<LogMetadatum> LogMetadata { get; set; }

    public virtual DbSet<LogStorageFile> LogStorageFiles { get; set; }

    public virtual DbSet<Medio> Medios { get; set; }

    public virtual DbSet<MemoPlaneacion> MemoPlaneacions { get; set; }

    public virtual DbSet<Memorandum> Memoranda { get; set; }

    public virtual DbSet<MemorandumSeccione> MemorandumSecciones { get; set; }

    public virtual DbSet<Meta> Metas { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<ModoEjecucion> ModoEjecucions { get; set; }

    public virtual DbSet<MovimientosExpediente> MovimientosExpedientes { get; set; }

    public virtual DbSet<NoConformidad> NoConformidads { get; set; }

    public virtual DbSet<Normatividad> Normatividads { get; set; }

    public virtual DbSet<NotaEnMedio> NotaEnMedios { get; set; }

    public virtual DbSet<NotsModel> NotsModels { get; set; }

    public virtual DbSet<Objeto> Objetoes { get; set; }

    public virtual DbSet<ObraPublica> ObraPublicas { get; set; }

    public virtual DbSet<Observacione> Observaciones { get; set; }

    public virtual DbSet<Oficio> Oficios { get; set; }

    public virtual DbSet<OficiosRecepcionDocumentacion> OficiosRecepcionDocumentacions { get; set; }

    public virtual DbSet<OficiosRespuesta> OficiosRespuestas { get; set; }

    public virtual DbSet<PagoSancion> PagoSancions { get; set; }

    public virtual DbSet<Papele> Papeles { get; set; }

    public virtual DbSet<Partida> Partidas { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Planeacion> Planeacions { get; set; }

    public virtual DbSet<PlaneacionTipoAuditoria> PlaneacionTipoAuditorias { get; set; }

    public virtual DbSet<Plantilla> Plantillas { get; set; }

    public virtual DbSet<Plazo> Plazoes { get; set; }

    public virtual DbSet<Ponderacion> Ponderacions { get; set; }

    public virtual DbSet<Pregunta> Preguntas { get; set; }

    public virtual DbSet<ProgramaAnual> ProgramaAnuals { get; set; }

    public virtual DbSet<ProgramaPresupuestario> ProgramaPresupuestarios { get; set; }

    public virtual DbSet<PronunciamientoObservacione> PronunciamientoObservaciones { get; set; }

    public virtual DbSet<PropiedadesTipoOficio> PropiedadesTipoOficios { get; set; }

    public virtual DbSet<Prorroga> Prorrogas { get; set; }

    public virtual DbSet<ProveedorMonto> ProveedorMontoes { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Qrcode> Qrcodes { get; set; }

    public virtual DbSet<RecepcionDocumentacion> RecepcionDocumentacions { get; set; }

    public virtual DbSet<Recomendacion> Recomendacions { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<Requerimiento> Requerimientoes { get; set; }

    public virtual DbSet<Respuesta> Respuestas { get; set; }

    public virtual DbSet<RespuestaDenuncia> RespuestaDenuncias { get; set; }

    public virtual DbSet<ResultadosEncuesta> ResultadosEncuestas { get; set; }

    public virtual DbSet<Revisione> Revisiones { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<RubroAuditado> RubroAuditados { get; set; }

    public virtual DbSet<RubroProcedimiento> RubroProcedimientoes { get; set; }

    public virtual DbSet<RubroSeccionesInforme> RubroSeccionesInformes { get; set; }

    public virtual DbSet<RubroTipoAuditoria> RubroTipoAuditorias { get; set; }

    public virtual DbSet<RubrosInformacionFinanciera> RubrosInformacionFinancieras { get; set; }

    public virtual DbSet<Sancion> Sancions { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<SeccionMemorandum> SeccionMemorandums { get; set; }

    public virtual DbSet<SeccionesInforme> SeccionesInformes { get; set; }

    public virtual DbSet<SeccionesInformeRubroAuditado> SeccionesInformeRubroAuditadoes { get; set; }

    public virtual DbSet<Sector> Sectors { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<Socio> Socios { get; set; }

    public virtual DbSet<SocioProveedor> SocioProveedors { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StatusArea> StatusAreas { get; set; }

    public virtual DbSet<StatusAuditoria> StatusAuditorias { get; set; }

    public virtual DbSet<StatusAuditoriaAuditoria> StatusAuditoriaAuditorias { get; set; }

    public virtual DbSet<StatusDenuncia> StatusDenuncias { get; set; }

    public virtual DbSet<StatusExpediente> StatusExpedientes { get; set; }

    public virtual DbSet<StatusNoConformidad> StatusNoConformidads { get; set; }

    public virtual DbSet<StatusObservacion> StatusObservacions { get; set; }

    public virtual DbSet<Sustanciacion> Sustanciacions { get; set; }

    public virtual DbSet<Telefono> Telefonoes { get; set; }

    public virtual DbSet<TipoAnexo> TipoAnexoes { get; set; }

    public virtual DbSet<TipoAnuncio> TipoAnuncios { get; set; }

    public virtual DbSet<TipoArchivoPermanente> TipoArchivoPermanentes { get; set; }

    public virtual DbSet<TipoAuditor> TipoAuditors { get; set; }

    public virtual DbSet<TipoAuditoria> TipoAuditorias { get; set; }

    public virtual DbSet<TipoCedula> TipoCedulas { get; set; }

    public virtual DbSet<TipoClasificacion> TipoClasificacions { get; set; }

    public virtual DbSet<TipoComentario> TipoComentarios { get; set; }

    public virtual DbSet<TipoControl> TipoControls { get; set; }

    public virtual DbSet<TipoCuestionario> TipoCuestionarios { get; set; }

    public virtual DbSet<TipoDenuncia> TipoDenuncias { get; set; }

    public virtual DbSet<TipoDictaman> TipoDictamen { get; set; }

    public virtual DbSet<TipoEnte> TipoEntes { get; set; }

    public virtual DbSet<TipoFuncionario> TipoFuncionarios { get; set; }

    public virtual DbSet<TipoIndicadore> TipoIndicadores { get; set; }

    public virtual DbSet<TipoInforme> TipoInformes { get; set; }

    public virtual DbSet<TipoObservacion> TipoObservacions { get; set; }

    public virtual DbSet<TipoOficio> TipoOficios { get; set; }

    public virtual DbSet<TipoPregunta> TipoPreguntas { get; set; }

    public virtual DbSet<TipoRequerimiento> TipoRequerimientoes { get; set; }

    public virtual DbSet<TipoRespuesta> TipoRespuestas { get; set; }

    public virtual DbSet<TipoResultadoEncuesta> TipoResultadoEncuestas { get; set; }

    public virtual DbSet<TipoRubrica> TipoRubricas { get; set; }

    public virtual DbSet<TipoSancion> TipoSancions { get; set; }

    public virtual DbSet<TiposDocumento> TiposDocumentoes { get; set; }

    public virtual DbSet<TiposExpediente> TiposExpedientes { get; set; }

    public virtual DbSet<UnidadAdministrativa> UnidadAdministrativas { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UsuarioEnte> UsuarioEntes { get; set; }

    public virtual DbSet<UsuarioExpediente> UsuarioExpedientes { get; set; }

    public virtual DbSet<Visita> Visitas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ObservacionesWebDB;Integrated Security=True;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Acciones");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<AccionesTipoRubrica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AccionesTipoRubricas");

            entity.HasIndex(e => e.AccionesId, "IX_AccionesId");

            entity.HasIndex(e => e.TipoRubricaId, "IX_TipoRubricaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Acciones).WithMany(p => p.AccionesTipoRubricas)
                .HasForeignKey(d => d.AccionesId)
                .HasConstraintName("FK_dbo.AccionesTipoRubricas_dbo.Acciones_AccionesId");

            entity.HasOne(d => d.TipoRubrica).WithMany(p => p.AccionesTipoRubricas)
                .HasForeignKey(d => d.TipoRubricaId)
                .HasConstraintName("FK_dbo.AccionesTipoRubricas_dbo.TipoRubricas_TipoRubricaId");
        });

        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "HangFire");

            entity.HasIndex(e => e.Key, "UX_HangFire_CounterAggregated_Key").IsUnique();

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Anexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Anexos");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.TipoAnexoId, "IX_TipoAnexoId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EjercicioId).HasDefaultValueSql("((6))");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Anexos_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.TipoAnexo).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.TipoAnexoId)
                .HasConstraintName("FK_dbo.Anexos_dbo.TipoAnexoes_TipoAnexoId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Anexoes_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.Anexos_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<Anuncio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Anuncios");

            entity.HasIndex(e => e.TipoAnuncioId, "IX_TipoAnuncioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaProgramacion).HasColumnType("datetime");
            entity.Property(e => e.IsPopup).HasColumnName("isPopup");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.VerEnPagina).HasColumnName("verEnPagina");

            entity.HasOne(d => d.TipoAnuncio).WithMany(p => p.Anuncios)
                .HasForeignKey(d => d.TipoAnuncioId)
                .HasConstraintName("FK_dbo.Anuncios_dbo.TipoAnuncios_TipoAnuncioId");
        });

        modelBuilder.Entity<Apartado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Apartadoes");

            entity.HasIndex(e => e.EtapasAuditoriaId, "IX_EtapasAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.EtapasAuditoria).WithMany(p => p.Apartados)
                .HasForeignKey(d => d.EtapasAuditoriaId)
                .HasConstraintName("FK_dbo.Apartadoes_dbo.EtapasAuditorias_EtapasAuditoriaId");
        });

        modelBuilder.Entity<Archivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Archivos");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.FolderId, "IX_Folder_Id");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.FolderId).HasColumnName("Folder_Id");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.Archivos)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.Archivos_dbo.Users_CreatedById");

            entity.HasOne(d => d.Folder).WithMany(p => p.Archivos)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Archivoes_dbo.Folders_Folder_Id");
        });

        modelBuilder.Entity<ArchivoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ArchivoDocumentoes");

            entity.HasIndex(e => e.ArchivoId, "IX_ArchivoId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.DocumentosId, "IX_DocumentosId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedById).HasMaxLength(128);

            entity.HasOne(d => d.Archivo).WithMany(p => p.ArchivoDocumentos)
                .HasForeignKey(d => d.ArchivoId)
                .HasConstraintName("FK_dbo.ArchivoDocumentoes_dbo.Archivos_ArchivoId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.ArchivoDocumentos)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.ArchivoDocumentoes_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.ArchivoDocumentos)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.ArchivoDocumentoes_dbo.Users_CreatedById");

            entity.HasOne(d => d.Documentos).WithMany(p => p.ArchivoDocumentos)
                .HasForeignKey(d => d.DocumentosId)
                .HasConstraintName("FK_dbo.ArchivoDocumentoes_dbo.Documentos_DocumentosId");
        });

        modelBuilder.Entity<ArchivoPermanente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ArchivoPermanentes");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.TipoArchivoPermanenteId, "IX_TipoArchivoPermanenteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaBoletin).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.ArchivoPermanentes)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.ArchivoPermanentes_dbo.Entes_EnteId");

            entity.HasOne(d => d.TipoArchivoPermanente).WithMany(p => p.ArchivoPermanentes)
                .HasForeignKey(d => d.TipoArchivoPermanenteId)
                .HasConstraintName("FK_dbo.ArchivoPermanentes_dbo.TipoArchivoPermanentes_TipoArchivoPermanenteId");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Areas");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasDefaultValueSql("('')");

            entity.HasOne(d => d.Auditor).WithMany(p => p.Areas)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.Areas_dbo.Auditors_AuditorId");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditLogId).HasName("PK_dbo.AuditLogs");

            entity.Property(e => e.EventDateUtc)
                .HasColumnType("datetime")
                .HasColumnName("EventDateUTC");
            entity.Property(e => e.RecordId).HasMaxLength(256);
            entity.Property(e => e.TypeFullName).HasMaxLength(512);
        });

        modelBuilder.Entity<AuditLogDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AuditLogDetails");

            entity.HasIndex(e => e.AuditLogId, "IX_AuditLogId");

            entity.Property(e => e.PropertyName).HasMaxLength(256);

            entity.HasOne(d => d.AuditLog).WithMany(p => p.AuditLogDetails)
                .HasForeignKey(d => d.AuditLogId)
                .HasConstraintName("FK_dbo.AuditLogDetails_dbo.AuditLogs_AuditLogId");
        });

        modelBuilder.Entity<Auditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Auditors");

            entity.HasIndex(e => e.JefeDirectoId, "IX_JefeDirectoId");

            entity.HasIndex(e => e.TipoAuditorId, "IX_TipoAuditorId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.IdIsaf).HasColumnName("IdISAF");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoAuditorId).HasDefaultValueSql("((1))");
            entity.Property(e => e.UnidadAdministrativaId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.JefeDirecto).WithMany(p => p.InverseJefeDirecto)
                .HasForeignKey(d => d.JefeDirectoId)
                .HasConstraintName("FK_dbo.Auditors_dbo.Auditors_JefeDirectoId");

            entity.HasOne(d => d.TipoAuditor).WithMany(p => p.Auditors)
                .HasForeignKey(d => d.TipoAuditorId)
                .HasConstraintName("FK_dbo.Auditors_dbo.TipoAuditors_TipoAuditorId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Auditors)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Auditors_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<AuditorAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AuditorAuditorias");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.OficioComisionId, "IX_OficioComisionId");

            entity.HasIndex(e => e.OficioNotificacionId, "IX_OficioNotificacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Auditor).WithMany(p => p.AuditorAuditoria)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.AuditorAuditorias_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.AuditorAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.AuditorAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.OficioComision).WithMany(p => p.AuditorAuditoriaOficioComisions)
                .HasForeignKey(d => d.OficioComisionId)
                .HasConstraintName("FK_dbo.AuditorAuditorias_dbo.Oficios_OficioComisionId");

            entity.HasOne(d => d.OficioNotificacion).WithMany(p => p.AuditorAuditoriaOficioNotificacions)
                .HasForeignKey(d => d.OficioNotificacionId)
                .HasConstraintName("FK_dbo.AuditorAuditorias_dbo.Oficios_OficioNotificacionId");
        });

        modelBuilder.Entity<Auditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Auditorias");

            entity.HasIndex(e => e.AuditorEncargadoId, "IX_AuditorEncargadoId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.EquipoId, "IX_Equipo_Id");

            entity.HasIndex(e => e.IdEjercicio, "IX_IdEjercicio");

            entity.HasIndex(e => e.ModoEjecucionId, "IX_ModoEjecucionId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.HasIndex(e => e.StatusAuditoriaId, "IX_StatusAuditoriaId");

            entity.HasIndex(e => e.TipoAuditoria, "IX_TipoAuditoria");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.HasIndex(e => e.UnidadAdministrativaId1, "IX_UnidadAdministrativa_Id");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EquipoId).HasColumnName("Equipo_Id");
            entity.Property(e => e.FechaActaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PeriodoId).HasDefaultValueSql("((3))");
            entity.Property(e => e.StatusAuditoriaId).HasDefaultValueSql("((3))");
            entity.Property(e => e.UnidadAdministrativaId1).HasColumnName("UnidadAdministrativa_Id");

            entity.HasOne(d => d.AuditorEncargado).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.AuditorEncargadoId)
                .HasConstraintName("FK_dbo.Auditorias_dbo.Auditors_AuditorEncargadoId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Auditorias_dbo.Entes_EnteId");

            entity.HasOne(d => d.Equipo).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.EquipoId)
                .HasConstraintName("FK_dbo.Auditorias_dbo.Equipoes_Equipo_Id");

            entity.HasOne(d => d.IdEjercicioNavigation).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.IdEjercicio)
                .HasConstraintName("FK_dbo.Auditorias_dbo.Ejercicios_IdEjercicio");

            entity.HasOne(d => d.ModoEjecucion).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.ModoEjecucionId)
                .HasConstraintName("FK_dbo.Auditorias_dbo.ModoEjecucions_ModoEjecucionId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Auditorias_dbo.Periodos_PeriodoId");

            entity.HasOne(d => d.StatusAuditoria).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.StatusAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Auditorias_dbo.StatusAuditorias_StatusAuditoriaId");

            entity.HasOne(d => d.TipoAuditoriaNavigation).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.TipoAuditoria)
                .HasConstraintName("FK_dbo.Auditorias_dbo.TipoAuditorias_TipoAuditoria");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.AuditoriaUnidadAdministrativas)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Auditorias_dbo.UnidadAdministrativas_UnidadAdministrativaId");

            entity.HasOne(d => d.UnidadAdministrativaId1Navigation).WithMany(p => p.AuditoriaUnidadAdministrativaId1Navigations)
                .HasForeignKey(d => d.UnidadAdministrativaId1)
                .HasConstraintName("FK_dbo.Auditorias_dbo.UnidadAdministrativas_UnidadAdministrativa_Id");
        });

        modelBuilder.Entity<AuditoriaPpra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AuditoriaPPRAs");

            entity.ToTable("AuditoriaPPRAs");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.AuditoriaPpras)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.AuditoriaPPRAs_dbo.Auditorias_AuditoriaId");
        });

        modelBuilder.Entity<AuditoriasFuncionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AuditoriasFuncionarios");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.AuditoriasFuncionarios)
                .HasForeignKey(d => d.AuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AuditoriasFuncionarios_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.AuditoriasFuncionarios)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AuditoriasFuncionarios_dbo.Funcionarios_FuncionarioId");
        });

        modelBuilder.Entity<Balanza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Balanzas");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Balanzas)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.Balanzas_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Balanzas)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Balanzas_dbo.Entes_EnteId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Balanzas)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_dbo.Balanzas_dbo.Periodos_PeriodoId");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Balanzas)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Balanzas_dbo.RubrosInformacionFinancieras_RubroId");
        });

        modelBuilder.Entity<Calificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Calificacions");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Calificacions)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.Calificacions_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Calificacions)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Calificacions_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<CalificacionClase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CalificacionClases");

            entity.HasIndex(e => e.CalificacionesGlobalesId, "IX_CalificacionesGlobalesId");

            entity.HasIndex(e => e.PonderacionId, "IX_Ponderacion_Id");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoClasificacionId, "IX_TipoClasificacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PonderacionId).HasColumnName("Ponderacion_Id");

            entity.HasOne(d => d.CalificacionesGlobales).WithMany(p => p.CalificacionClases)
                .HasForeignKey(d => d.CalificacionesGlobalesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CalificacionClases_dbo.CalificacionesGlobales_CalificacionesGlobalesId");

            entity.HasOne(d => d.PonderacionNavigation).WithMany(p => p.CalificacionClases)
                .HasForeignKey(d => d.PonderacionId)
                .HasConstraintName("FK_dbo.CalificacionClases_dbo.Ponderacions_Ponderacion_Id");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.CalificacionClases)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CalificacionClases_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoClasificacion).WithMany(p => p.CalificacionClases)
                .HasForeignKey(d => d.TipoClasificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CalificacionClases_dbo.TipoClasificacions_TipoClasificacionId");
        });

        modelBuilder.Entity<CalificacionCriterio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CalificacionCriterios");

            entity.HasIndex(e => e.CalificacionClasesId, "IX_CalificacionClasesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.CalificacionClases).WithMany(p => p.CalificacionCriterios)
                .HasForeignKey(d => d.CalificacionClasesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CalificacionCriterios_dbo.CalificacionClases_CalificacionClasesId");
        });

        modelBuilder.Entity<CalificacionDesempeno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CalificacionDesempenoes");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EjercicioId).HasDefaultValueSql("((3))");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.CalificacionDesempenos)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.CalificacionDesempenoes_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Entes).WithMany(p => p.CalificacionDesempenos)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.CalificacionDesempenoes_dbo.Entes_EntesId");
        });

        modelBuilder.Entity<CalificacionesGlobale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CalificacionesGlobales");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.InformesTrimesYcuenPublic).HasColumnName("InformesTrimesYCuenPublic");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.CalificacionesGlobales)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.CalificacionesGlobales_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<Cedula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Cedulas");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.ConceptoId, "IX_Concepto_Id");

            entity.HasIndex(e => e.GrupoRubricasId, "IX_GrupoRubricasId");

            entity.HasIndex(e => e.RubroAuditadoId, "IX_RubroAuditadoId");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.TipoCedulaId, "IX_TipoCedulaId");

            entity.Property(e => e.ConceptoId).HasColumnName("Concepto_Id");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RubroAuditadoId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Auditor).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Concepto).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.ConceptoId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.Conceptoes_Concepto_Id");

            entity.HasOne(d => d.GrupoRubricas).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.GrupoRubricasId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.GrupoRubricas_GrupoRubricasId");

            entity.HasOne(d => d.RubroAuditado).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.RubroAuditadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Cedulas_dbo.RubroAuditados_RubroAuditadoId");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.Rubros_RubroId");

            entity.HasOne(d => d.TipoCedula).WithMany(p => p.Cedulas)
                .HasForeignKey(d => d.TipoCedulaId)
                .HasConstraintName("FK_dbo.Cedulas_dbo.TipoCedulas_TipoCedula_Id");
        });

        modelBuilder.Entity<Clasificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Clasificacions");

            entity.HasIndex(e => e.TipoClasificacionId, "IX_TipoClasificacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoClasificacionId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TipoClasificacion).WithMany(p => p.Clasificacions)
                .HasForeignKey(d => d.TipoClasificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Clasificacions_dbo.TipoClasificacions_TipoClasificacionId");
        });

        modelBuilder.Entity<ClasificacionHallazgo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClasificacionHallazgoes");

            entity.HasIndex(e => e.ClasificacionId, "IX_ClasificacionId");

            entity.HasIndex(e => e.HallazgoId, "IX_HallazgoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Clasificacion).WithMany(p => p.ClasificacionHallazgos)
                .HasForeignKey(d => d.ClasificacionId)
                .HasConstraintName("FK_dbo.ClasificacionHallazgoes_dbo.Clasificacions_ClasificacionId");

            entity.HasOne(d => d.Hallazgo).WithMany(p => p.ClasificacionHallazgos)
                .HasForeignKey(d => d.HallazgoId)
                .HasConstraintName("FK_dbo.ClasificacionHallazgoes_dbo.Hallazgos_HallazgoId");
        });

        modelBuilder.Entity<ClasificacionNoConformidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClasificacionNoConformidads");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClasificacionPlantilla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClasificacionPlantillas");

            entity.HasIndex(e => e.ClasificacionId, "IX_ClasificacionId");

            entity.HasIndex(e => e.PlantillaId, "IX_PlantillaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Clasificacion).WithMany(p => p.ClasificacionPlantillas)
                .HasForeignKey(d => d.ClasificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ClasificacionPlantillas_dbo.Clasificacions_ClasificacionId");

            entity.HasOne(d => d.Plantilla).WithMany(p => p.ClasificacionPlantillas)
                .HasForeignKey(d => d.PlantillaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ClasificacionPlantillas_dbo.Plantillas_PlantillaId");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Clients");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AllowedOrigin).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Comentarios");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.TipoComentariosId, "IX_TipoComentariosId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Comentarios_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.TipoComentarios).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.TipoComentariosId)
                .HasConstraintName("FK_dbo.Comentarios_dbo.TipoComentarios_TipoComentariosId");

            entity.HasOne(d => d.User).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.Comentarios_dbo.Users_UserId");
        });

        modelBuilder.Entity<Concepto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Conceptoes");

            entity.HasIndex(e => e.ObjetoId, "IX_ObjetoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Objeto).WithMany(p => p.Conceptos)
                .HasForeignKey(d => d.ObjetoId)
                .HasConstraintName("FK_dbo.Conceptoes_dbo.Objetoes_ObjetoId");
        });

        modelBuilder.Entity<ConfiguracionInformeResultado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ConfiguracionInformeResultados");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.BprecursosDisponibles).HasColumnName("BPRecursosDisponibles");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.InterpretacionBp).HasColumnName("InterpretacionBP");
            entity.Property(e => e.InterpretacionBpr).HasColumnName("InterpretacionBPR");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PublicacionRf).HasColumnName("PublicacionRF");
            entity.Property(e => e.ResultadoGf).HasColumnName("ResultadoGF");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.ConfiguracionInformeResultados)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BalancePresupuestarioIRs_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.ConfiguracionInformeResultados)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BalancePresupuestarioIRs_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<CopiasOficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CopiasOficios");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.HasIndex(e => e.TipoFuncionariosId, "IX_TipoFuncionarios_Id");

            entity.HasIndex(e => e.TipoOficioId, "IX_TipoOficioId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EntesId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoFuncionariosId).HasColumnName("TipoFuncionarios_Id");

            entity.HasOne(d => d.Entes).WithMany(p => p.CopiasOficios)
                .HasForeignKey(d => d.EntesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CopiasOficios_dbo.Entes_EntesId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.CopiasOficios)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CopiasOficios_dbo.Funcionarios_FuncionarioId");

            entity.HasOne(d => d.TipoFuncionarios).WithMany(p => p.CopiasOficios)
                .HasForeignKey(d => d.TipoFuncionariosId)
                .HasConstraintName("FK_dbo.CopiasOficios_dbo.TipoFuncionarios_TipoFuncionarios_Id");

            entity.HasOne(d => d.TipoOficio).WithMany(p => p.CopiasOficios)
                .HasForeignKey(d => d.TipoOficioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CopiasOficios_dbo.TipoOficios_TipoOficioId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.CopiasOficios)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CopiasOficios_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Counter");

            entity.ToTable("Counter", "HangFire");

            entity.HasIndex(e => e.Key, "IX_HangFire_Counter_Key");

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<CriterioAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CriterioAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.ClasificacionId, "IX_ClasificacionId");

            entity.HasIndex(e => e.PonderacionId, "IX_PonderacionId");

            entity.HasIndex(e => e.PonderacionId1, "IX_Ponderacion_Id");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PonderacionId1).HasColumnName("Ponderacion_Id");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.CriterioAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.CriterioAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Clasificacion).WithMany(p => p.CriterioAuditoria)
                .HasForeignKey(d => d.ClasificacionId)
                .HasConstraintName("FK_dbo.CriterioAuditorias_dbo.Clasificacions_ClasificacionId");

            entity.HasOne(d => d.Ponderacion).WithMany(p => p.CriterioAuditoriaPonderacions)
                .HasForeignKey(d => d.PonderacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CriterioAuditorias_dbo.Ponderacions_PonderacionId");

            entity.HasOne(d => d.PonderacionId1Navigation).WithMany(p => p.CriterioAuditoriaPonderacionId1Navigations)
                .HasForeignKey(d => d.PonderacionId1)
                .HasConstraintName("FK_dbo.CriterioAuditorias_dbo.Ponderacions_Ponderacion_Id");
        });

        modelBuilder.Entity<CriteriosAcreditado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CriteriosAcreditados");

            entity.HasIndex(e => e.ClasificacionId, "IX_ClasificacionId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Clasificacion).WithMany(p => p.CriteriosAcreditados)
                .HasForeignKey(d => d.ClasificacionId)
                .HasConstraintName("FK_dbo.CriteriosAcreditados_dbo.Clasificacions_ClasificacionId");

            entity.HasOne(d => d.Ente).WithMany(p => p.CriteriosAcreditados)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CriteriosAcreditados_dbo.Entes_EnteId");

            entity.HasOne(d => d.Observacion).WithMany(p => p.CriteriosAcreditados)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.CriteriosAcreditados_dbo.Observaciones_ObservacionId");
        });

        modelBuilder.Entity<CriteriosRevisado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CriteriosRevisados");

            entity.HasIndex(e => e.EntesId, "IX_Entes_Id");

            entity.HasIndex(e => e.TipoClasificacionId, "IX_TipoClasificacionId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EntesId).HasColumnName("Entes_Id");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Entes).WithMany(p => p.CriteriosRevisados)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.CriteriosRevisados_dbo.Entes_Entes_Id");

            entity.HasOne(d => d.TipoClasificacion).WithMany(p => p.CriteriosRevisados)
                .HasForeignKey(d => d.TipoClasificacionId)
                .HasConstraintName("FK_dbo.CriteriosRevisados_dbo.TipoClasificacions_TipoClasificacionId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.CriteriosRevisados)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.CriteriosRevisados_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<Cuestionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Cuestionarios");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoCuestionarioId, "IX_TipoCuestionarioId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RubroId).HasDefaultValueSql("((307))");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Cuestionarios)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.Cuestionarios_dbo.Rubros_RubroId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Cuestionarios)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Cuestionarios_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoCuestionario).WithMany(p => p.Cuestionarios)
                .HasForeignKey(d => d.TipoCuestionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Cuestionarios_dbo.TipoCuestionarios_TipoCuestionarioId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.Cuestionarios)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.Cuestionarios_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<CuestionarioAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CuestionarioAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.CuestionarioId, "IX_CuestionarioId");

            entity.HasIndex(e => e.ModifiedBy, "IX_ModifiedBy");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);

            entity.HasOne(d => d.Auditoria).WithMany(p => p.CuestionarioAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CuestionarioAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Cuestionario).WithMany(p => p.CuestionarioAuditoria)
                .HasForeignKey(d => d.CuestionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.CuestionarioAuditorias_dbo.Cuestionarios_CuestionarioId");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CuestionarioAuditoria)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_dbo.CuestionarioAuditorias_dbo.Users_ModifiedBy");
        });

        modelBuilder.Entity<CumplimientoEtca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CumplimientoEtcas");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.EtcasId, "IX_EtcasId");

            entity.HasIndex(e => e.PeriodosId, "IX_PeriodosId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaAnalisis).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.CumplimientoEtcas)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.CumplimientoEtcas_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Entes).WithMany(p => p.CumplimientoEtcas)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.CumplimientoEtcas_dbo.Entes_EntesId");

            entity.HasOne(d => d.Etcas).WithMany(p => p.CumplimientoEtcas)
                .HasForeignKey(d => d.EtcasId)
                .HasConstraintName("FK_dbo.CumplimientoEtcas_dbo.Etcas_EtcasId");

            entity.HasOne(d => d.Periodos).WithMany(p => p.CumplimientoEtcas)
                .HasForeignKey(d => d.PeriodosId)
                .HasConstraintName("FK_dbo.CumplimientoEtcas_dbo.Periodos_PeriodosId");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Cursos");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<CursoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CursoDocumentos");

            entity.HasIndex(e => e.CursoId, "IX_CursoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Curso).WithMany(p => p.CursoDocumentos)
                .HasForeignKey(d => d.CursoId)
                .HasConstraintName("FK_dbo.CursoDocumentos_dbo.Cursos_CursoId");
        });

        modelBuilder.Entity<DatosIndicadore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DatosIndicadores");

            entity.HasIndex(e => e.EjerciciosId, "IX_EjerciciosId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fismunpresupuestado).HasColumnName("FISMUNPresupuestado");
            entity.Property(e => e.Fortamunpresupuestado).HasColumnName("FORTAMUNPresupuestado");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.MontoIafism).HasColumnName("MontoIAFISM");
            entity.Property(e => e.MontoIafortamun).HasColumnName("MontoIAFORTAMUN");
            entity.Property(e => e.TotalFism).HasColumnName("TotalFISM");
            entity.Property(e => e.TotalFortamun).HasColumnName("TotalFORTAMUN");

            entity.HasOne(d => d.Ejercicios).WithMany(p => p.DatosIndicadores)
                .HasForeignKey(d => d.EjerciciosId)
                .HasConstraintName("FK_dbo.DatosIndicadores_dbo.Ejercicios_EjerciciosId");

            entity.HasOne(d => d.Entes).WithMany(p => p.DatosIndicadores)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.DatosIndicadores_dbo.Entes_EntesId");
        });

        modelBuilder.Entity<Deceso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Decesoes");

            entity.Property(e => e.Clave).HasColumnName("CLAVE");
            entity.Property(e => e.Curp).HasColumnName("CURP");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimientoValue).HasColumnType("datetime");
        });

        modelBuilder.Entity<Denuncia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Denuncias");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.HasIndex(e => e.StatusDenunciaId, "IX_StatusDenunciaId");

            entity.HasIndex(e => e.StatusDenunciaId1, "IX_StatusDenuncia_Id");

            entity.HasIndex(e => e.TipoDenunciaId, "IX_TipoDenunciaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.StatusDenunciaId1).HasColumnName("StatusDenuncia_Id");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Denuncia)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.Denuncias_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Denuncia)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Denuncias_dbo.Entes_EnteId");

            entity.HasOne(d => d.Observacion).WithMany(p => p.Denuncia)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.Denuncias_dbo.Observaciones_ObservacionId");

            entity.HasOne(d => d.StatusDenuncia).WithMany(p => p.DenunciaStatusDenuncia)
                .HasForeignKey(d => d.StatusDenunciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Denuncias_dbo.StatusDenuncias_StatusDenunciaId");

            entity.HasOne(d => d.StatusDenunciaId1Navigation).WithMany(p => p.DenunciaStatusDenunciaId1Navigations)
                .HasForeignKey(d => d.StatusDenunciaId1)
                .HasConstraintName("FK_dbo.Denuncias_dbo.StatusDenuncias_StatusDenuncia_Id");

            entity.HasOne(d => d.TipoDenuncia).WithMany(p => p.Denuncia)
                .HasForeignKey(d => d.TipoDenunciaId)
                .HasConstraintName("FK_dbo.Denuncias_dbo.TipoDenuncias_TipoDenunciaId");
        });

        modelBuilder.Entity<DenunciaStatusDenuncia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DenunciaStatusDenuncias");

            entity.HasIndex(e => e.DenunciaId, "IX_DenunciaId");

            entity.HasIndex(e => e.StatusDenunciaId, "IX_StatusDenunciaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Denuncia).WithMany(p => p.DenunciaStatusDenuncia)
                .HasForeignKey(d => d.DenunciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.DenunciaStatusDenuncias_dbo.Denuncias_DenunciaId");

            entity.HasOne(d => d.StatusDenuncia).WithMany(p => p.DenunciaStatusDenunciaNavigation)
                .HasForeignKey(d => d.StatusDenunciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.DenunciaStatusDenuncias_dbo.StatusDenuncias_StatusDenunciaId");
        });

        modelBuilder.Entity<Dependencia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Dependencias");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.Dependencia)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Dependencias_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<DespachosExterno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DespachosExternos");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeudaFormato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DeudaFormatoes");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaContratacion).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.DeudaFormatos)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.DeudaFormatoes_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.DeudaFormatos)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.DeudaFormatoes_dbo.Entes_EnteId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.DeudaFormatos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_dbo.DeudaFormatoes_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Documentos");

            entity.HasIndex(e => e.ObservacionDocumentos, "IX_Observacion_Documentos");

            entity.HasIndex(e => e.PronunciamientoId, "IX_PronunciamientoId");

            entity.HasIndex(e => e.TipoRespuestaId, "IX_TipoRespuestaId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.ObservacionDocumentos).HasColumnName("Observacion_Documentos");
            entity.Property(e => e.TipoRespuestaId).HasDefaultValueSql("((1))");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.ObservacionDocumentosNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.ObservacionDocumentos)
                .HasConstraintName("FK_dbo.Documentos_dbo.Observaciones_Observacion_Documentos");

            entity.HasOne(d => d.Pronunciamiento).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.PronunciamientoId)
                .HasConstraintName("FK_dbo.Documentos_dbo.Pronunciamientoes_PronunciamientoId");

            entity.HasOne(d => d.TipoRespuesta).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.TipoRespuestaId)
                .HasConstraintName("FK_dbo.Documentos_dbo.TipoRespuestas_TipoRespuestaId");

            entity.HasOne(d => d.User).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.Documentos_dbo.Users_UserId");
        });

        modelBuilder.Entity<DocumentosExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DocumentosExpedientes");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.FormatoDocumentoId, "IX_FormatoDocumentoId");

            entity.HasIndex(e => e.TipoDocumentoId, "IX_TipoDocumentoId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Expediente).WithMany(p => p.DocumentosExpedientes)
                .HasForeignKey(d => d.ExpedienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.DocumentosExpedientes_dbo.Expedientes_ExpedienteId");

            entity.HasOne(d => d.FormatoDocumento).WithMany(p => p.DocumentosExpedientes)
                .HasForeignKey(d => d.FormatoDocumentoId)
                .HasConstraintName("FK_dbo.DocumentosExpedientes_dbo.FormatosDocumentoes_FormatoDocumentoId");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.DocumentosExpedientes)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_dbo.DocumentosExpedientes_dbo.TiposDocumentoes_TipoDocumentoId");

            entity.HasOne(d => d.User).WithMany(p => p.DocumentosExpedientes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.DocumentosExpedientes_dbo.Users_UserId");
        });

        modelBuilder.Entity<Egreso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Egresos");

            entity.HasIndex(e => e.DependenciaId, "IX_DependenciaId");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PartidaId, "IX_PartidaId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoEgreso).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Dependencia).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.DependenciaId)
                .HasConstraintName("FK_dbo.Egresos_dbo.Dependencias_DependenciaId");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Egresos_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Egresos_dbo.Entes_EnteId");

            entity.HasOne(d => d.Partida).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.PartidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Egresos_dbo.Partidas_PartidaId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Egresos_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<Ejercicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Ejercicios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Encuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Encuestas");

            entity.Property(e => e.Ageb).HasColumnName("AGEB");
            entity.Property(e => e.BrewId).HasColumnName("Brew_Id");
            entity.Property(e => e.EjercicioId)
                .HasDefaultValueSql("((3))")
                .HasColumnName("EjercicioID");
            entity.Property(e => e.LinearScale14).HasColumnName("LinearScale_1_4");
            entity.Property(e => e.LinearScale24).HasColumnName("LinearScale_2_4");
            entity.Property(e => e.LinearScale34).HasColumnName("LinearScale_3_4");
            entity.Property(e => e.LinearScale44).HasColumnName("LinearScale_4_4");
            entity.Property(e => e.LinearScale45).HasColumnName("LinearScale_4_5");
            entity.Property(e => e.LinearScale54).HasColumnName("LinearScale_5_4");
            entity.Property(e => e.LinearScale64).HasColumnName("LinearScale_6_4");
            entity.Property(e => e.LinearScale74).HasColumnName("LinearScale_7_4");
            entity.Property(e => e.LinearScale84).HasColumnName("LinearScale_8_4");
            entity.Property(e => e.MonkeyId).HasColumnName("Monkey_Id");
            entity.Property(e => e.SingleChoice11).HasColumnName("SingleChoice_1_1");
            entity.Property(e => e.SingleChoice12).HasColumnName("SingleChoice_1_2");
            entity.Property(e => e.SingleChoice13).HasColumnName("SingleChoice_1_3");
            entity.Property(e => e.SingleChoice21).HasColumnName("SingleChoice_2_1");
            entity.Property(e => e.SingleChoice22).HasColumnName("SingleChoice_2_2");
            entity.Property(e => e.SingleChoice23).HasColumnName("SingleChoice_2_3");
            entity.Property(e => e.SingleChoice31).HasColumnName("SingleChoice_3_1");
            entity.Property(e => e.SingleChoice32).HasColumnName("SingleChoice_3_2");
            entity.Property(e => e.SingleChoice33).HasColumnName("SingleChoice_3_3");
            entity.Property(e => e.SingleChoice41).HasColumnName("SingleChoice_4_1");
            entity.Property(e => e.SingleChoice42).HasColumnName("SingleChoice_4_2");
            entity.Property(e => e.SingleChoice43).HasColumnName("SingleChoice_4_3");
            entity.Property(e => e.SingleChoice51).HasColumnName("SingleChoice_5_1");
            entity.Property(e => e.SingleChoice52).HasColumnName("SingleChoice_5_2");
            entity.Property(e => e.SingleChoice53).HasColumnName("SingleChoice_5_3");
            entity.Property(e => e.SingleChoice61).HasColumnName("SingleChoice_6_1");
            entity.Property(e => e.SingleChoice62).HasColumnName("SingleChoice_6_2");
            entity.Property(e => e.SingleChoice63).HasColumnName("SingleChoice_6_3");
            entity.Property(e => e.SingleChoice71).HasColumnName("SingleChoice_7_1");
            entity.Property(e => e.SingleChoice72).HasColumnName("SingleChoice_7_2");
            entity.Property(e => e.SingleChoice73).HasColumnName("SingleChoice_7_3");
            entity.Property(e => e.SingleChoice81).HasColumnName("SingleChoice_8_1");
            entity.Property(e => e.SingleChoice82).HasColumnName("SingleChoice_8_2");
            entity.Property(e => e.SingleChoice83).HasColumnName("SingleChoice_8_3");
            entity.Property(e => e.SingleChoice91).HasColumnName("SingleChoice_9_1");
            entity.Property(e => e.SingleChoice93).HasColumnName("SingleChoice_9_3");
            entity.Property(e => e.SingleChoice95).HasColumnName("SingleChoice_9_5");
            entity.Property(e => e.SingleChoice97).HasColumnName("SingleChoice_9_7");
            entity.Property(e => e.SingleChoice991).HasColumnName("SingleChoice_9_9_1");
            entity.Property(e => e.SingleChoice992).HasColumnName("SingleChoice_9_9_2");
            entity.Property(e => e.SingleChoice993).HasColumnName("SingleChoice_9_9_3");
            entity.Property(e => e.Text92).HasColumnName("Text_9_2");
            entity.Property(e => e.Text94).HasColumnName("Text_9_4");
            entity.Property(e => e.Text96).HasColumnName("Text_9_6");
            entity.Property(e => e.Text98).HasColumnName("Text_9_8");
        });

        modelBuilder.Entity<Ente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Entes");

            entity.HasIndex(e => e.EntesTipoEnte, "IX_Entes_TipoEnte");

            entity.HasIndex(e => e.ParamunicipalDe, "IX_ParamunicipalDe");

            entity.Property(e => e.ClaveIne).HasColumnName("ClaveINE");
            entity.Property(e => e.ClaveInegi).HasColumnName("ClaveINEGI");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EntesTipoEnte).HasColumnName("Entes_TipoEnte");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.ParamunicipalDe).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.EntesTipoEnteNavigation).WithMany(p => p.Entes)
                .HasForeignKey(d => d.EntesTipoEnte)
                .HasConstraintName("FK_dbo.Entes_dbo.TipoEntes_Entes_TipoEnte");

            entity.HasOne(d => d.ParamunicipalDeNavigation).WithMany(p => p.InverseParamunicipalDeNavigation)
                .HasForeignKey(d => d.ParamunicipalDe)
                .HasConstraintName("FK_dbo.Entes_dbo.Entes_ParamunicipalDe");
        });

        modelBuilder.Entity<EnteCalificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EnteCalificacions");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.AuditoriaOp).HasColumnName("AuditoriaOP");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.EnteCalificacions)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.EnteCalificacions_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.EnteCalificacions)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.EnteCalificacions_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Equipoes");

            entity.HasIndex(e => e.AreaId, "IX_AreaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Area).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_dbo.Equipoes_dbo.Areas_AreaId");
        });

        modelBuilder.Entity<EquipoAuditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EquipoAuditors");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.EquipoId, "IX_EquipoId");

            entity.HasOne(d => d.Auditor).WithMany(p => p.EquipoAuditors)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.EquipoAuditors_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Equipo).WithMany(p => p.EquipoAuditors)
                .HasForeignKey(d => d.EquipoId)
                .HasConstraintName("FK_dbo.EquipoAuditors_dbo.Equipoes_EquipoId");
        });

        modelBuilder.Entity<EquipoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EquipoAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.EquipoId, "IX_EquipoId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.EquipoAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.EquipoAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Equipo).WithMany(p => p.EquipoAuditoria)
                .HasForeignKey(d => d.EquipoId)
                .HasConstraintName("FK_dbo.EquipoAuditorias_dbo.Equipoes_EquipoId");
        });

        modelBuilder.Entity<EtapasAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EtapasAuditorias");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Etca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Etcas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<EtcasTipoEnte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EtcasTipoEntes");

            entity.HasIndex(e => e.EtcasId, "IX_EtcasId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Etcas).WithMany(p => p.EtcasTipoEntes)
                .HasForeignKey(d => d.EtcasId)
                .HasConstraintName("FK_dbo.EtcasTipoEntes_dbo.Etcas_EtcasId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.EtcasTipoEntes)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.EtcasTipoEntes_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Expedientes");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.ObservacionId, "IX_Observacion_Id");

            entity.HasIndex(e => e.ObservacionesId, "IX_Observaciones_Id");

            entity.HasIndex(e => e.StatusExpedienteId, "IX_StatusExpedienteId");

            entity.HasIndex(e => e.TiposExpedienteId, "IX_TiposExpedienteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaActo).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.ObservacionId).HasColumnName("Observacion_Id");
            entity.Property(e => e.ObservacionesId).HasColumnName("Observaciones_Id");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Expedientes_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Expedientes_dbo.Entes_EnteId");

            entity.HasOne(d => d.Observaciones).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.ObservacionesId)
                .HasConstraintName("FK_dbo.Expedientes_dbo.Observaciones_Observaciones_Id");

            entity.HasOne(d => d.StatusExpediente).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.StatusExpedienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Expedientes_dbo.StatusExpedientes_StatusExpedienteId");

            entity.HasOne(d => d.TiposExpediente).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.TiposExpedienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Expedientes_dbo.TiposExpedientes_TiposExpedienteId");
        });

        modelBuilder.Entity<ExpedienteMovimientosExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ExpedienteMovimientosExpedientes");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.MovimientosExpedienteId, "IX_MovimientosExpedienteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.Expediente).WithMany(p => p.ExpedienteMovimientosExpedientes)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.ExpedienteMovimientosExpedientes_dbo.Expedientes_ExpedienteId");
        });

        modelBuilder.Entity<ExpedienteObservacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ExpedienteObservacions");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Expediente).WithMany(p => p.ExpedienteObservacions)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.ExpedienteObservacions_dbo.Expedientes_ExpedienteId");

            entity.HasOne(d => d.Observacion).WithMany(p => p.ExpedienteObservacions)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.ExpedienteObservacions_dbo.Observaciones_ObservacionId");
        });

        modelBuilder.Entity<ExpedienteStatusExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ExpedienteStatusExpedientes");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.StatusExpedienteId, "IX_StatusExpedienteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaNotificado).HasColumnType("datetime");

            entity.HasOne(d => d.Expediente).WithMany(p => p.ExpedienteStatusExpedientes)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.ExpedienteStatusExpedientes_dbo.Expedientes_ExpedienteId");

            entity.HasOne(d => d.StatusExpediente).WithMany(p => p.ExpedienteStatusExpedientes)
                .HasForeignKey(d => d.StatusExpedienteId)
                .HasConstraintName("FK_dbo.ExpedienteStatusExpedientes_dbo.StatusExpedientes_StatusExpedienteId");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Facturas");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Facturas_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<FechaControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FechaControls");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.AuditoriasId, "IX_Auditorias_Id");

            entity.HasIndex(e => e.TipoControlId, "IX_TipoControlId");

            entity.Property(e => e.AuditoriasId).HasColumnName("Auditorias_Id");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.FechaControlAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.FechaControls_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Auditorias).WithMany(p => p.FechaControlAuditorias)
                .HasForeignKey(d => d.AuditoriasId)
                .HasConstraintName("FK_dbo.FechaControls_dbo.Auditorias_Auditorias_Id");

            entity.HasOne(d => d.TipoControl).WithMany(p => p.FechaControls)
                .HasForeignKey(d => d.TipoControlId)
                .HasConstraintName("FK_dbo.FechaControls_dbo.TipoControls_TipoControlId");
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Folders");

            entity.HasIndex(e => e.AnexoId, "IX_Anexo_Id");

            entity.HasIndex(e => e.AuditoriaId, "IX_Auditoria_Id");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.ParentFolderId, "IX_Parent_Folder_Id");

            entity.Property(e => e.AnexoId).HasColumnName("Anexo_Id");
            entity.Property(e => e.AuditoriaId).HasColumnName("Auditoria_Id");
            entity.Property(e => e.ContainerName).HasColumnName("Container_Name");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(128)
                .HasDefaultValueSql("('97b0f137-c536-42bc-ae26-432437f44311')");
            entity.Property(e => e.ParentFolderId).HasColumnName("Parent_Folder_Id");

            entity.HasOne(d => d.Anexo).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AnexoId)
                .HasConstraintName("FK_dbo.Folders_dbo.Anexoes_Anexo_Id");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Folders_dbo.Auditorias_Auditoria_Id");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.Folders)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Folders_dbo.Users_CreatedById");

            entity.HasOne(d => d.ParentFolder).WithMany(p => p.InverseParentFolder)
                .HasForeignKey(d => d.ParentFolderId)
                .HasConstraintName("FK_dbo.Folders_dbo.Folders_Parent_Folder_Id");
        });

        modelBuilder.Entity<FondosFederale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FondosFederales");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<FondosFederalesRecibido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FondosFederalesRecibidos");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.FondosFederalesId, "IX_FondosFederalesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.FondosFederalesRecibidos)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.FondosFederalesRecibidos_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.FondosFederales).WithMany(p => p.FondosFederalesRecibidos)
                .HasForeignKey(d => d.FondosFederalesId)
                .HasConstraintName("FK_dbo.FondosFederalesRecibidos_dbo.FondosFederales_FondosFederalesId");
        });

        modelBuilder.Entity<Formato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Formatos");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Formato1).HasColumnName("Formato");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Publico)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.Formatos)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.FormatosInformes_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<FormatosDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FormatosDocumentoes");

            entity.HasIndex(e => e.TiposDocumentoId, "IX_TiposDocumentoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TiposDocumento).WithMany(p => p.FormatosDocumentos)
                .HasForeignKey(d => d.TiposDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.FormatosDocumentoes_dbo.TiposDocumentoes_TiposDocumentoId");
        });

        modelBuilder.Entity<FormatosDocumentosdeTrabajo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FormatosDocumentosdeTrabajoes");

            entity.HasIndex(e => e.EtapasAuditoriaId, "IX_EtapasAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.EtapasAuditoria).WithMany(p => p.FormatosDocumentosdeTrabajos)
                .HasForeignKey(d => d.EtapasAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.FormatosDocumentosdeTrabajoes_dbo.EtapasAuditorias_EtapasAuditoriaId");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Funcionarios");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.TipoFuncionarioId, "IX_TipoFuncionarioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaNombramiento).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoFuncionarioId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Ente).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Funcionarios_dbo.Entes_EnteId");

            entity.HasOne(d => d.TipoFuncionario).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.TipoFuncionarioId)
                .HasConstraintName("FK_dbo.Funcionarios_dbo.TipoFuncionarios_TipoFuncionarioId");
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Gastoes");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.ObjetoId, "IX_ObjetoId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PeriodoId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Gastoes_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Gastoes_dbo.Entes_EnteId");

            entity.HasOne(d => d.Objeto).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.ObjetoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Gastoes_dbo.Objetoes_ObjetoId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Gastoes_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<GastoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GastoAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.GastoId, "IX_GastoId");

            entity.HasIndex(e => e.RevisionId, "IX_RevisionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RevisionId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.GastoAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.GastoAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Gasto).WithMany(p => p.GastoAuditoria)
                .HasForeignKey(d => d.GastoId)
                .HasConstraintName("FK_dbo.GastoAuditorias_dbo.Gastoes_GastoId");

            entity.HasOne(d => d.Revision).WithMany(p => p.GastoAuditoria)
                .HasForeignKey(d => d.RevisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.GastoAuditorias_dbo.Revisiones_RevisionId");
        });

        modelBuilder.Entity<Gramatica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Gramaticas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<GrupoRubrica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GrupoRubricas");
        });

        modelBuilder.Entity<GrupoRubricasAuditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GrupoRubricasAuditors");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.GrupoRubricasId, "IX_GrupoRubricasId");

            entity.HasIndex(e => e.TipoRubricaId, "IX_TipoRubricaId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Auditor).WithMany(p => p.GrupoRubricasAuditors)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.GrupoRubricasAuditors_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.GrupoRubricas).WithMany(p => p.GrupoRubricasAuditors)
                .HasForeignKey(d => d.GrupoRubricasId)
                .HasConstraintName("FK_dbo.GrupoRubricasAuditors_dbo.GrupoRubricas_GrupoRubricasId");

            entity.HasOne(d => d.TipoRubrica).WithMany(p => p.GrupoRubricasAuditors)
                .HasForeignKey(d => d.TipoRubricaId)
                .HasConstraintName("FK_dbo.GrupoRubricasAuditors_dbo.TipoRubricas_TipoRubricaId");
        });

        modelBuilder.Entity<Hallazgo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Hallazgos");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.GrupoRubricasId, "IX_GrupoRubricasId");

            entity.HasIndex(e => e.HijoId, "IX_HijoId");

            entity.HasIndex(e => e.NormatividadId, "IX_NormatividadId");

            entity.HasIndex(e => e.PadreId, "IX_PadreId");

            entity.HasIndex(e => e.PlantillaId, "IX_PlantillaId");

            entity.HasIndex(e => e.RespuestaId, "IX_RespuestaId");

            entity.HasIndex(e => e.RubroAuditadoId, "IX_RubroAuditadoId");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.TipoObservacionId, "IX_TipoObservacionId");

            entity.Property(e => e.AdjuntoHtml).HasColumnName("AdjuntoHTML");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RubroAuditadoId).HasDefaultValueSql("((1))");
            entity.Property(e => e.TipoObservacionId).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.Auditor).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.GrupoRubricas).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.GrupoRubricasId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.GrupoRubricas_GrupoRubricasId");

            entity.HasOne(d => d.Hijo).WithMany(p => p.InverseHijo)
                .HasForeignKey(d => d.HijoId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Hallazgos_HijoId");

            entity.HasOne(d => d.NormatividadNavigation).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.NormatividadId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Normatividads_NormatividadId");

            entity.HasOne(d => d.Padre).WithMany(p => p.InversePadre)
                .HasForeignKey(d => d.PadreId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Hallazgos_PadreId");

            entity.HasOne(d => d.Plantilla).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.PlantillaId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Plantillas_PlantillaId");

            entity.HasOne(d => d.Respuesta).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.RespuestaId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Respuestas_RespuestaId");

            entity.HasOne(d => d.RubroAuditado).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.RubroAuditadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.RubroAuditados_RubroAuditadoId");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.Rubros_RubroId");

            entity.HasOne(d => d.TipoObservacion).WithMany(p => p.Hallazgos)
                .HasForeignKey(d => d.TipoObservacionId)
                .HasConstraintName("FK_dbo.Hallazgos_dbo.TipoObservacions_TipoObservacionId");
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Hash");

            entity.ToTable("Hash", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt");

            entity.HasIndex(e => e.Key, "IX_HangFire_Hash_Key");

            entity.HasIndex(e => new { e.Key, e.Field }, "UX_HangFire_Hash_Key_Field").IsUnique();

            entity.Property(e => e.Field).HasMaxLength(100);
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<ImporteObservacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ImporteObservaciones");

            entity.HasIndex(e => e.ObservacionesId, "IX_ObservacionesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Observaciones).WithMany(p => p.ImporteObservaciones)
                .HasForeignKey(d => d.ObservacionesId)
                .HasConstraintName("FK_dbo.ImporteObservaciones_dbo.Observaciones_ObservacionesId");
        });

        modelBuilder.Entity<ImportesAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ImportesAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.CalificacionId, "IX_CalificacionId");

            entity.HasIndex(e => e.CalificacionId1, "IX_Calificacion_Id");

            entity.Property(e => e.CalificacionId1).HasColumnName("Calificacion_Id");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.ImportesAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.ImportesAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Calificacion).WithMany(p => p.ImportesAuditoriaCalificacions)
                .HasForeignKey(d => d.CalificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ImportesAuditorias_dbo.Calificacions_CalificacionId");

            entity.HasOne(d => d.CalificacionId1Navigation).WithMany(p => p.ImportesAuditoriaCalificacionId1Navigations)
                .HasForeignKey(d => d.CalificacionId1)
                .HasConstraintName("FK_dbo.ImportesAuditorias_dbo.Calificacions_Calificacion_Id");
        });

        modelBuilder.Entity<InformacionFinanciera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.InformacionFinancieras");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.FormatoId, "IX_FormatoId");

            entity.HasIndex(e => e.InformacionTrimestralId, "IX_InformacionTrimestralId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.InformacionFinancieras)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformacionFinancieras_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.InformacionFinancieras)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformacionFinancieras_dbo.Entes_EnteId");

            entity.HasOne(d => d.Formato).WithMany(p => p.InformacionFinancieras)
                .HasForeignKey(d => d.FormatoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformacionFinancieras_dbo.Formatos_FormatoId");

            entity.HasOne(d => d.InformacionTrimestral).WithMany(p => p.InformacionFinancieras)
                .HasForeignKey(d => d.InformacionTrimestralId)
                .HasConstraintName("FK_dbo.InformacionFinancieras_dbo.InformacionTrimestralEntregadas_InformacionTrimestralId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.InformacionFinancieras)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformacionFinancieras_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<InformacionTrimestralEntregada>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.InformacionTrimestralEntregadas");

            entity.HasIndex(e => e.EjerciciosId, "IX_EjerciciosId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.PeriodosId, "IX_PeriodosId");

            entity.Property(e => e.ComentariosApartadoIi).HasColumnName("ComentariosApartadoII");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicios).WithMany(p => p.InformacionTrimestralEntregada)
                .HasForeignKey(d => d.EjerciciosId)
                .HasConstraintName("FK_dbo.InformacionTrimestralEntregadas_dbo.Ejercicios_EjerciciosId");

            entity.HasOne(d => d.Entes).WithMany(p => p.InformacionTrimestralEntregada)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.InformacionTrimestralEntregadas_dbo.Entes_EntesId");

            entity.HasOne(d => d.Periodos).WithMany(p => p.InformacionTrimestralEntregada)
                .HasForeignKey(d => d.PeriodosId)
                .HasConstraintName("FK_dbo.InformacionTrimestralEntregadas_dbo.Periodos_PeriodosId");
        });

        modelBuilder.Entity<Informe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Informes");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.FondoFederalId, "IX_FondoFederalId");

            entity.HasIndex(e => e.RevisionId, "IX_RevisionId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoDictamenId, "IX_TipoDictamenId");

            entity.HasIndex(e => e.TipoInformeId, "IX_TipoInformeId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Informe1).HasColumnName("Informe");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoInformeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.VisibleEnSitioWeb)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Informes)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Informes_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Informes)
                .HasForeignKey(d => d.EjercicioId)
                .HasConstraintName("FK_dbo.Informes_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Informes)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Informes_dbo.Entes_EnteId");

            entity.HasOne(d => d.FondoFederal).WithMany(p => p.Informes)
                .HasForeignKey(d => d.FondoFederalId)
                .HasConstraintName("FK_dbo.Informes_dbo.FondosFederales_FondoFederalId");

            entity.HasOne(d => d.Revision).WithMany(p => p.Informes)
                .HasForeignKey(d => d.RevisionId)
                .HasConstraintName("FK_dbo.Informes_dbo.Revisiones_RevisionId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Informes)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Informes_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoDictamen).WithMany(p => p.Informes)
                .HasForeignKey(d => d.TipoDictamenId)
                .HasConstraintName("FK_dbo.Informes_dbo.TipoDictamen_TipoDictamenId");

            entity.HasOne(d => d.TipoInforme).WithMany(p => p.Informes)
                .HasForeignKey(d => d.TipoInformeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Informes_dbo.TipoInformes_TipoInformeId");
        });

        modelBuilder.Entity<InformeSeccionesInforme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.InformeSeccionesInformes");

            entity.HasIndex(e => e.InformeId, "IX_InformeId");

            entity.HasIndex(e => e.SeccionesInformesId, "IX_SeccionesInformesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Informe).WithMany(p => p.InformeSeccionesInformes)
                .HasForeignKey(d => d.InformeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformeSeccionesInformes_dbo.Informes_InformeId");

            entity.HasOne(d => d.SeccionesInformes).WithMany(p => p.InformeSeccionesInformes)
                .HasForeignKey(d => d.SeccionesInformesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InformeSeccionesInformes_dbo.SeccionesInformes_SeccionesInformesId");
        });

        modelBuilder.Entity<Ingreso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Ingresos");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PartidaId, "IX_PartidaId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingresos_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingresos_dbo.Entes_EnteId");

            entity.HasOne(d => d.Partida).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.PartidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingresos_dbo.Partidas_PartidaId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingresos_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<IngresoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.IngresoAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.ObjetoId, "IX_ObjetoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.IngresoAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.IngresoAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Objeto).WithMany(p => p.IngresoAuditoria)
                .HasForeignKey(d => d.ObjetoId)
                .HasConstraintName("FK_dbo.IngresoAuditorias_dbo.Objetoes_ObjetoId");
        });

        modelBuilder.Entity<Inhabile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Inhabiles");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Dia).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.ToTable("Job", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_JobParameter");

            entity.ToTable("JobParameter", "HangFire");

            entity.HasIndex(e => new { e.JobId, e.Name }, "IX_HangFire_JobParameter_JobIdAndName");

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_JobQueue");

            entity.ToTable("JobQueue", "HangFire");

            entity.HasIndex(e => new { e.Queue, e.FetchedAt }, "IX_HangFire_JobQueue_QueueAndFetchedAt");

            entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            entity.Property(e => e.Queue).HasMaxLength(50);
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_List");

            entity.ToTable("List", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt");

            entity.HasIndex(e => e.Key, "IX_HangFire_List_Key");

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Lista69B>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Lista69B");

            entity.ToTable("Lista69B");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaSat)
                .HasColumnType("datetime")
                .HasColumnName("FechaSAT");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Lista69Bdetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Lista69BDetalle");

            entity.ToTable("Lista69BDetalle");

            entity.HasIndex(e => e.Lista69Bid, "IX_Lista69BId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Lista69Bid).HasColumnName("Lista69BId");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.NooficioglobalDefinitivosDof).HasColumnName("Nooficioglobal_definitivos_DOF");
            entity.Property(e => e.NooficioglobalDefinitivosSat).HasColumnName("Nooficioglobal_definitivos_SAT");
            entity.Property(e => e.NooficioglobalDesvirtuaronDof).HasColumnName("Nooficioglobal_desvirtuaron_DOF");
            entity.Property(e => e.NooficioglobalDesvirtuaronSat).HasColumnName("Nooficioglobal_desvirtuaron_SAT");
            entity.Property(e => e.NooficioglobalPresuncionDof).HasColumnName("Nooficioglobal_presuncion_DOF");
            entity.Property(e => e.NooficioglobalPresuncionSat).HasColumnName("Nooficioglobal_presuncion_SAT");
            entity.Property(e => e.NooficioglobalSentenciaFavorableDof).HasColumnName("Nooficioglobal_sentencia_favorable_DOF");
            entity.Property(e => e.NooficioglobalSentenciaFavorableSat).HasColumnName("Nooficioglobal_sentencia_favorable_SAT");
            entity.Property(e => e.PDofDefinitivos).HasColumnName("pDOF_definitivos");
            entity.Property(e => e.PDofDesvirtuados).HasColumnName("pDOF_desvirtuados");
            entity.Property(e => e.PDofPresuntos).HasColumnName("pDOF_presuntos");
            entity.Property(e => e.PDofSentenciaFavorable).HasColumnName("pDOF_sentencia_favorable");
            entity.Property(e => e.PpDefinitivos).HasColumnName("pp_definitivos");
            entity.Property(e => e.PpDesvirtuados).HasColumnName("pp_desvirtuados");
            entity.Property(e => e.PpPresuntos).HasColumnName("pp_presuntos");
            entity.Property(e => e.PpSentenciaFavorable).HasColumnName("pp_sentencia_favorable");
            entity.Property(e => e.Rfc).HasColumnName("RFC");

            entity.HasOne(d => d.Lista69B).WithMany(p => p.Lista69Bdetalles)
                .HasForeignKey(d => d.Lista69Bid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Lista69BDetalle_dbo.Lista69B_Lista69BId");
        });

        modelBuilder.Entity<LogMetadatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LogMetadata");

            entity.HasIndex(e => e.AuditLogId, "IX_AuditLogId");

            entity.HasOne(d => d.AuditLog).WithMany(p => p.LogMetadata)
                .HasForeignKey(d => d.AuditLogId)
                .HasConstraintName("FK_dbo.LogMetadata_dbo.AuditLogs_AuditLogId");
        });

        modelBuilder.Entity<LogStorageFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LogStorageFiles");

            entity.HasIndex(e => e.AuditoriasId, "IX_AuditoriasId");

            entity.HasIndex(e => e.UsuarioId, "IX_UsuarioId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasMaxLength(128);

            entity.HasOne(d => d.Auditorias).WithMany(p => p.LogStorageFiles)
                .HasForeignKey(d => d.AuditoriasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.LogStorageFiles_dbo.Auditorias_AuditoriasId");

            entity.HasOne(d => d.Usuario).WithMany(p => p.LogStorageFiles)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_dbo.LogStorageFiles_dbo.Users_UsuarioId");
        });

        modelBuilder.Entity<Medio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Medios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemoPlaneacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MemoPlaneacions");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.MemoPlaneacions)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.MemoPlaneacions_dbo.Auditorias_AuditoriaId");
        });

        modelBuilder.Entity<Memorandum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Memoranda");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Memoranda)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Memoranda_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Memoranda)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .HasConstraintName("FK_dbo.Memoranda_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<MemorandumSeccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MemorandumSecciones");

            entity.HasIndex(e => e.GrupoRubricasId, "IX_GrupoRubricasId");

            entity.HasIndex(e => e.MemoPlaneacionId, "IX_MemoPlaneacion_Id");

            entity.HasIndex(e => e.RevisionId, "IX_RevisionId");

            entity.HasIndex(e => e.SeccionMemorandumId, "IX_SeccionMemorandumId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.MemoPlaneacionId).HasColumnName("MemoPlaneacion_Id");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.GrupoRubricas).WithMany(p => p.MemorandumSecciones)
                .HasForeignKey(d => d.GrupoRubricasId)
                .HasConstraintName("FK_dbo.MemorandumSecciones_dbo.GrupoRubricas_GrupoRubricasId");

            entity.HasOne(d => d.MemoPlaneacion).WithMany(p => p.MemorandumSecciones)
                .HasForeignKey(d => d.MemoPlaneacionId)
                .HasConstraintName("FK_dbo.MemorandumSecciones_dbo.MemoPlaneacions_MemoPlaneacion_Id");

            entity.HasOne(d => d.Revision).WithMany(p => p.MemorandumSecciones)
                .HasForeignKey(d => d.RevisionId)
                .HasConstraintName("FK_dbo.MemorandumSecciones_dbo.Revisiones_RevisionId");

            entity.HasOne(d => d.SeccionMemorandum).WithMany(p => p.MemorandumSecciones)
                .HasForeignKey(d => d.SeccionMemorandumId)
                .HasConstraintName("FK_dbo.MemorandumSecciones_dbo.SeccionMemorandums_SeccionMemorandumId");
        });

        modelBuilder.Entity<Meta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Metas");

            entity.HasIndex(e => e.DependenciaId, "IX_DependenciaId");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Dependencia).WithMany(p => p.Meta)
                .HasForeignKey(d => d.DependenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Metas_dbo.Dependencias_DependenciaId");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Meta)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Metas_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Meta)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Metas_dbo.Entes_EnteId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Meta)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Metas_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<ModoEjecucion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ModoEjecucions");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<MovimientosExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MovimientosExpedientes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<NoConformidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.NoConformidads");

            entity.HasIndex(e => e.ApartadoId, "IX_ApartadoId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.ClasificacionNoConformidadId, "IX_ClasificacionNoConformidadId");

            entity.HasIndex(e => e.RubroAuditadoId, "IX_RubroAuditadoId");

            entity.HasIndex(e => e.StatusNoConformidadId, "IX_StatusNoConformidadId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Apartado).WithMany(p => p.NoConformidads)
                .HasForeignKey(d => d.ApartadoId)
                .HasConstraintName("FK_dbo.NoConformidads_dbo.Apartadoes_ApartadoId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.NoConformidads)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.NoConformidads_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.ClasificacionNoConformidad).WithMany(p => p.NoConformidads)
                .HasForeignKey(d => d.ClasificacionNoConformidadId)
                .HasConstraintName("FK_dbo.NoConformidads_dbo.ClasificacionNoConformidads_ClasificacionNoConformidadId");

            entity.HasOne(d => d.RubroAuditado).WithMany(p => p.NoConformidads)
                .HasForeignKey(d => d.RubroAuditadoId)
                .HasConstraintName("FK_dbo.NoConformidads_dbo.RubroAuditados_RubroAuditadoId");

            entity.HasOne(d => d.StatusNoConformidad).WithMany(p => p.NoConformidads)
                .HasForeignKey(d => d.StatusNoConformidadId)
                .HasConstraintName("FK_dbo.NoConformidads_dbo.StatusNoConformidads_StatusNoConformidadId");
        });

        modelBuilder.Entity<Normatividad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Normatividads");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.Normatividads)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.Normatividads_dbo.TipoEntes_TipoEnteId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Normatividads)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .HasConstraintName("FK_dbo.Normatividads_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<NotaEnMedio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.NotaEnMedios");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.MedioId, "IX_MedioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaNota).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.NotaEnMedios)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.NotaEnMedios_dbo.Entes_EnteId");

            entity.HasOne(d => d.Medio).WithMany(p => p.NotaEnMedios)
                .HasForeignKey(d => d.MedioId)
                .HasConstraintName("FK_dbo.NotaEnMedios_dbo.Medios_MedioId");
        });

        modelBuilder.Entity<NotsModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.NotsModels");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Auditor).WithMany(p => p.NotsModels)
                .HasForeignKey(d => d.AuditorId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_dbo.NotsModels_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.NotsModels)
                .HasForeignKey(d => d.AuditoriaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_dbo.NotsModels_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.User).WithMany(p => p.NotsModels)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.NotsModels_dbo.Users_UserId");
        });

        modelBuilder.Entity<Objeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Objetoes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<ObraPublica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ObraPublicas");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.PartidaId, "IX_PartidaId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.ObraPublicas)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ObraPublicas_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.ObraPublicas)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ObraPublicas_dbo.Entes_EnteId");

            entity.HasOne(d => d.Partida).WithMany(p => p.ObraPublicas)
                .HasForeignKey(d => d.PartidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ObraPublicas_dbo.Partidas_PartidaId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.ObraPublicas)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ObraPublicas_dbo.Periodos_PeriodoId");
        });

        modelBuilder.Entity<Observacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Observaciones");

            entity.HasIndex(e => e.DespachoId, "IX_DespachoId");

            entity.HasIndex(e => e.EntesObservaciones, "IX_Entes_Observaciones");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.ExpedienteId1, "IX_Expediente_Id");

            entity.HasIndex(e => e.HallazgoId, "IX_HallazgoId");

            entity.HasIndex(e => e.IdEjercicio, "IX_IdEjercicio");

            entity.HasIndex(e => e.ObservacionPadre, "IX_ObservacionPadre");

            entity.HasIndex(e => e.ProrrogaId, "IX_ProrrogaId");

            entity.HasIndex(e => e.StatusId, "IX_StatusId");

            entity.HasIndex(e => e.TipoObservacionId, "IX_TipoObservacionId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EntesObservaciones).HasColumnName("Entes_Observaciones");
            entity.Property(e => e.ExpedienteId1).HasColumnName("Expediente_Id");
            entity.Property(e => e.FechaConversion).HasColumnType("datetime");
            entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaNotificacionHallazgo).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.FechaTerminoHallazgo).HasColumnType("datetime");
            entity.Property(e => e.IdAnterior).HasColumnName("Id_Anterior");
            entity.Property(e => e.IsVisibleNotaGeneral).HasColumnName("isVisibleNotaGeneral");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasDefaultValueSql("((1))");
            entity.Property(e => e.UnidadAdministrativaId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Despacho).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.DespachoId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.DespachosExternos_DespachoId");

            entity.HasOne(d => d.EntesObservacionesNavigation).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.EntesObservaciones)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Entes_Empleados_Documentos");

            entity.HasOne(d => d.Expediente).WithMany(p => p.ObservacioneExpedientes)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Expedientes_ExpedienteId");

            entity.HasOne(d => d.ExpedienteId1Navigation).WithMany(p => p.ObservacioneExpedienteId1Navigations)
                .HasForeignKey(d => d.ExpedienteId1)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Expedientes_Expediente_Id");

            entity.HasOne(d => d.Hallazgo).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.HallazgoId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Hallazgos_HallazgoId");

            entity.HasOne(d => d.IdEjercicioNavigation).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.IdEjercicio)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Ejercicios_IdEjercicio");

            entity.HasOne(d => d.ObservacionPadreNavigation).WithMany(p => p.InverseObservacionPadreNavigation)
                .HasForeignKey(d => d.ObservacionPadre)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Observaciones_ObservacionPadre");

            entity.HasOne(d => d.Prorroga).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.ProrrogaId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Prorrogas_ProrrogaId");

            entity.HasOne(d => d.Status).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.Status_StatusId");

            entity.HasOne(d => d.TipoObservacion).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.TipoObservacionId)
                .HasConstraintName("FK_dbo.Observaciones_dbo.TipoObservacions_TipoObservacionId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Observaciones_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<Oficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Oficios");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.HasIndex(e => e.GrupoRubricasId, "IX_GrupoRubricasId");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.HasIndex(e => e.OficioNotificacionId, "IX_OficioNotificacionId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.RevisionId, "IX_RevisionId");

            entity.HasIndex(e => e.TipoOficioId, "IX_TipoOficioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaRecibidoNotificacion).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditor).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Funcionarios_FuncionarioId");

            entity.HasOne(d => d.GrupoRubricas).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.GrupoRubricasId)
                .HasConstraintName("FK_dbo.Oficios_dbo.GrupoRubricas_GrupoRubricasId");

            entity.HasOne(d => d.Observacion).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Observaciones_ObservacionId");

            entity.HasOne(d => d.OficioNotificacion).WithMany(p => p.InverseOficioNotificacion)
                .HasForeignKey(d => d.OficioNotificacionId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Oficios_OficioNotificacionId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Proveedores_ProveedorId");

            entity.HasOne(d => d.Revision).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.RevisionId)
                .HasConstraintName("FK_dbo.Oficios_dbo.Revisiones_RevisionId");

            entity.HasOne(d => d.TipoOficio).WithMany(p => p.Oficios)
                .HasForeignKey(d => d.TipoOficioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Oficios_dbo.TipoOficios_TipoOficioId");
        });

        modelBuilder.Entity<OficiosRecepcionDocumentacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.OficiosRecepcionDocumentacions");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.RecepcionDocumentacionId, "IX_RecepcionDocumentacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.OficiosRecepcionDocumentacions)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.OficiosRecepcionDocumentacions_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.RecepcionDocumentacion).WithMany(p => p.OficiosRecepcionDocumentacions)
                .HasForeignKey(d => d.RecepcionDocumentacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.OficiosRecepcionDocumentacions_dbo.RecepcionDocumentacions_RecepcionDocumentacionId");
        });

        modelBuilder.Entity<OficiosRespuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.OficiosRespuestas");

            entity.HasIndex(e => e.DocumentosId, "IX_DocumentosId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaIsaf)
                .HasColumnType("datetime")
                .HasColumnName("FechaEntregaISAF");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Documentos).WithMany(p => p.OficiosRespuesta)
                .HasForeignKey(d => d.DocumentosId)
                .HasConstraintName("FK_dbo.OficiosRespuestas_dbo.Documentos_DocumentosId");
        });

        modelBuilder.Entity<PagoSancion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PagoSancions");

            entity.HasIndex(e => e.SancionId, "IX_SancionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Sancion).WithMany(p => p.PagoSancions)
                .HasForeignKey(d => d.SancionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PagoSancions_dbo.Sancions_SancionId");
        });

        modelBuilder.Entity<Papele>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Papeles");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.AuditoriasId, "IX_Auditorias_Id");

            entity.HasIndex(e => e.EjerciciosId, "IX_Ejercicios_Id");

            entity.HasIndex(e => e.EntesId, "IX_Entes_Id");

            entity.HasIndex(e => e.FormatosDocumentosdeTrabajoId, "IX_FormatosDocumentosdeTrabajoId");

            entity.Property(e => e.AuditoriasId).HasColumnName("Auditorias_Id");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EjerciciosId).HasColumnName("Ejercicios_Id");
            entity.Property(e => e.EntesId).HasColumnName("Entes_Id");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.PapeleAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Papeles_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Auditorias).WithMany(p => p.PapeleAuditorias)
                .HasForeignKey(d => d.AuditoriasId)
                .HasConstraintName("FK_dbo.Papeles_dbo.Auditorias_Auditorias_Id");

            entity.HasOne(d => d.Ejercicios).WithMany(p => p.Papeles)
                .HasForeignKey(d => d.EjerciciosId)
                .HasConstraintName("FK_dbo.Papeles_dbo.Ejercicios_Ejercicios_Id");

            entity.HasOne(d => d.Entes).WithMany(p => p.Papeles)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.Papeles_dbo.Entes_Entes_Id");

            entity.HasOne(d => d.FormatosDocumentosdeTrabajo).WithMany(p => p.Papeles)
                .HasForeignKey(d => d.FormatosDocumentosdeTrabajoId)
                .HasConstraintName("FK_dbo.Papeles_dbo.FormatosDocumentosdeTrabajoes_FormatosDocumentosdeTrabajoId");
        });

        modelBuilder.Entity<Partida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Partidas");

            entity.HasIndex(e => e.ConceptoId, "IX_ConceptoId");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Ambito).HasDefaultValueSql("('Municipal')");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Concepto).WithMany(p => p.Partida)
                .HasForeignKey(d => d.ConceptoId)
                .HasConstraintName("FK_dbo.Partidas_dbo.Conceptoes_ConceptoId");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Periodos");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Planeacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Planeacions");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.FondoFederalId, "IX_FondoFederalId");

            entity.HasIndex(e => e.ModoEjecucionId, "IX_ModoEjecucionId");

            entity.HasIndex(e => e.ProgramaAnualId, "IX_ProgramaAnualId");

            entity.HasIndex(e => e.ProgramaPresupuestarioId, "IX_ProgramaPresupuestarioId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Planeacions_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Planeacions_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Planeacions_dbo.Entes_EnteId");

            entity.HasOne(d => d.FondoFederal).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.FondoFederalId)
                .HasConstraintName("FK_dbo.Planeacions_dbo.FondosFederales_FondoFederalId");

            entity.HasOne(d => d.ModoEjecucion).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.ModoEjecucionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Planeacions_dbo.ModoEjecucions_ModoEjecucionId");

            entity.HasOne(d => d.ProgramaAnual).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.ProgramaAnualId)
                .HasConstraintName("FK_dbo.Planeacions_dbo.ProgramaAnuals_ProgramaAnualId");

            entity.HasOne(d => d.ProgramaPresupuestario).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.ProgramaPresupuestarioId)
                .HasConstraintName("FK_dbo.Planeacions_dbo.ProgramaPresupuestarios_ProgramaPresupuestarioId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Planeacions_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Planeacions)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Planeacions_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<PlaneacionTipoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PlaneacionTipoAuditorias");

            entity.HasIndex(e => e.PlaneacionId, "IX_PlaneacionId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Planeacion).WithMany(p => p.PlaneacionTipoAuditoria)
                .HasForeignKey(d => d.PlaneacionId)
                .HasConstraintName("FK_dbo.PlaneacionTipoAuditorias_dbo.Planeacions_PlaneacionId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.PlaneacionTipoAuditoria)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.PlaneacionTipoAuditorias_dbo.TipoAuditorias_TipoAuditoriaId");
        });

        modelBuilder.Entity<Plantilla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Plantillas");

            entity.HasIndex(e => e.RubrosId, "IX_Rubros_Id");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoria_Id");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RubrosId).HasColumnName("Rubros_Id");
            entity.Property(e => e.TipoAuditoriaId).HasColumnName("TipoAuditoria_Id");
            entity.Property(e => e.UnidadAdministrativaId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Rubros).WithMany(p => p.Plantillas)
                .HasForeignKey(d => d.RubrosId)
                .HasConstraintName("FK_dbo.Plantillas_dbo.Rubros_RubrosId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Plantillas)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Plantillas_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.Plantillas)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.Plantillas_dbo.TipoEntes_TipoEnteId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.Plantillas)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Plantillas_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<Plazo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Plazoes");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Observacion).WithMany(p => p.Plazos)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.Plazoes_dbo.Observaciones_ObservacionId");
        });

        modelBuilder.Entity<Ponderacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Ponderacions");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Ponderacions)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Ponderacions_dbo.TipoAuditorias_TipoAuditoriaId");
        });

        modelBuilder.Entity<Pregunta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Preguntas");

            entity.HasIndex(e => e.CuestionarioId, "IX_CuestionarioId");

            entity.HasIndex(e => e.TipoIndicadoresId, "IX_TipoIndicadoresId");

            entity.HasIndex(e => e.TipoPreguntaId, "IX_TipoPreguntaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.TipoIndicadoresId).HasDefaultValueSql("((1))");
            entity.Property(e => e.TipoPreguntaId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Cuestionario).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CuestionarioId)
                .HasConstraintName("FK_dbo.Preguntas_dbo.Cuestionarios_CuestionarioId");

            entity.HasOne(d => d.TipoIndicadores).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.TipoIndicadoresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Preguntas_dbo.TipoIndicadores_TipoIndicadoresId");

            entity.HasOne(d => d.TipoPregunta).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.TipoPreguntaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Preguntas_dbo.TipoPreguntas_TipoPreguntaId");
        });

        modelBuilder.Entity<ProgramaAnual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ProgramaAnuals");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProgramaPresupuestario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ProgramaPresupuestarios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<PronunciamientoObservacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PronunciamientoObservaciones");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaOficio).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.PronunciamientoObservaciones)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Pronunciamientoes_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Ente).WithMany(p => p.PronunciamientoObservaciones)
                .HasForeignKey(d => d.EnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Pronunciamientoes_dbo.Entes_EnteId");
        });

        modelBuilder.Entity<PropiedadesTipoOficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PropiedadesTipoOficios");

            entity.HasIndex(e => e.TipoOficioId, "IX_TipoOficioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoOficio).WithMany(p => p.PropiedadesTipoOficios)
                .HasForeignKey(d => d.TipoOficioId)
                .HasConstraintName("FK_dbo.PropiedadesTipoOficios_dbo.TipoOficios_TipoOficioId");
        });

        modelBuilder.Entity<Prorroga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Prorrogas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProveedorMonto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ProveedorMontoes");

            entity.HasIndex(e => e.EjerciciosId, "IX_EjerciciosId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.PeriodosId, "IX_PeriodosId");

            entity.HasIndex(e => e.ProveedoresId, "IX_ProveedoresId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicios).WithMany(p => p.ProveedorMontos)
                .HasForeignKey(d => d.EjerciciosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProveedorMontoes_dbo.Ejercicios_EjerciciosId");

            entity.HasOne(d => d.Entes).WithMany(p => p.ProveedorMontos)
                .HasForeignKey(d => d.EntesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProveedorMontoes_dbo.Entes_EntesId");

            entity.HasOne(d => d.Periodos).WithMany(p => p.ProveedorMontos)
                .HasForeignKey(d => d.PeriodosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProveedorMontoes_dbo.Periodos_PeriodosId");

            entity.HasOne(d => d.Proveedores).WithMany(p => p.ProveedorMontos)
                .HasForeignKey(d => d.ProveedoresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProveedorMontoes_dbo.Proveedores_ProveedoresId");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Proveedores");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioOperaciones).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Rfc).HasColumnName("RFC");
        });

        modelBuilder.Entity<Qrcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.QRCodes");

            entity.ToTable("QRCodes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecepcionDocumentacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RecepcionDocumentacions");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.EjerciciosId, "IX_EjerciciosId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.HasIndex(e => e.PeriodosId, "IX_Periodos_Id");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.PeriodosId).HasColumnName("Periodos_Id");

            entity.HasOne(d => d.Auditor).WithMany(p => p.RecepcionDocumentacions)
                .HasForeignKey(d => d.AuditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RecepcionDocumentacions_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Ejercicios).WithMany(p => p.RecepcionDocumentacions)
                .HasForeignKey(d => d.EjerciciosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RecepcionDocumentacions_dbo.Ejercicios_EjerciciosId");

            entity.HasOne(d => d.Entes).WithMany(p => p.RecepcionDocumentacions)
                .HasForeignKey(d => d.EntesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RecepcionDocumentacions_dbo.Entes_EntesId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.RecepcionDocumentacions)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RecepcionDocumentacions_dbo.Funcionarios_FuncionarioId");

            entity.HasOne(d => d.Periodos).WithMany(p => p.RecepcionDocumentacions)
                .HasForeignKey(d => d.PeriodosId)
                .HasConstraintName("FK_dbo.RecepcionDocumentacions_dbo.Periodos_Periodos_Id");
        });

        modelBuilder.Entity<Recomendacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Recomendacions");

            entity.HasIndex(e => e.PreguntaId, "IX_PreguntaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Pregunta).WithMany(p => p.Recomendacions)
                .HasForeignKey(d => d.PreguntaId)
                .HasConstraintName("FK_dbo.Recomendacions_dbo.Preguntas_PreguntaId");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RefreshTokens");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.ClientId).HasMaxLength(50);
            entity.Property(e => e.ExpiresUtc).HasColumnType("datetime");
            entity.Property(e => e.IssuedUtc).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(50);
        });

        modelBuilder.Entity<Requerimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Requerimientoes");

            entity.HasIndex(e => e.CedulaId, "IX_CedulaId");

            entity.HasIndex(e => e.TipoRequerimientoId, "IX_TipoRequerimientoId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Cedula).WithMany(p => p.Requerimientos)
                .HasForeignKey(d => d.CedulaId)
                .HasConstraintName("FK_dbo.Evidencias_dbo.Cedulas_CedulaId");

            entity.HasOne(d => d.TipoRequerimiento).WithMany(p => p.Requerimientos)
                .HasForeignKey(d => d.TipoRequerimientoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_dbo.Evidencias_dbo.TipoEvidencias_TipoEvidenciaId");
        });

        modelBuilder.Entity<Respuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Respuestas");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.CuestionarioAuditoriaId, "IX_CuestionarioAuditoriaId");

            entity.HasIndex(e => e.PreguntaId, "IX_PreguntaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Respuesta)
                .HasForeignKey(d => d.AuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Respuestas_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.CuestionarioAuditoria).WithMany(p => p.Respuesta)
                .HasForeignKey(d => d.CuestionarioAuditoriaId)
                .HasConstraintName("FK_dbo.Respuestas_dbo.CuestionarioAuditorias_CuestionarioAuditoriaId");

            entity.HasOne(d => d.Pregunta).WithMany(p => p.Respuesta)
                .HasForeignKey(d => d.PreguntaId)
                .HasConstraintName("FK_dbo.Respuestas_dbo.Preguntas_PreguntaId");
        });

        modelBuilder.Entity<RespuestaDenuncia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RespuestaDenuncias");

            entity.HasIndex(e => e.DenunciaId, "IX_DenunciaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Denuncia).WithMany(p => p.RespuestaDenuncia)
                .HasForeignKey(d => d.DenunciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RespuestaDenuncias_dbo.Denuncias_DenunciaId");
        });

        modelBuilder.Entity<ResultadosEncuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ResultadosEncuestas");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioId");

            entity.HasIndex(e => e.EntesId, "IX_EntesId");

            entity.HasIndex(e => e.TipoResultadoEncuestaId, "IX_TipoResultadoEncuestaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EjercicioId).HasDefaultValueSql("((3))");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.ResultadosEncuesta)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ResultadosEncuestas_dbo.Ejercicios_EjercicioId");

            entity.HasOne(d => d.Entes).WithMany(p => p.ResultadosEncuesta)
                .HasForeignKey(d => d.EntesId)
                .HasConstraintName("FK_dbo.ResultadosEncuestas_dbo.Entes_EntesId");

            entity.HasOne(d => d.TipoResultadoEncuesta).WithMany(p => p.ResultadosEncuesta)
                .HasForeignKey(d => d.TipoResultadoEncuestaId)
                .HasConstraintName("FK_dbo.ResultadosEncuestas_dbo.TipoResultadoEncuestas_TipoResultadoEncuestaId");
        });

        modelBuilder.Entity<Revisione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Revisiones");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.PeriodoId, "IX_PeriodoId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.Revisiones)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.Revisiones_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Revisiones)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_dbo.Revisiones_dbo.Periodos_PeriodoId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.Revisiones)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.Revisiones_dbo.TipoAuditorias_TipoAuditoriaId");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Roles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Rubros");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<RubroAuditado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RubroAuditados");

            entity.HasIndex(e => e.CuestionarioAuditoriaId, "IX_CuestionarioAuditoriaId");

            entity.HasIndex(e => e.FondoFederalId, "IX_FondoFederalId");

            entity.HasIndex(e => e.RevisionId, "IX_RevisionId");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.RubroProcedimientoId, "IX_RubroProcedimientoId");

            entity.HasIndex(e => e.RubroTipoAuditoriaId, "IX_RubroTipoAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.RevisionId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CuestionarioAuditoria).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.CuestionarioAuditoriaId)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.CuestionarioAuditorias_CuestionarioAuditoriaId");

            entity.HasOne(d => d.FondoFederal).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.FondoFederalId)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.FondosFederales_FondoFederalId");

            entity.HasOne(d => d.Revision).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.RevisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.Revisiones_RevisionId");

            entity.HasOne(d => d.Rubro).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.Rubros_RubroId");

            entity.HasOne(d => d.RubroProcedimiento).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.RubroProcedimientoId)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.RubroProcedimientoes_RubroProcedimientoId");

            entity.HasOne(d => d.RubroTipoAuditoria).WithMany(p => p.RubroAuditados)
                .HasForeignKey(d => d.RubroTipoAuditoriaId)
                .HasConstraintName("FK_dbo.RubroAuditados_dbo.RubroTipoAuditorias_RubroTipoAuditoriaId");
        });

        modelBuilder.Entity<RubroProcedimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RubroProcedimientoes");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.HasOne(d => d.Rubro).WithMany(p => p.RubroProcedimientos)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.RubroProcedimientoes_dbo.Rubros_RubroId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.RubroProcedimientos)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.RubroProcedimientoes_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.RubroProcedimientos)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.RubroProcedimientoes_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<RubroSeccionesInforme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RubroSeccionesInformes");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.SeccionesInformesId, "IX_SeccionesInformesId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Rubro).WithMany(p => p.RubroSeccionesInformes)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_dbo.RubroSeccionesInformes_dbo.Rubros_RubroId");

            entity.HasOne(d => d.SeccionesInformes).WithMany(p => p.RubroSeccionesInformes)
                .HasForeignKey(d => d.SeccionesInformesId)
                .HasConstraintName("FK_dbo.RubroSeccionesInformes_dbo.SeccionesInformes_SeccionesInformesId");
        });

        modelBuilder.Entity<RubroTipoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RubroTipoAuditorias");

            entity.HasIndex(e => e.RubroId, "IX_RubroId");

            entity.HasIndex(e => e.RubroProcedimientoId, "IX_RubroProcedimientoId");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Orden).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.Rubro).WithMany(p => p.RubroTipoAuditoria)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RubroTipoAuditorias_dbo.Rubros_RubroId");

            entity.HasOne(d => d.RubroProcedimiento).WithMany(p => p.RubroTipoAuditoria)
                .HasForeignKey(d => d.RubroProcedimientoId)
                .HasConstraintName("FK_dbo.RubroTipoAuditorias_dbo.RubroProcedimientoes_RubroProcedimientoId");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.RubroTipoAuditoria)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RubroTipoAuditorias_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.RubroTipoAuditoria)
                .HasForeignKey(d => d.TipoEnteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RubroTipoAuditorias_dbo.TipoEntes_TipoEnteId");
        });

        modelBuilder.Entity<RubrosInformacionFinanciera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RubrosInformacionFinancieras");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sancion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Sancions");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.HasIndex(e => e.TipoSancionId, "IX_TipoSancionId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAcuerdo).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.Sancions)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Sancions_dbo.Entes_EnteId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Sancions)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Sancions_dbo.Funcionarios_FuncionarioId");

            entity.HasOne(d => d.TipoSancion).WithMany(p => p.Sancions)
                .HasForeignKey(d => d.TipoSancionId)
                .HasConstraintName("FK_dbo.Sancions_dbo.TipoSancions_TipoSancionId");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.ToTable("Schema", "HangFire");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<SeccionMemorandum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SeccionMemorandums");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<SeccionesInforme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SeccionesInformes");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.HasIndex(e => e.TipoDictamenId, "IX_TipoDictamenId");

            entity.HasIndex(e => e.TipoEnteId, "IX_TipoEnteId");

            entity.HasIndex(e => e.TipoInformesId, "IX_TipoInformesId");

            entity.HasIndex(e => e.UnidadAdministrativaId, "IX_UnidadAdministrativaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Orden).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.SeccionesInformes)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.SeccionesInformes_dbo.TipoAuditorias_TipoAuditoriaId");

            entity.HasOne(d => d.TipoDictamen).WithMany(p => p.SeccionesInformes)
                .HasForeignKey(d => d.TipoDictamenId)
                .HasConstraintName("FK_dbo.SeccionesInformes_dbo.TipoDictamen_TipoDictamenId");

            entity.HasOne(d => d.TipoEnte).WithMany(p => p.SeccionesInformes)
                .HasForeignKey(d => d.TipoEnteId)
                .HasConstraintName("FK_dbo.SeccionesInformes_dbo.TipoEntes_TipoEnteId");

            entity.HasOne(d => d.TipoInformes).WithMany(p => p.SeccionesInformes)
                .HasForeignKey(d => d.TipoInformesId)
                .HasConstraintName("FK_dbo.SeccionesInformes_dbo.TipoInformes_TipoInformesId");

            entity.HasOne(d => d.UnidadAdministrativa).WithMany(p => p.SeccionesInformes)
                .HasForeignKey(d => d.UnidadAdministrativaId)
                .HasConstraintName("FK_dbo.SeccionesInformes_dbo.UnidadAdministrativas_UnidadAdministrativaId");
        });

        modelBuilder.Entity<SeccionesInformeRubroAuditado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SeccionesInformeRubroAuditadoes");

            entity.HasIndex(e => e.InformeSeccionesInformesId, "IX_InformeSeccionesInformesId");

            entity.HasIndex(e => e.RubroAuditadoId, "IX_RubroAuditadoId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.InformeSeccionesInformes).WithMany(p => p.SeccionesInformeRubroAuditados)
                .HasForeignKey(d => d.InformeSeccionesInformesId)
                .HasConstraintName("FK_dbo.SeccionesInformeRubroAuditadoes_dbo.InformeSeccionesInformes_InformeSeccionesInformesId");

            entity.HasOne(d => d.RubroAuditado).WithMany(p => p.SeccionesInformeRubroAuditados)
                .HasForeignKey(d => d.RubroAuditadoId)
                .HasConstraintName("FK_dbo.SeccionesInformeRubroAuditadoes_dbo.RubroAuditados_RubroAuditadoId");
        });

        modelBuilder.Entity<Sector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Sectors");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");

            entity.ToTable("Server", "HangFire");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Set");

            entity.ToTable("Set", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt");

            entity.HasIndex(e => e.Key, "IX_HangFire_Set_Key");

            entity.HasIndex(e => new { e.Key, e.Value }, "UX_HangFire_Set_KeyAndValue").IsUnique();

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Socios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Rfc).HasColumnName("RFC");
        });

        modelBuilder.Entity<SocioProveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SocioProveedors");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.SocioId, "IX_SocioId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.SocioProveedors)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.SocioProveedors_dbo.Proveedores_ProveedorId");

            entity.HasOne(d => d.Socio).WithMany(p => p.SocioProveedors)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.SocioProveedors_dbo.Socios_SocioId");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_State");

            entity.ToTable("State", "HangFire");

            entity.HasIndex(e => e.JobId, "IX_HangFire_State_JobId");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.States)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Status");

            entity.ToTable("Status");
        });

        modelBuilder.Entity<StatusArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusAreas");

            entity.HasIndex(e => e.AreaId, "IX_AreaId");

            entity.HasIndex(e => e.StatusId, "IX_StatusId");

            entity.HasOne(d => d.Area).WithMany(p => p.StatusAreas)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_dbo.StatusAreas_dbo.Areas_AreaId");

            entity.HasOne(d => d.Status).WithMany(p => p.StatusAreas)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_dbo.StatusAreas_dbo.Status_StatusId");
        });

        modelBuilder.Entity<StatusAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusAuditorias");
        });

        modelBuilder.Entity<StatusAuditoriaAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusAuditoriaAuditorias");

            entity.HasIndex(e => e.AuditoriaId, "IX_AuditoriaId");

            entity.HasIndex(e => e.StatusAuditoriaId, "IX_StatusAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Auditoria).WithMany(p => p.StatusAuditoriaAuditoria)
                .HasForeignKey(d => d.AuditoriaId)
                .HasConstraintName("FK_dbo.StatusAuditoriaAuditorias_dbo.Auditorias_AuditoriaId");

            entity.HasOne(d => d.StatusAuditoria).WithMany(p => p.StatusAuditoriaAuditoria)
                .HasForeignKey(d => d.StatusAuditoriaId)
                .HasConstraintName("FK_dbo.StatusAuditoriaAuditorias_dbo.StatusAuditorias_StatusAuditoriaId");
        });

        modelBuilder.Entity<StatusDenuncia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusDenuncias");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<StatusExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusExpedientes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<StatusNoConformidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusNoConformidads");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<StatusObservacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StatusObservacions");

            entity.HasIndex(e => e.ObservacionId, "IX_ObservacionId");

            entity.HasIndex(e => e.StatusId, "IX_StatusId");

            entity.Property(e => e.Created).HasColumnType("datetime");

            entity.HasOne(d => d.Observacion).WithMany(p => p.StatusObservacions)
                .HasForeignKey(d => d.ObservacionId)
                .HasConstraintName("FK_dbo.StatusObservacions_dbo.Observaciones_ObservacionId");

            entity.HasOne(d => d.Status).WithMany(p => p.StatusObservacions)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.StatusObservacions_dbo.Status_StatusId");
        });

        modelBuilder.Entity<Sustanciacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Sustanciacions");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Expediente).WithMany(p => p.Sustanciacions)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.Sustanciacions_dbo.Expedientes_ExpedienteId");
        });

        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Telefonoes");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.FuncionarioId, "IX_FuncionarioId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Telefonoes_dbo.Entes_EnteId");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK_dbo.Telefonoes_dbo.Funcionarios_FuncionarioId");
        });

        modelBuilder.Entity<TipoAnexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoAnexoes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoAnuncio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoAnuncios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoArchivoPermanente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoArchivoPermanentes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoAuditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoAuditors");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoAuditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoAuditorias");

            entity.HasIndex(e => e.TipoAuditoriaGeneral, "IX_TipoAuditoriaGeneral");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.NombreUa).HasColumnName("NombreUA");

            entity.HasOne(d => d.TipoAuditoriaGeneralNavigation).WithMany(p => p.InverseTipoAuditoriaGeneralNavigation)
                .HasForeignKey(d => d.TipoAuditoriaGeneral)
                .HasConstraintName("FK_dbo.TipoAuditorias_dbo.TipoAuditorias_TipoAuditoriaGeneral");
        });

        modelBuilder.Entity<TipoCedula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoCedulas");

            entity.HasIndex(e => e.RubroTipoAuditoriaId, "IX_RubroTipoAuditoriaId");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.RubroTipoAuditoria).WithMany(p => p.TipoCedulas)
                .HasForeignKey(d => d.RubroTipoAuditoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TipoCedulas_dbo.RubroTipoAuditorias_RubroTipoAuditoriaId");
        });

        modelBuilder.Entity<TipoClasificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoClasificacions");

            entity.HasIndex(e => e.TipoAuditoriaId, "IX_TipoAuditoriaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoAuditoria).WithMany(p => p.TipoClasificacions)
                .HasForeignKey(d => d.TipoAuditoriaId)
                .HasConstraintName("FK_dbo.TipoClasificacions_dbo.TipoAuditorias_TipoAuditoriaId");
        });

        modelBuilder.Entity<TipoComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoComentarios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoControls");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoCuestionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoCuestionarios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoDenuncia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoDenuncias");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoDictaman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoDictamen");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoEnte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoEntes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoFuncionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoFuncionarios");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoIndicadore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoIndicadores");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoInforme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoInformes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoObservacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoObservacions");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoOficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoOficios");

            entity.HasIndex(e => e.EtapaId, "IX_EtapaId");

            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.EtapaId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Etapa).WithMany(p => p.TipoOficios)
                .HasForeignKey(d => d.EtapaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TipoOficios_dbo.EtapasAuditorias_EtapaId");
        });

        modelBuilder.Entity<TipoPregunta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoPreguntas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoRequerimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoRequerimientoes");

            entity.HasIndex(e => e.TipoCedulaId, "IX_TipoCedulaId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.TipoCedula).WithMany(p => p.TipoRequerimientos)
                .HasForeignKey(d => d.TipoCedulaId)
                .HasConstraintName("FK_dbo.TipoEvidencias_dbo.TipoCedulas_TipoCedulaId");
        });

        modelBuilder.Entity<TipoRespuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoRespuestas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoResultadoEncuesta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoResultadoEncuestas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoRubrica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoRubricas");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoSancion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TipoSancions");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TiposDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TiposDocumentoes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<TiposExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TiposExpedientes");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
        });

        modelBuilder.Entity<UnidadAdministrativa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UnidadAdministrativas");

            entity.HasIndex(e => e.AreaId, "IX_AreaId");

            entity.Property(e => e.ClaveUa).HasColumnName("ClaveUA");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Area).WithMany(p => p.UnidadAdministrativas)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_dbo.UnidadAdministrativas_dbo.Areas_AreaId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Users");

            entity.HasIndex(e => e.AuditorId, "IX_AuditorId");

            entity.HasIndex(e => e.EnteId, "IX_EnteID");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EnteId).HasColumnName("EnteID");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Auditor).WithMany(p => p.Users)
                .HasForeignKey(d => d.AuditorId)
                .HasConstraintName("FK_dbo.Users_dbo.Auditors_AuditorId");

            entity.HasOne(d => d.Ente).WithMany(p => p.Users)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Users_dbo.Entes_EnteID");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.UserRoles_dbo.Roles_RoleId"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.UserRoles_dbo.Users_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.UserRoles");
                        j.ToTable("UserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.UserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.UserClaims_dbo.Users_UserId");
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.UserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.UserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.UserLogins_dbo.Users_UserId");
        });

        modelBuilder.Entity<UsuarioEnte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UsuarioEntes");

            entity.HasIndex(e => e.EnteId, "IX_EnteId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Ente).WithMany(p => p.UsuarioEntes)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.UsuarioEntes_dbo.Entes_EnteId");

            entity.HasOne(d => d.User).WithMany(p => p.UsuarioEntes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.UsuarioEntes_dbo.Users_UserId");
        });

        modelBuilder.Entity<UsuarioExpediente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UsuarioExpedientes");

            entity.HasIndex(e => e.ExpedienteId, "IX_ExpedienteId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Expediente).WithMany(p => p.UsuarioExpedientes)
                .HasForeignKey(d => d.ExpedienteId)
                .HasConstraintName("FK_dbo.UsuarioExpedientes_dbo.Expedientes_ExpedienteId");

            entity.HasOne(d => d.User).WithMany(p => p.UsuarioExpedientes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.UsuarioExpedientes_dbo.Users_UserId");
        });

        modelBuilder.Entity<Visita>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Visitas");

            entity.HasIndex(e => e.EnteId, "IX_enteID");

            entity.Property(e => e.EnteId).HasColumnName("enteID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Ente).WithMany(p => p.Visita)
                .HasForeignKey(d => d.EnteId)
                .HasConstraintName("FK_dbo.Visitas_dbo.Entes_enteID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
