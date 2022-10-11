namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculoes", "Placa", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "Renavam", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "CPF", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculoes", "CPF", c => c.String());
            AlterColumn("dbo.Veiculoes", "Nome", c => c.String());
            AlterColumn("dbo.Veiculoes", "Renavam", c => c.String());
            AlterColumn("dbo.Veiculoes", "Placa", c => c.String());
        }
    }
}
