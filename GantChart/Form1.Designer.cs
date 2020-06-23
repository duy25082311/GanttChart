namespace GantChart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.colDescription = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colId = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colIdSort = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.taskDependenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ganttTestDataSet = new GantChart.GanttTestDataSet();
            this.appointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskDependenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gantChartDataSet = new GantChart.GanttTestDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new GantChart.GanttTestDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new GantChart.GanttTestDataSetTableAdapters.ResourcesTableAdapter();
            this.taskDependenciesTableAdapter = new GantChart.GanttTestDataSetTableAdapters.TaskDependenciesTableAdapter();
            this.appointmentsTableAdapter1 = new GantChart.GanttTestDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter1 = new GantChart.GanttTestDataSetTableAdapters.ResourcesTableAdapter();
            this.taskDependenciesTableAdapter1 = new GantChart.GanttTestDataSetTableAdapters.TaskDependenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantChartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.resourcesTree1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1058, 704);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 0;
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescription,
            this.colId,
            this.colIdSort});
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 0);
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsBehavior.Editable = false;
            this.resourcesTree1.SchedulerControl = this.schedulerControl1;
            this.resourcesTree1.Size = new System.Drawing.Size(219, 704);
            this.resourcesTree1.TabIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIdSort
            // 
            this.colIdSort.FieldName = "IdSort";
            this.colIdSort.Name = "colIdSort";
            this.colIdSort.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(835, 704);
            this.schedulerControl1.Start = new System.DateTime(2020, 6, 21, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            this.schedulerDataStorage1.AppointmentDependencies.DataSource = this.taskDependenciesBindingSource1;
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.DependentId = "DependentId";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.ParentId = "ParentId";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.Type = "Type";
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.appointmentsBindingSource1;
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "UniqueId";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.PercentComplete = "PercentComplete";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceId";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("IdSort", "IdSort"));
            this.schedulerDataStorage1.Resources.DataSource = this.resourcesBindingSource1;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "Description";
            this.schedulerDataStorage1.Resources.Mappings.Color = "Color";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Id";
            this.schedulerDataStorage1.Resources.Mappings.Image = "Image";
            this.schedulerDataStorage1.Resources.Mappings.ParentId = "ParentId";
            this.schedulerDataStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentsInserted);
            this.schedulerDataStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentsChanged);
            this.schedulerDataStorage1.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentsDeleted);
            this.schedulerDataStorage1.AppointmentDependenciesInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentDependenciesInserted);
            this.schedulerDataStorage1.AppointmentDependenciesChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentDependenciesChanged);
            this.schedulerDataStorage1.AppointmentDependenciesDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerDataStorage1_AppointmentDependenciesDeleted);
            // 
            // taskDependenciesBindingSource1
            // 
            this.taskDependenciesBindingSource1.DataMember = "TaskDependencies";
            this.taskDependenciesBindingSource1.DataSource = this.ganttTestDataSet;
            // 
            // ganttTestDataSet
            // 
            this.ganttTestDataSet.DataSetName = "GanttTestDataSet";
            this.ganttTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource1
            // 
            this.appointmentsBindingSource1.DataMember = "Appointments";
            this.appointmentsBindingSource1.DataSource = this.ganttTestDataSet;
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "Resources";
            this.resourcesBindingSource1.DataSource = this.ganttTestDataSet;
            // 
            // taskDependenciesBindingSource
            // 
            this.taskDependenciesBindingSource.DataMember = "TaskDependencies";
            this.taskDependenciesBindingSource.DataSource = this.gantChartDataSet;
            // 
            // gantChartDataSet
            // 
            this.gantChartDataSet.DataSetName = "GantChartDataSet";
            this.gantChartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.gantChartDataSet;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.gantChartDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // taskDependenciesTableAdapter
            // 
            this.taskDependenciesTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter1
            // 
            this.resourcesTableAdapter1.ClearBeforeFill = true;
            // 
            // taskDependenciesTableAdapter1
            // 
            this.taskDependenciesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 704);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantChartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private GanttTestDataSet gantChartDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private GanttTestDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private GanttTestDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource taskDependenciesBindingSource;
        private GanttTestDataSetTableAdapters.TaskDependenciesTableAdapter taskDependenciesTableAdapter;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colDescription;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colId;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colIdSort;
        private GanttTestDataSet ganttTestDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource1;
        private GanttTestDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
        private GanttTestDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter1;
        private System.Windows.Forms.BindingSource taskDependenciesBindingSource1;
        private GanttTestDataSetTableAdapters.TaskDependenciesTableAdapter taskDependenciesTableAdapter1;
    }
}

