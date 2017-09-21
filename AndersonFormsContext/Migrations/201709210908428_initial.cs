namespace AndersonFormsContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Byod",
                c => new
                    {
                        ByodId = c.Int(nullable: false, identity: true),
                        ApprovedBy = c.Int(nullable: false),
                        ApproverId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        RequestedBy = c.Int(nullable: false),
                        TypeOfDeviceId = c.Int(nullable: false),
                        BrandName = c.String(maxLength: 50),
                        ContactNo = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        SerialNumber = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ByodId);
            
            CreateTable(
                "dbo.RequestedItem",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        RequestedItemId = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 250),
                        ImplementedBy = c.String(nullable: false, maxLength: 250),
                        RemovedBy = c.String(nullable: false, maxLength: 250),
                        CreatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.TypeOfDevice",
                c => new
                    {
                        TypeOfDeviceId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.TypeOfDeviceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeOfDevice");
            DropTable("dbo.RequestedItem");
            DropTable("dbo.Byod");
        }
    }
}
