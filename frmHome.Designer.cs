namespace PaymentGatewayTestingTool
{
    partial class frmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNonPCI = new System.Windows.Forms.RadioButton();
            this.radioPCI = new System.Windows.Forms.RadioButton();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLegend = new System.Windows.Forms.TextBox();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.btnFetchColumns = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.llAPIReference = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNonPCI);
            this.groupBox1.Controls.Add(this.radioPCI);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select API Type";
            // 
            // radioNonPCI
            // 
            this.radioNonPCI.AutoSize = true;
            this.radioNonPCI.Location = new System.Drawing.Point(90, 25);
            this.radioNonPCI.Name = "radioNonPCI";
            this.radioNonPCI.Size = new System.Drawing.Size(90, 17);
            this.radioNonPCI.TabIndex = 1;
            this.radioNonPCI.TabStop = true;
            this.radioNonPCI.Text = "Non PCI Ops";
            this.radioNonPCI.UseVisualStyleBackColor = true;
            this.radioNonPCI.CheckedChanged += new System.EventHandler(this.radioNonPCI_CheckedChanged);
            // 
            // radioPCI
            // 
            this.radioPCI.AutoSize = true;
            this.radioPCI.Location = new System.Drawing.Point(12, 25);
            this.radioPCI.Name = "radioPCI";
            this.radioPCI.Size = new System.Drawing.Size(65, 17);
            this.radioPCI.TabIndex = 0;
            this.radioPCI.TabStop = true;
            this.radioPCI.Text = "PCI Ops";
            this.radioPCI.UseVisualStyleBackColor = true;
            this.radioPCI.CheckedChanged += new System.EventHandler(this.radioPCI_CheckedChanged);
            // 
            // cbOperations
            // 
            this.cbOperations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Location = new System.Drawing.Point(292, 40);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(328, 25);
            this.cbOperations.TabIndex = 1;
            this.cbOperations.SelectedIndexChanged += new System.EventHandler(this.cbOperations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Operation";
            // 
            // txtLegend
            // 
            this.txtLegend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegend.Location = new System.Drawing.Point(13, 79);
            this.txtLegend.Multiline = true;
            this.txtLegend.Name = "txtLegend";
            this.txtLegend.ReadOnly = true;
            this.txtLegend.Size = new System.Drawing.Size(267, 341);
            this.txtLegend.TabIndex = 3;
            this.txtLegend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInputs
            // 
            this.txtInputs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputs.Location = new System.Drawing.Point(292, 79);
            this.txtInputs.Multiline = true;
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(452, 341);
            this.txtInputs.TabIndex = 4;
            // 
            // btnFetchColumns
            // 
            this.btnFetchColumns.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFetchColumns.Enabled = false;
            this.btnFetchColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchColumns.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchColumns.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFetchColumns.Location = new System.Drawing.Point(626, 39);
            this.btnFetchColumns.Name = "btnFetchColumns";
            this.btnFetchColumns.Size = new System.Drawing.Size(118, 27);
            this.btnFetchColumns.TabIndex = 5;
            this.btnFetchColumns.Text = "Fetch Columns";
            this.btnFetchColumns.UseVisualStyleBackColor = false;
            this.btnFetchColumns.Click += new System.EventHandler(this.btnFetchColumns_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFetchData.Enabled = false;
            this.btnFetchData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchData.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFetchData.Location = new System.Drawing.Point(506, 428);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(238, 33);
            this.btnFetchData.TabIndex = 6;
            this.btnFetchData.Text = "Fetch Data";
            this.btnFetchData.UseVisualStyleBackColor = false;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please refer to the column names and enter required data. \r\nYou can also refer th" +
    "e API Reference link on the left.";
            // 
            // llAPIReference
            // 
            this.llAPIReference.AutoSize = true;
            this.llAPIReference.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAPIReference.Location = new System.Drawing.Point(20, 435);
            this.llAPIReference.Name = "llAPIReference";
            this.llAPIReference.Size = new System.Drawing.Size(92, 17);
            this.llAPIReference.TabIndex = 8;
            this.llAPIReference.TabStop = true;
            this.llAPIReference.Text = "API Reference";
            this.llAPIReference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAPIReference_LinkClicked);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(755, 473);
            this.Controls.Add(this.llAPIReference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.btnFetchColumns);
            this.Controls.Add(this.txtInputs);
            this.Controls.Add(this.txtLegend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Gateway Testing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNonPCI;
        private System.Windows.Forms.RadioButton radioPCI;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegend;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.Button btnFetchColumns;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llAPIReference;
    }
}

