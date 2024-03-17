using Microsoft.EntityFrameworkCore;

namespace OnlineQuizApi.DataBaseModel;

public partial class OnlineQuizContext : DbContext
{
    public OnlineQuizContext()
    {
    }

    public OnlineQuizContext(DbContextOptions<OnlineQuizContext> options)
        : base(options)
    {
    }

    public virtual DbSet<QuestionAnswerDetail> QuestionAnswerDetails { get; set; }

    public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }

    public virtual DbSet<QuestionDetail> QuestionDetails { get; set; }

    public virtual DbSet<QuestionOptionDetail> QuestionOptionDetails { get; set; }

    public virtual DbSet<QuizCategory> QuizCategories { get; set; }

    public virtual DbSet<QuizDetail> QuizDetails { get; set; }

    public virtual DbSet<QuizInstructionDetail> QuizInstructionDetails { get; set; }

    public virtual DbSet<QuizQuestionDetail> QuizQuestionDetails { get; set; }

    public virtual DbSet<QuizSubInstructionDetail> QuizSubInstructionDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DBConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QuestionAnswerDetail>(entity =>
        {
            entity.ToTable("QuestionAnswerDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Option).WithMany(p => p.QuestionAnswerDetails)
                .HasForeignKey(d => d.OptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionAnswerDetail_QuestionOptionDetail");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionAnswerDetails)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionAnswerDetail_QuestionDetail");
        });

        modelBuilder.Entity<QuestionCategory>(entity =>
        {
            entity.ToTable("QuestionCategory");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<QuestionDetail>(entity =>
        {
            entity.ToTable("QuestionDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Question).IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.QuestionCategory).WithMany(p => p.QuestionDetails)
                .HasForeignKey(d => d.QuestionCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionDetail_QuestionCategory");
        });

        modelBuilder.Entity<QuestionOptionDetail>(entity =>
        {
            entity.ToTable("QuestionOptionDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Option).IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionOptionDetails)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionOptionDetail_QuestionDetail");
        });

        modelBuilder.Entity<QuizCategory>(entity =>
        {
            entity.ToTable("QuizCategory");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<QuizDetail>(entity =>
        {
            entity.ToTable("QuizDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Category).WithMany(p => p.QuizDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizDetail_QuizCategory");
        });

        modelBuilder.Entity<QuizInstructionDetail>(entity =>
        {
            entity.ToTable("QuizInstructionDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.HeadingTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizInstructionDetails)
                .HasForeignKey(d => d.QuizId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizInstructionDetail_QuizDetail");
        });

        modelBuilder.Entity<QuizQuestionDetail>(entity =>
        {
            entity.ToTable("QuizQuestionDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.QuizQuestionDetails)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizQuestionDetail_QuestionDetail");

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizQuestionDetails)
                .HasForeignKey(d => d.QuizId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizQuestionDetail_QuizDetail");
        });

        modelBuilder.Entity<QuizSubInstructionDetail>(entity =>
        {
            entity.ToTable("QuizSubInstructionDetail");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
