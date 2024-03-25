namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.Label amount_PLabel;
            System.Windows.Forms.Label coeff_costLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label statusLabel;
            this.amount_PTextBox = new System.Windows.Forms.TextBox();
            this.coeff_costTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ReturnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mallBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mallBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            amount_PLabel = new System.Windows.Forms.Label();
            coeff_costLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_PLabel
            // 
            amount_PLabel.AutoSize = true;
            amount_PLabel.Location = new System.Drawing.Point(160, 120);
            amount_PLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            amount_PLabel.Name = "amount_PLabel";
            amount_PLabel.Size = new System.Drawing.Size(119, 28);
            amount_PLabel.TabIndex = 1;
            amount_PLabel.Text = "Amount P:";
            // 
            // coeff_costLabel
            // 
            coeff_costLabel.AutoSize = true;
            coeff_costLabel.Location = new System.Drawing.Point(160, 169);
            coeff_costLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            coeff_costLabel.Name = "coeff_costLabel";
            coeff_costLabel.Size = new System.Drawing.Size(120, 28);
            coeff_costLabel.TabIndex = 3;
            coeff_costLabel.Text = "Coeff cost:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(160, 218);
            costLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(64, 28);
            costLabel.TabIndex = 5;
            costLabel.Text = "Cost:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(160, 267);
            floorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(69, 28);
            floorLabel.TabIndex = 7;
            floorLabel.Text = "Floor:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(160, 327);
            nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(78, 28);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new System.Drawing.Point(160, 431);
            townLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(75, 28);
            townLabel.TabIndex = 17;
            townLabel.Text = "Town:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(160, 379);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(84, 28);
            statusLabel.TabIndex = 21;
            statusLabel.Text = "Status:";
            // 
            // amount_PTextBox
            // 
            this.amount_PTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Amount_P", true));
            this.amount_PTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.amount_PTextBox.Location = new System.Drawing.Point(282, 115);
            this.amount_PTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.amount_PTextBox.Name = "amount_PTextBox";
            this.amount_PTextBox.Size = new System.Drawing.Size(160, 35);
            this.amount_PTextBox.TabIndex = 2;
            // 
            // coeff_costTextBox
            // 
            this.coeff_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Coeff_cost", true));
            this.coeff_costTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.coeff_costTextBox.Location = new System.Drawing.Point(282, 164);
            this.coeff_costTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.coeff_costTextBox.Name = "coeff_costTextBox";
            this.coeff_costTextBox.Size = new System.Drawing.Size(160, 35);
            this.coeff_costTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Cost", true));
            this.costTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.costTextBox.Location = new System.Drawing.Point(282, 213);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(160, 35);
            this.costTextBox.TabIndex = 6;
            // 
            // floorTextBox
            // 
            this.floorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Floor", true));
            this.floorTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.floorTextBox.Location = new System.Drawing.Point(282, 262);
            this.floorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(160, 35);
            this.floorTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Name", true));
            this.nameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.nameTextBox.Location = new System.Drawing.Point(282, 321);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 35);
            this.nameTextBox.TabIndex = 14;
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Town", true));
            this.townTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.townTextBox.Location = new System.Drawing.Point(282, 425);
            this.townTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(160, 35);
            this.townTextBox.TabIndex = 18;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAdd.Location = new System.Drawing.Point(511, 196);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(351, 142);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ReturnExit
            // 
            this.ReturnExit.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnExit.Location = new System.Drawing.Point(24, 16);
            this.ReturnExit.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnExit.Name = "ReturnExit";
            this.ReturnExit.Size = new System.Drawing.Size(155, 52);
            this.ReturnExit.TabIndex = 20;
            this.ReturnExit.Text = "Назад";
            this.ReturnExit.UseVisualStyleBackColor = false;
            this.ReturnExit.Click += new System.EventHandler(this.ReturnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ReturnExit);
            this.panel1.Location = new System.Drawing.Point(-10, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 83);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новый ТЦ";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.RosyBrown;
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "План",
            "Строительсто",
            "Удален",
            "Реализация"});
            this.statusComboBox.Location = new System.Drawing.Point(282, 376);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(160, 36);
            this.statusComboBox.TabIndex = 22;
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(WindowsFormsApp1.FolderForModel.Mall);
            // 
            // mallBindingSource3
            // 
            this.mallBindingSource3.DataSource = typeof(WindowsFormsApp1.FolderForModel.Mall);
            // 
            // mallBindingSource2
            // 
            this.mallBindingSource2.DataSource = typeof(WindowsFormsApp1.FolderForModel.Mall);
            // 
            // mallBindingSource1
            // 
            this.mallBindingSource1.DataSource = typeof(WindowsFormsApp1.FolderForModel.Mall);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(amount_PLabel);
            this.Controls.Add(this.amount_PTextBox);
            this.Controls.Add(coeff_costLabel);
            this.Controls.Add(this.coeff_costTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mallBindingSource;
        private System.Windows.Forms.TextBox amount_PTextBox;
        private System.Windows.Forms.TextBox coeff_costTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button ReturnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingSource mallBindingSource2;
        private System.Windows.Forms.BindingSource mallBindingSource1;
        private System.Windows.Forms.BindingSource mallBindingSource3;
    }
}