using Domain.Cadastro.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Database.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap() :
            this("dbo")
        {
        }

        public PessoaMap(string schema)
        {
            //Primary Key
            HasKey(t => t.CdPesssoa);

            //Property
            Property(p => p.CdPesssoa)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("pessoa", schema);
            Property(t => t.CdPesssoa).HasColumnName("cd_pressoa").IsRequired();
            Property(t => t.NomePessoa).HasColumnName("nome_pessoa").IsRequired();
        }
    }
}