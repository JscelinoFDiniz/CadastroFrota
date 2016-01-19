namespace CadastrarFrota.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        IdCar = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(nullable: false, maxLength: 30),
                        ModelCAr = c.String(nullable: false, maxLength: 30),
                        FrameCar = c.String(nullable: false, maxLength: 30),
                        BoardCar = c.String(nullable: false, maxLength: 30),
                        ManufacturingDate = c.DateTime(nullable: false),
                        ModelData = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCar);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
