using LanguageTranslation.Models.LanguageTranslation;

namespace LanguageTranslation.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LanguageTranslation.Models.LanguageTranslationDbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LanguageTranslation.Models.LanguageTranslationDbcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            // seed data for language
            context.LanguageMasters.AddOrUpdate(
              p => p.Id,
              new LanguageMaster { Id =1,Name = "English"},
              new LanguageMaster { Id = 2, Name = "Arabic" }

            );

            context.GlobalizationMasters.AddOrUpdate(p=> p.Id,
                new GlobalizationMaster{Id = 1,LanguageId = 1,Key = "uname",Value = "User Name"},
                new GlobalizationMaster{Id = 2,LanguageId = 2,Key = "uname",Value = "اسم المستخدم"}
            );

            context.SaveChanges();
        }
    }
}
