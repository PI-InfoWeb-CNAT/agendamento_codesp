namespace AgendEsport_PI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Senha", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Senha");
        }
    }
}
