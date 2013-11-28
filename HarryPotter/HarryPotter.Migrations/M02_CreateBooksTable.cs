using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator;

namespace HarryPotter.Migrations
{

    [Migration(2)]
    public class M02_CreateBooksTable: Migration
    {
        public override void Down()
        {
            Delete.Table("books");
        }

        public override void Up()
        {
            Create.Table("books")
                .WithColumn("id").AsInt32().PrimaryKey()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("price").AsDouble().NotNullable()
                .WithColumn("author_id").AsInt32().ForeignKey("authors", "id");
        }
    }
}
