namespace CarDealership
{
    partial class frmInventoryMaintenance
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbModel = new System.Windows.Forms.GroupBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.gbManufacturer = new System.Windows.Forms.GroupBox();
            this.txtNewMake = new System.Windows.Forms.TextBox();
            this.lblNewMake = new System.Windows.Forms.Label();
            this.gbModel.SuspendLayout();
            this.gbManufacturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(51, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(141, 20);
            this.txtModel.TabIndex = 1;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(10, 27);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(134, 187);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // gbModel
            // 
            this.gbModel.Controls.Add(this.cboMake);
            this.gbModel.Controls.Add(this.txtModel);
            this.gbModel.Controls.Add(this.lblMake);
            this.gbModel.Controls.Add(this.lblModel);
            this.gbModel.Location = new System.Drawing.Point(20, 85);
            this.gbModel.Name = "gbModel";
            this.gbModel.Size = new System.Drawing.Size(200, 96);
            this.gbModel.TabIndex = 6;
            this.gbModel.TabStop = false;
            this.gbModel.Text = "New Model:";
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(53, 24);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(139, 21);
            this.cboMake.TabIndex = 4;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // gbManufacturer
            // 
            this.gbManufacturer.Controls.Add(this.txtNewMake);
            this.gbManufacturer.Controls.Add(this.lblNewMake);
            this.gbManufacturer.Location = new System.Drawing.Point(20, 20);
            this.gbManufacturer.Name = "gbManufacturer";
            this.gbManufacturer.Size = new System.Drawing.Size(200, 59);
            this.gbManufacturer.TabIndex = 7;
            this.gbManufacturer.TabStop = false;
            this.gbManufacturer.Text = "New Manufacturer:";
            // 
            // txtNewMake
            // 
            this.txtNewMake.Location = new System.Drawing.Point(53, 23);
            this.txtNewMake.Name = "txtNewMake";
            this.txtNewMake.Size = new System.Drawing.Size(139, 20);
            this.txtNewMake.TabIndex = 5;
            // 
            // lblNewMake
            // 
            this.lblNewMake.AutoSize = true;
            this.lblNewMake.Location = new System.Drawing.Point(10, 26);
            this.lblNewMake.Name = "lblNewMake";
            this.lblNewMake.Size = new System.Drawing.Size(37, 13);
            this.lblNewMake.TabIndex = 6;
            this.lblNewMake.Text = "Make:";
            // 
            // frmInventoryMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 230);
            this.Controls.Add(this.gbManufacturer);
            this.Controls.Add(this.gbModel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmInventoryMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expand Inventory";
            this.Load += new System.EventHandler(this.frmInventoryMaintenance_Load);
            this.gbModel.ResumeLayout(false);
            this.gbModel.PerformLayout();
            this.gbManufacturer.ResumeLayout(false);
            this.gbManufacturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox gbModel;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.GroupBox gbManufacturer;
        private System.Windows.Forms.TextBox txtNewMake;
        private System.Windows.Forms.Label lblNewMake;
    }
}