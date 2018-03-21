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
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.textBoxPath.Location = new System.Drawing.Point(4, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(182, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(4, 62);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(254, 394);
            this.listBoxItems.TabIndex = 2;
            this.listBoxItems.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(4, 31);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(254, 25);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "<----";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PanelTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.comboBoxDrives);
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
