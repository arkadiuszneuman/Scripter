using System.Diagnostics;
using System.Windows.Forms;
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
        private List<Trigger> vrlTriggerCollection = new List<Trigger>();
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

                if (vrfForm.ShowDialog() == DialogResult.OK)
                {
                    if (vrfForm.SelectedObjects != null)
                    {
                        foreach (var vrlObject in vrfForm.SelectedObjects)
                        {
                            var vrlDatabaseObject = vrlObject as Cl_DatabaseObject;

                            if (vrlDatabaseObject != null)
                            {
                                View.DataSource.Add(vrlDatabaseObject);
                            }

                        }

                        return true;
                    }
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
                databaseObjects.Add(new Cl_DatabaseObject() { SmoObject = smoObject, Name = smoObject.Name, Type = View.SmoObjectType });
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
                    return Cl_TriggerCollection.Get(database.Tables);
                case E_SmoObjectType.Data:
                    return database.Tables.Cast<NamedSmoObject>();
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
