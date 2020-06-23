using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GantChart
{
    
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ganttTestDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            this.taskDependenciesTableAdapter1.Fill(this.ganttTestDataSet.TaskDependencies);
            // TODO: This line of code loads data into the 'ganttTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter1.Fill(this.ganttTestDataSet.Resources);
            // TODO: This line of code loads data into the 'ganttTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter1.Fill(this.ganttTestDataSet.Appointments);
            // TODO: This line of code loads data into the 'gantChartDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            
            this.appointmentsTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(appointmentsTableAdapter_RowUpdated);
            schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = true;
           
            // Hide unnecessary visual elements.
            schedulerControl1.GanttView.ShowResourceHeaders = false;
            schedulerControl1.GanttView.NavigationButtonVisibility = NavigationButtonVisibility.Never;
            
            // Disable user sorting in the Resource Tree (clicking the column will not change the sort order).
            colDescription.OptionsColumn.AllowSort = false;
        }
        private void schedulerDataStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }

        private void schedulerDataStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }
        private void schedulerDataStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {

            CommitTask();
            
            schedulerDataStorage1.SetAppointmentId(((Appointment)e.Objects[0]), id);
    
            CommitSql();
           
        }
        void CommitTask()
        {
            appointmentsTableAdapter.Update(ganttTestDataSet);
            
            this.ganttTestDataSet.AcceptChanges();
            
        }
        private void schedulerDataStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerDataStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerDataStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }
        void CommitTaskDependency()
        {
            taskDependenciesTableAdapter.Update(this.ganttTestDataSet);
            this.gantChartDataSet.AcceptChanges();
        }
        int id = 0;
        private void appointmentsTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", appointmentsTableAdapter.Connection))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    e.Row["UniqueId"] = id;
                }
            }
        }
        private void CommitSql()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dsAppointment = new DataSet();
            

            connetionString = "Server = MSI\\SQLEXPRESS;Integrated Security = True;Database = GanttTest";
          
            

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Appointmments", connection);
                SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
                adapter.Update(ganttTestDataSet.Appointments.DataSet, "Appointments");
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {


            }

          
        }
    }
}
