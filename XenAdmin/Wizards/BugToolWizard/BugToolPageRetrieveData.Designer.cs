namespace XenAdmin.Wizards.BugToolWizard
{
    partial class BugToolPageRetrieveData
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
            if (disposing)
            {
                foreach (var r in dataGridViewEx1.Rows)
                {
                    if (r is StatusReportRow row)
                    {
                        row.DeRegisterEvents();
                        DeRegisterRowEvents(row);
                    }
                }

                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugToolPageRetrieveData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelError = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridViewEx1 = new XenAdmin.Controls.DataGridViewEx.DataGridViewEx();
            this.columnHostImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHostStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnResultImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelBlurb = new System.Windows.Forms.Label();
            this.linkLabelBlurb = new System.Windows.Forms.LinkLabel();
            this.labelBlurbCis = new System.Windows.Forms.Label();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.labelError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEx1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBlurb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelBlurb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBlurbCis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelError
            // 
            resources.ApplyResources(this.labelError, "labelError");
            this.tableLayoutPanel1.SetColumnSpan(this.labelError, 2);
            this.labelError.Name = "labelError";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEx1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEx1.ColumnHeadersVisible = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHostImage,
            this.columnHost,
            this.columnHostStatus,
            this.columnResultImage});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewEx1, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEx1.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dataGridViewEx1, "dataGridViewEx1");
            this.dataGridViewEx1.HideSelection = true;
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            // 
            // columnHostImage
            // 
            this.columnHostImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.columnHostImage.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.columnHostImage, "columnHostImage");
            this.columnHostImage.Name = "columnHostImage";
            // 
            // columnHost
            // 
            resources.ApplyResources(this.columnHost, "columnHost");
            this.columnHost.Name = "columnHost";
            // 
            // columnHostStatus
            // 
            this.columnHostStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.columnHostStatus, "columnHostStatus");
            this.columnHostStatus.Name = "columnHostStatus";
            // 
            // columnResultImage
            // 
            this.columnResultImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.columnResultImage.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.columnResultImage, "columnResultImage");
            this.columnResultImage.Name = "columnResultImage";
            // 
            // labelBlurb
            // 
            resources.ApplyResources(this.labelBlurb, "labelBlurb");
            this.tableLayoutPanel1.SetColumnSpan(this.labelBlurb, 2);
            this.labelBlurb.Name = "labelBlurb";
            // 
            // linkLabelBlurb
            // 
            resources.ApplyResources(this.linkLabelBlurb, "linkLabelBlurb");
            this.linkLabelBlurb.Name = "linkLabelBlurb";
            this.linkLabelBlurb.TabStop = true;
            this.linkLabelBlurb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBlurb_LinkClicked);
            // 
            // labelBlurbCis
            // 
            resources.ApplyResources(this.labelBlurbCis, "labelBlurbCis");
            this.labelBlurbCis.Name = "labelBlurbCis";
            // 
            // buttonOpenLocation
            // 
            resources.ApplyResources(this.buttonOpenLocation, "buttonOpenLocation");
            this.buttonOpenLocation.Name = "buttonOpenLocation";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonOpenLocation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BugToolPageRetrieveData
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "BugToolPageRetrieveData";
            resources.ApplyResources(this, "$this");
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Controls.DataGridViewEx.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.DataGridViewImageColumn columnHostImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHostStatus;
        private System.Windows.Forms.DataGridViewImageColumn columnResultImage;
        private System.Windows.Forms.Label labelBlurb;
        private System.Windows.Forms.LinkLabel linkLabelBlurb;
        private System.Windows.Forms.Label labelBlurbCis;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
