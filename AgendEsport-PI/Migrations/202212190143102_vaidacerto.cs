namespace AgendEsport_PI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vaidacerto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Espaços", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Espaços", "Nome", c => c.Int(nullable: false));
        }
    }
}
