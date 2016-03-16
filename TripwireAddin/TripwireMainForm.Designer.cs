namespace TripwireAddin
{
    partial class TripwireMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripwireMainForm));
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.txtVendorFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboQAStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJONum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGpsParameters = new System.Windows.Forms.GroupBox();
            this.chkAcceptChpo = new System.Windows.Forms.CheckBox();
            this.rdoOutsideChpo = new System.Windows.Forms.RadioButton();
            this.chkAcceptWithin = new System.Windows.Forms.CheckBox();
            this.rdoIgnoreTolerance = new System.Windows.Forms.RadioButton();
            this.rdoOutsideTolerance = new System.Windows.Forms.RadioButton();
            this.rdoInsideTolerance = new System.Windows.Forms.RadioButton();
            this.btnGpsParameters = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpGpsParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelect.Location = new System.Drawing.Point(12, 529);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 375);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(362, 143);
            this.txtMessage.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(298, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.txtVendorFolder);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.cmboState);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.cmboQAStatus);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.txtJONum);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Location = new System.Drawing.Point(13, 13);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(362, 139);
            this.grpMain.TabIndex = 3;
            this.grpMain.TabStop = false;
            // 
            // txtVendorFolder
            // 
            this.txtVendorFolder.Location = new System.Drawing.Point(140, 103);
            this.txtVendorFolder.Name = "txtVendorFolder";
            this.txtVendorFolder.Size = new System.Drawing.Size(194, 20);
            this.txtVendorFolder.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendor Folder (%LIKE%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboState
            // 
            this.cmboState.FormattingEnabled = true;
            this.cmboState.Location = new System.Drawing.Point(140, 76);
            this.cmboState.Name = "cmboState";
            this.cmboState.Size = new System.Drawing.Size(194, 21);
            this.cmboState.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboQAStatus
            // 
            this.cmboQAStatus.FormattingEnabled = true;
            this.cmboQAStatus.Location = new System.Drawing.Point(140, 49);
            this.cmboQAStatus.Name = "cmboQAStatus";
            this.cmboQAStatus.Size = new System.Drawing.Size(194, 21);
            this.cmboQAStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QA Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJONum
            // 
            this.txtJONum.Location = new System.Drawing.Point(140, 19);
            this.txtJONum.Name = "txtJONum";
            this.txtJONum.Size = new System.Drawing.Size(194, 20);
            this.txtJONum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JO Number (LIKE%):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpGpsParameters
            // 
            this.grpGpsParameters.Controls.Add(this.chkAcceptChpo);
            this.grpGpsParameters.Controls.Add(this.rdoOutsideChpo);
            this.grpGpsParameters.Controls.Add(this.chkAcceptWithin);
            this.grpGpsParameters.Controls.Add(this.rdoIgnoreTolerance);
            this.grpGpsParameters.Controls.Add(this.rdoOutsideTolerance);
            this.grpGpsParameters.Controls.Add(this.rdoInsideTolerance);
            this.grpGpsParameters.Controls.Add(this.btnGpsParameters);
            this.grpGpsParameters.Location = new System.Drawing.Point(13, 158);
            this.grpGpsParameters.Name = "grpGpsParameters";
            this.grpGpsParameters.Size = new System.Drawing.Size(362, 211);
            this.grpGpsParameters.TabIndex = 5;
            this.grpGpsParameters.TabStop = false;
            // 
            // chkAcceptChpo
            // 
            this.chkAcceptChpo.AutoSize = true;
            this.chkAcceptChpo.Location = new System.Drawing.Point(34, 118);
            this.chkAcceptChpo.Name = "chkAcceptChpo";
            this.chkAcceptChpo.Size = new System.Drawing.Size(242, 17);
            this.chkAcceptChpo.TabIndex = 11;
            this.chkAcceptChpo.Text = "Change all selected to Deliverable Accepted?";
            this.chkAcceptChpo.UseVisualStyleBackColor = true;
            // 
            // rdoOutsideChpo
            // 
            this.rdoOutsideChpo.AutoSize = true;
            this.rdoOutsideChpo.Location = new System.Drawing.Point(13, 95);
            this.rdoOutsideChpo.Name = "rdoOutsideChpo";
            this.rdoOutsideChpo.Size = new System.Drawing.Size(227, 17);
            this.rdoOutsideChpo.TabIndex = 10;
            this.rdoOutsideChpo.TabStop = true;
            this.rdoOutsideChpo.Text = "Select Outside of Tolerance yet has CHPO";
            this.rdoOutsideChpo.UseVisualStyleBackColor = true;
            this.rdoOutsideChpo.CheckedChanged += new System.EventHandler(this.rdoOutsideChpo_CheckedChanged);
            // 
            // chkAcceptWithin
            // 
            this.chkAcceptWithin.AutoSize = true;
            this.chkAcceptWithin.Location = new System.Drawing.Point(34, 72);
            this.chkAcceptWithin.Name = "chkAcceptWithin";
            this.chkAcceptWithin.Size = new System.Drawing.Size(242, 17);
            this.chkAcceptWithin.TabIndex = 9;
            this.chkAcceptWithin.Text = "Change all selected to Deliverable Accepted?";
            this.chkAcceptWithin.UseVisualStyleBackColor = true;
            // 
            // rdoIgnoreTolerance
            // 
            this.rdoIgnoreTolerance.AutoSize = true;
            this.rdoIgnoreTolerance.Location = new System.Drawing.Point(13, 174);
            this.rdoIgnoreTolerance.Name = "rdoIgnoreTolerance";
            this.rdoIgnoreTolerance.Size = new System.Drawing.Size(162, 17);
            this.rdoIgnoreTolerance.TabIndex = 8;
            this.rdoIgnoreTolerance.TabStop = true;
            this.rdoIgnoreTolerance.Text = "Ignore Tolerance Parameters";
            this.rdoIgnoreTolerance.UseVisualStyleBackColor = true;
            // 
            // rdoOutsideTolerance
            // 
            this.rdoOutsideTolerance.AutoSize = true;
            this.rdoOutsideTolerance.Location = new System.Drawing.Point(13, 141);
            this.rdoOutsideTolerance.Name = "rdoOutsideTolerance";
            this.rdoOutsideTolerance.Size = new System.Drawing.Size(157, 17);
            this.rdoOutsideTolerance.TabIndex = 7;
            this.rdoOutsideTolerance.TabStop = true;
            this.rdoOutsideTolerance.Text = "Select Outside of Tolerance";
            this.rdoOutsideTolerance.UseVisualStyleBackColor = true;
            // 
            // rdoInsideTolerance
            // 
            this.rdoInsideTolerance.AutoSize = true;
            this.rdoInsideTolerance.Location = new System.Drawing.Point(13, 49);
            this.rdoInsideTolerance.Name = "rdoInsideTolerance";
            this.rdoInsideTolerance.Size = new System.Drawing.Size(139, 17);
            this.rdoInsideTolerance.TabIndex = 6;
            this.rdoInsideTolerance.TabStop = true;
            this.rdoInsideTolerance.Text = "Select Within Tolerance";
            this.rdoInsideTolerance.UseVisualStyleBackColor = true;
            this.rdoInsideTolerance.CheckedChanged += new System.EventHandler(this.rdoInsideTolerance_CheckedChanged);
            // 
            // btnGpsParameters
            // 
            this.btnGpsParameters.Location = new System.Drawing.Point(13, 19);
            this.btnGpsParameters.Name = "btnGpsParameters";
            this.btnGpsParameters.Size = new System.Drawing.Size(145, 23);
            this.btnGpsParameters.TabIndex = 5;
            this.btnGpsParameters.Text = "Show GPS Parameters";
            this.btnGpsParameters.UseVisualStyleBackColor = true;
            this.btnGpsParameters.Click += new System.EventHandler(this.btnGpsParameters_Click);
            // 
            // TripwireMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(387, 564);
            this.Controls.Add(this.grpGpsParameters);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TripwireMainForm";
            this.Text = "GPS Tripwire V2";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpGpsParameters.ResumeLayout(false);
            this.grpGpsParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.ComboBox cmboQAStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJONum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendorFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpGpsParameters;
        private System.Windows.Forms.Button btnGpsParameters;
        private System.Windows.Forms.RadioButton rdoIgnoreTolerance;
        private System.Windows.Forms.RadioButton rdoOutsideTolerance;
        private System.Windows.Forms.RadioButton rdoInsideTolerance;
        private System.Windows.Forms.CheckBox chkAcceptWithin;
        private System.Windows.Forms.CheckBox chkAcceptChpo;
        private System.Windows.Forms.RadioButton rdoOutsideChpo;
    }
}