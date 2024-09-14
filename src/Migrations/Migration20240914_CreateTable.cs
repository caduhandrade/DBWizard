using FluentMigrator;

namespace DBWizard.Migrations
{
    [Migration(20240914)]
    public class Migration20240914_CreateTable : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("Email").AsString(255).NotNullable();

            Create.Table("Products")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("ProductName").AsString(255).NotNullable();

            Insert.IntoTable("Users")
                .Row(new { Name = "Alice" })
                .Row(new { Name = "Bob" })
                .Row(new { Name = "Charlie" });

        }

        public override void Down()
        {
            Delete.Table("Users");
            Delete.Table("Products");
        }
    }
}
