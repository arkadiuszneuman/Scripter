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
using Microsoft.SqlServer.Management.Common;

namespace Skryper.Presenter
{
    public class ClP_DatabaseObjectList : inSolutions.Controls.BaseForms.Presenter.ClP_FilterableBaseList<Cl_DatabaseObject>
    {
        private I_ConfigDb vrcConfigData;

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
                            vrlDatabaseObject.FileName = View.DefaultName;

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
            ucToReturn.SetServer(vrcConfigData);
            ucToReturn.FullGrid = true;
            ucToReturn.ViewAddionalColumns = false;
            ucToReturn.ViewNameColumns = false;

            return ucToReturn;
        }

        private ServerConnection GetConnection()
        {
            ServerConnection serverConnection;
            if (vrcConfigData.IsSQLAuthentication)
            {
                serverConnection = new ServerConnection(vrcConfigData.CurrentServerName, vrcConfigData.Login, vrcConfigData.Pass);
            }
            else
            {
                serverConnection = new ServerConnection(vrcConfigData.CurrentServerName);
            }

            return serverConnection;
        }

        protected override void LoadDataSource()
        {
            Server server = new Server(GetConnection());
            Database database = server.Databases[vrcConfigData.CurrentDatabaseName];

            IEnumerable<NamedSmoObject> vrlObjects = GetObjects(database);

            List<Cl_DatabaseObject> databaseObjects = new List<Cl_DatabaseObject>();
            foreach (NamedSmoObject smoObject in vrlObjects)
            {
                var vrlObject = new Cl_DatabaseObject()
                {
                    SmoObject = smoObject,
                    Name = smoObject.Name,
                    Type = View.SmoObjectType,
                    IsDefaultFileName = true,
                    FileName = View.DefaultName
                };

                if (vrlObject.Type != E_SmoObjectType.Table)
                {
                    vrlObject.InsertData = false;
                    vrlObject.Drop = true;
                }
                databaseObjects.Add(vrlObject);
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
                    return database.Tables.Cast<Table>().SelectMany(vrpTable => vrpTable.Triggers.Cast<Trigger>()).Where(t => !t.IsEncrypted);
                case E_SmoObjectType.Data:
                    return database.Tables.Cast<NamedSmoObject>();
                case E_SmoObjectType.View:
                    return database.Views.Cast<NamedSmoObject>();
                default:
                    throw new ArgumentException("Nieobsłużone");
            }
        }


        public void SetServer(I_ConfigDb vrpConfigData)
        {
            vrcConfigData = vrpConfigData;
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
