using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWizard.Migrations
{
    [Migration(20240915)]
    public class Migration_20240915_PopulateTable : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Users")
                .Row(new { Name = "Alice", Email = "Teste@gmail.com" })
                .Row(new { Name = "Bob", Email = "Teste@gmail.com1" })
                .Row(new { Name = "Charlie", Email = "Teste@gmail.com2" });
        }

        public override void Down()
        {
        }
    }
}
