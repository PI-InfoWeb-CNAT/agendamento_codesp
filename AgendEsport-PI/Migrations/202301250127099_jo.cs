namespace AgendEsport_PI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentoes",
                c => new
                    {
                        AgendamentoID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Hora = c.Int(nullable: false),
                        Quadra = c.Int(nullable: false),
                        Esporte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgendamentoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Agendamentoes");
        }
    }
}
