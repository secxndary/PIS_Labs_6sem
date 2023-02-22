﻿namespace PIS_Lab4.Migrations.PhoneBooks
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using PIS_Lab4.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<PIS_Lab4.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\PhoneBooks";
        }

        protected override void Seed(PIS_Lab4.Context.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            try
            {
                context.PhoneBooks.AddOrUpdate(DummyData.GetPhoneBooks().ToArray());
                context.SaveChanges();
            }
            // код со стаковерфлоу который напишет в консоль подробную ошибку при исключении "Validation failed for one or more entities. See 'EntityValidationErrors' property for more details."
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
