using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Utilities
{
    public class Cl_TFS
    {
        private string vrcServer = "http://192.168.255.52:8080/tfs/";
        private string vrcWorkspace;

        /// <summary>
        /// Konstruktor klasy Cl_TFS
        /// </summary>
        /// <param name="vrpServer"></param>
        /// <param name="vrpWorkspace"></param>
        public Cl_TFS(string vrpWorkspace)
        {
            vrcWorkspace = vrpWorkspace;
        }

        public void CheckoutFile(string vrpFilePath)
        {
            string fileForEdit = vrpFilePath;

            var server = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(vrcServer));
            var versionControl = (VersionControlServer)server.GetService(typeof(VersionControlServer));
            // open a workspace.
            var workspace = versionControl.GetWorkspace(vrcWorkspace);

            var result = workspace.PendEdit(fileForEdit);
        }
    }
}
