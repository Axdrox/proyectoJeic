using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Jeic
{
    [RunInstaller(true)]
    public partial class JeicInstaller : System.Configuration.Install.Installer
    {
        public JeicInstaller()
        {
            InitializeComponent();
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);

            //get Configuration section 
            //name from custom action parameter
            string sectionName = this.Context.Parameters["sectionName"];

            //get Protected Configuration Provider 
            //name from custom action parameter
            string provName = this.Context.Parameters["provName"];

            // get the exe path from the default context parameters
            string exeFilePath = this.Context.Parameters["assemblypath"];

            //encrypt the configuration section
            ProtectSection(sectionName, provName, exeFilePath);


        }

        private void ProtectSection(string sectionName,
                     string provName, string exeFilePath)
        {
            Configuration config =
              ConfigurationManager.OpenExeConfiguration(exeFilePath);
            ConfigurationSection section = config.GetSection(sectionName);

            if (!section.SectionInformation.IsProtected)
            {
                //Protecting the specified section with the specified provider
                section.SectionInformation.ProtectSection(provName);
            }
            section.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Modified);

        }
    }
}
