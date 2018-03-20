namespace mvp_mini_total_commander.Views
{
    partial class ViewTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTC));
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelTCRight = new mvp_mini_total_commander.Views.PanelTC();
            this.panelTCLeft = new mvp_mini_total_commander.Views.PanelTC();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(279, 79);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(279, 108);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(279, 137);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // panelTCRight
            // 
            this.panelTCRight.Drives = ((System.Collections.Generic.List<string>)(resources.GetObject("panelTCRight.Drives")));
            this.panelTCRight.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("panelTCRight.Items")));
            this.panelTCRight.Location = new System.Drawing.Point(360, 13);
            this.panelTCRight.Name = "panelTCRight";
            this.panelTCRight.Path = "";
            this.panelTCRight.Size = new System.Drawing.Size(261, 459);
            this.panelTCRight.TabIndex = 1;
            this.panelTCRight.Load += new System.EventHandler(this.onLoad);
            // 
            // panelTCLeft
            // 
            this.panelTCLeft.Drives = ((System.Collections.Generic.List<string>)(resources.GetObject("panelTCLeft.Drives")));
            this.panelTCLeft.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("panelTCLeft.Items")));
            this.panelTCLeft.Location = new System.Drawing.Point(13, 13);
            this.panelTCLeft.Name = "panelTCLeft";
            this.panelTCLeft.Path = "";
            this.panelTCLeft.Size = new System.Drawing.Size(261, 459);
            this.panelTCLeft.TabIndex = 0;
            this.panelTCLeft.Load += new System.EventHandler(this.onLoad);
            // 
            // ViewTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 479);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.panelTCRight);
            this.Controls.Add(this.panelTCLeft);
            this.Name = "ViewTC";
            this.Text = "Total Commander";
            this.ResumeLayout(false);

        }

        #endregion

        private PanelTC panelTCLeft;
        private PanelTC panelTCRight;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonDelete;
    }
}