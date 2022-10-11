namespace Teste.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculoes",
                c => new
                {
                    IdVeiculo = c.Int(nullable: false, identity: true),
                    Placa = c.String(),
                    Renavam = c.String(),
                    Nome = c.String(),
                    CPF = c.String(),
                    Bloqueado = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.IdVeiculo);

        }

        public override void Down()
        {
            DropTable("dbo.Veiculoes");
        }
    }
}
