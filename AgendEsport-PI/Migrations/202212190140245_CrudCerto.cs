namespace AgendEsport_PI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrudCerto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Espaços", "Nome", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Espaços", "Nome");
        }
    }
}
