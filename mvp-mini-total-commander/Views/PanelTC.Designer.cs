namespace mvp_mini_total_commander.Views
{
    partial class PanelTC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDrives.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxDrives.Location = new System.Drawing.Point(192, 3);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(66, 21);
            this.comboBoxDrives.TabIndex = 0;
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_ChangeValue);
            this.comboBoxDrives.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPath.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPath.Location = new System.Drawing.Point(4, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPath.Size = new System.Drawing.Size(182, 19);
            this.textBoxPath.TabIndex = 1;
            // 
            // listBoxItems
            // 
            this.listBoxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.listBoxItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxItems.ForeColor = System.Drawing.Color.Silver;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(4, 62);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxItems.Size = new System.Drawing.Size(254, 390);
            this.listBoxItems.TabIndex = 2;
            this.listBoxItems.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Silver;
            this.buttonBack.Location = new System.Drawing.Point(4, 31);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(254, 25);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "<----";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PanelTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.comboBoxDrives);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "PanelTC";
            this.Size = new System.Drawing.Size(261, 459);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonBack;
    }
}
