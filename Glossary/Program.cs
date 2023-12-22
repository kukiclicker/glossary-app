using BusinessLogic;
using BusinessLogic.Interfaces;
using DataLayer;
using DataLayer.DAL;
using DataLayer.Interfaces;
using Glossary.Interfaces;
using Glossary.Validations;
using GlossaryForm.Interfaces;
using GlossaryForm.Validation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace GlossaryForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static ServiceCollection services = new ServiceCollection();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            RunApp();
        }
        private static void ConfigureServices()
        {
            services.AddSingleton<GlossaryAppDBEntities>();
            services.AddTransient<IGlossaryRepository, GlossaryRepository>();
            services.AddTransient<IGlossaryBusiness, GlossaryBusiness>();
            services.AddTransient<ITermValidation,TermValidation>();
            services.AddTransient<IDefinitionValidation,DefinitionValidation>();
            services.AddTransient<GlossaryForm>();
            services.BuildServiceProvider();
        }
        private static void RunApp()
        {
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {

                var glossaryForm = serviceProvider.GetRequiredService<GlossaryForm>();
                Application.Run(glossaryForm);
            }
        }
    }
}
