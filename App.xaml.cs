using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using EFDatabaseFirst.Contexts;
using System.Windows;

namespace EFDatabaseFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); // Call the base class method

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatabaseContext>());

            using (var context = new DatabaseContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
