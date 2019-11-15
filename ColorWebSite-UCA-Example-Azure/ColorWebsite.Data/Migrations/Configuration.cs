namespace ColorWebsite.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ColorWebsite.Data.DataContext";
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Colors.AddOrUpdate(
              p => p.Name,
              new DemoColor { Name = "Purple" },
              new DemoColor { Name = "Teal" },
              new DemoColor { Name = "LightSlateGray" }
            );
            
        }
    }
}
