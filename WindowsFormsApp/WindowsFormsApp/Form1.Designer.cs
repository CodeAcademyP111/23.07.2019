namespace WindowsFormsApp
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
            this.cmbGroupType = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSaveStd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroupType
            // 
            this.cmbGroupType.FormattingEnabled = true;
            this.cmbGroupType.Location = new System.Drawing.Point(391, 42);
            this.cmbGroupType.Name = "cmbGroupType";
            this.cmbGroupType.Size = new System.Drawing.Size(146, 21);
            this.cmbGroupType.TabIndex = 0;
            this.cmbGroupType.SelectedValueChanged += new System.EventHandler(this.CmbGroupType_SelectedValueChanged);
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(391, 104);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(146, 21);
            this.cmbGroup.TabIndex = 1;
            // 
            // txtStdName
            // 
            this.txtStdName.Location = new System.Drawing.Point(83, 42);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(157, 20);
            this.txtStdName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(83, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(157, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // btnSaveStd
            // 
            this.btnSaveStd.Location = new System.Drawing.Point(614, 70);
            this.btnSaveStd.Name = "btnSaveStd";
            this.btnSaveStd.Size = new System.Drawing.Size(100, 34);
            this.btnSaveStd.TabIndex = 4;
            this.btnSaveStd.Text = "Save Student";
            this.btnSaveStd.UseVisualStyleBackColor = true;
            this.btnSaveStd.Click += new System.EventHandler(this.BtnSaveStd_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 219);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(762, 231);
            this.dgv.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSaveStd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.cmbGroupType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroupType;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSaveStd;
        private System.Windows.Forms.DataGridView dgv;
    }
}

