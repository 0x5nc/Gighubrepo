namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO GENRES (Id, Name)  VALUES (1,'Jazz')");
            Sql("Insert INTO GENRES (Id, Name)  VALUES (2,'Rap')");
            Sql("Insert INTO GENRES (Id, Name)  VALUES (3,'Country')");
            Sql("Insert INTO GENRES (Id, Name)  VALUES (4,'Rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}
