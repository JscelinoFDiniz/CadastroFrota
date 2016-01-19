namespace CadastrarFrota.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "Fabricante", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "Modelo", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "Chassi", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "Placa", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "DataFrabricacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Car", "DataModelo", c => c.DateTime(nullable: false));
            DropColumn("dbo.Car", "Manufacturer");
            DropColumn("dbo.Car", "ModelCAr");
            DropColumn("dbo.Car", "FrameCar");
            DropColumn("dbo.Car", "BoardCar");
            DropColumn("dbo.Car", "ManufacturingDate");
            DropColumn("dbo.Car", "ModelData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Car", "ModelData", c => c.DateTime(nullable: false));
            AddColumn("dbo.Car", "ManufacturingDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Car", "BoardCar", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "FrameCar", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "ModelCAr", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Car", "Manufacturer", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Car", "DataModelo");
            DropColumn("dbo.Car", "DataFrabricacao");
            DropColumn("dbo.Car", "Placa");
            DropColumn("dbo.Car", "Chassi");
            DropColumn("dbo.Car", "Modelo");
            DropColumn("dbo.Car", "Fabricante");
        }
    }
}
