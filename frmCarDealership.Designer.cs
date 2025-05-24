namespace CarDealership
{
    partial class frmCarDealership
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
            System.Windows.Forms.Label modelLabel;
            this.lvInventory = new System.Windows.Forms.ListView();
            this.CarID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.rdoUsed = new System.Windows.Forms.RadioButton();
            this.rdoNew = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdminTools = new System.Windows.Forms.Button();
            this.lvlView = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            this.gbCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(9, 73);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 10;
            modelLabel.Text = "Model:";
            // 
            // lvInventory
            // 
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarID,
            this.Make,
            this.Model,
            this.Color,
            this.Condition,
            this.Price});
            this.lvInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvInventory.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInventory.FullRowSelect = true;
            this.lvInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvInventory.HideSelection = false;
            this.lvInventory.Location = new System.Drawing.Point(12, 132);
            this.lvInventory.MultiSelect = false;
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(479, 217);
            this.lvInventory.TabIndex = 2;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            this.lvInventory.DoubleClick += new System.EventHandler(this.lvInventory_DoubleClick);
            // 
            // CarID
            // 
            this.CarID.Text = "CarID";
            this.CarID.Width = 50;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 80;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 80;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 100;
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            this.Condition.Width = 80;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(214, 419);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 27);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(416, 419);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 27);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Items.AddRange(new object[] {
            "All",
            "Honda",
            "Toyota"});
            this.cboMake.Location = new System.Drawing.Point(54, 12);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(137, 21);
            this.cboMake.TabIndex = 0;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.rdoUsed);
            this.gbCondition.Controls.Add(this.rdoNew);
            this.gbCondition.Location = new System.Drawing.Point(154, 355);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(192, 58);
            this.gbCondition.TabIndex = 7;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Condition:";
            // 
            // rdoUsed
            // 
            this.rdoUsed.AutoSize = true;
            this.rdoUsed.Location = new System.Drawing.Point(103, 23);
            this.rdoUsed.Name = "rdoUsed";
            this.rdoUsed.Size = new System.Drawing.Size(50, 17);
            this.rdoUsed.TabIndex = 1;
            this.rdoUsed.TabStop = true;
            this.rdoUsed.Tag = "1";
            this.rdoUsed.Text = "Used";
            this.rdoUsed.UseVisualStyleBackColor = true;
            this.rdoUsed.CheckedChanged += new System.EventHandler(this.rdoUsed_CheckedChanged);
            // 
            // rdoNew
            // 
            this.rdoNew.AutoSize = true;
            this.rdoNew.Location = new System.Drawing.Point(42, 23);
            this.rdoNew.Name = "rdoNew";
            this.rdoNew.Size = new System.Drawing.Size(47, 17);
            this.rdoNew.TabIndex = 0;
            this.rdoNew.TabStop = true;
            this.rdoNew.Tag = "0";
            this.rdoNew.Text = "New";
            this.rdoNew.UseVisualStyleBackColor = true;
            this.rdoNew.CheckedChanged += new System.EventHandler(this.rdoNew_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Make:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(416, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(54, 70);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(121, 21);
            this.cboModel.TabIndex = 1;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdminTools
            // 
            this.btnAdminTools.Location = new System.Drawing.Point(324, 68);
            this.btnAdminTools.Name = "btnAdminTools";
            this.btnAdminTools.Size = new System.Drawing.Size(86, 23);
            this.btnAdminTools.TabIndex = 12;
            this.btnAdminTools.Text = "Admin Tools";
            this.btnAdminTools.UseVisualStyleBackColor = true;
            this.btnAdminTools.Click += new System.EventHandler(this.btnAdminTools_Click);
            // 
            // lvlView
            // 
            this.lvlView.AutoSize = true;
            this.lvlView.Location = new System.Drawing.Point(9, 116);
            this.lvlView.Name = "lvlView";
            this.lvlView.Size = new System.Drawing.Size(134, 13);
            this.lvlView.TabIndex = 13;
            this.lvlView.Text = "Double-click to view detail:";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(451, 352);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 14;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // frmCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 459);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lvlView);
            this.Controls.Add(this.btnAdminTools);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCondition);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvInventory);
            this.Name = "frmCarDealership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmCarDealership_Load);
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.RadioButton rdoUsed;
        private System.Windows.Forms.RadioButton rdoNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ColumnHeader CarID;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdminTools;
        private System.Windows.Forms.Label lvlView;
        private System.Windows.Forms.Label lblLogout;
    }
}

