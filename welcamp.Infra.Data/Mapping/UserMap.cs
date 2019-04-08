using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using welcamp.Domain.Entities;

namespace welcamp.Infra.Data.Mapping
{
    public class UserMap:IEntityTypeConfiguration<User>
    {
      
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Table");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.Email)
               .IsRequired()
               .HasColumnName("E-mail");

            builder.Property(c => c.Password)
               .IsRequired()
               .HasColumnName("Senha");

            builder.Property(c => c.ConfirmPassword)
               .IsRequired()
               .HasColumnName("ConfirmaSenha");


            builder.Property(b => b.Name).HasColumnType("varchar(50)");
            builder.Property(b => b.Email).HasColumnType("varchar(50");
            builder.Property(b => b.Password).HasColumnType("varchar(50");
            builder.Property(b => b.ConfirmPassword).HasColumnType("varchar(50");




        }
    }
}