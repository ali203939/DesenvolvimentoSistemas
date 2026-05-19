using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Data
{
    public class BibliotecaSQLServerDbContext : DbContext
    {
        public BibliotecaSQLServerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        // ── Configurações adicionais via Fluent API ───────────────────
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Autor
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("Autor");
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Nome).IsRequired().HasMaxLength(150);
                entity.Property(a => a.Nacionalidade).HasMaxLength(100);
            });

            // Livro
            modelBuilder.Entity<Livro>(entity =>
            {
                entity.ToTable("Livro");
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Titulo).IsRequired().HasMaxLength(250);
                entity.Property(l => l.ISBN).IsRequired().HasMaxLength(13);
                entity.Property(l => l.Disponivel).HasDefaultValue(true);

                // Livro → Autor (N:1)
                entity.HasOne(l => l.Autor)
                      .WithMany(a => a.Livros)
                      .HasForeignKey(l => l.AutorId)
                      .OnDelete(DeleteBehavior.Restrict); // não apaga Autor se tiver Livros
            });

            // Cliente
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nome).IsRequired().HasMaxLength(150);
                entity.Property(c => c.Email).IsRequired().HasMaxLength(200);
                entity.Property(c => c.Telefone).HasMaxLength(20);
                entity.Property(c => c.Ativo).HasDefaultValue(true);

                entity.HasIndex(c => c.Email).IsUnique(); // email deve ser único
            });

            // Emprestimo
            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.ToTable("Emprestimo");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Devolvido).HasDefaultValue(false);

                // Emprestimo → Livro (N:1)
                entity.HasOne(e => e.Livro)
                      .WithMany(l => l.Emprestimos)
                      .HasForeignKey(e => e.LivroId)
                      .OnDelete(DeleteBehavior.Restrict);

                // Emprestimo → Cliente (N:1)
                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.Emprestimos)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}