using inSolutions.Controls.Loader.Utilities;
using Microsoft.SqlServer.Management.Smo;
using Skryper.Interface;
using Skryper.Utilities.ScriptGen;
using Skryper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skryper.Presenter
{
    public class ClP_DatabaseObjectList : inSolutions.Controls.BaseForms.Presenter.ClP_FilterableBaseList<Cl_DatabaseObject>
    {
        private string serverName;
        private string databaseName;

        public ClP_DatabaseObjectList(I_DatabaseObjectList vrpView)
            : base(vrpView)
        {
        }

        public override bool Edit(Cl_DatabaseObject vrpChoosedObject)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Cl_DatabaseObject vrpChoosedObject)
        {
            View.DataSource.Remove(vrpChoosedObject);
            return true;
        }

        public override bool Add()
        {
            using (Frm_DatabaseObjectList vrfForm = new Frm_DatabaseObjectList(true))
            {
                vrfForm.AddList("Obiekt bazodanowy", GetUC());

                if (vrfForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var vrlObject in vrfForm.SelectedObjects)
                    {
                        View.DataSource.Add(vrlObject as Cl_DatabaseObject);
                    }
                    return true;
                }
            }

            return false;
        }

        private UC_DatabaseObjectList GetUC()
        {
            UC_DatabaseObjectList ucToReturn = new UC_DatabaseObjectList();
            ucToReturn.SmoObjectType = View.SmoObjectType;
            ucToReturn.SetServer(serverName, databaseName);
            ucToReturn.FullGrid = true;
            return ucToReturn;
        }

        protected override void LoadDataSource()
        {
            Server server = new Server(serverName);
            Database database = server.Databases[databaseName];

            IEnumerable<NamedSmoObject> vrlObjects = GetObjects(database);

            List<Cl_DatabaseObject> databaseObjects = new List<Cl_DatabaseObject>();
            foreach (NamedSmoObject smoObject in vrlObjects)
            {
                databaseObjects.Add(new Cl_DatabaseObject() { SmoObject = smoObject });
            }

            View.DataSource = databaseObjects;
        }

        private IEnumerable<NamedSmoObject> GetObjects(Database database)
        {
            switch (View.SmoObjectType)
            {
                case E_SmoObjectType.Table:
                    return database.Tables.Cast<NamedSmoObject>();
                case E_SmoObjectType.StoredProcedure:
                    return database.StoredProcedures.Cast<NamedSmoObject>();
                case E_SmoObjectType.Function:
                    return database.UserDefinedFunctions.Cast<NamedSmoObject>();
                case E_SmoObjectType.Trigger:
                    return database.Triggers.Cast<NamedSmoObject>();
                case E_SmoObjectType.View:
                    return database.Views.Cast<NamedSmoObject>();
                default:
                    throw new ArgumentException("Nieobsłużone");
            }
        }

        public void SetServer(string serverName, string database)
        {
            this.serverName = serverName;
            this.databaseName = database;
        }

        protected I_DatabaseObjectList View
        {
            get
            {
                return this.vrcView as I_DatabaseObjectList;
            }
        }
    }
}
