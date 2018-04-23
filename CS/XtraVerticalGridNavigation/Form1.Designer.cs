namespace XtraVerticalGridNavigation
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
            this.chUseNavigator = new System.Windows.Forms.CheckBox();
            this.myVGridControl1 = new XtraVerticalGridNavigation.MyVGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.myVGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // chUseNavigator
            // 
            this.chUseNavigator.AutoSize = true;
            this.chUseNavigator.Checked = true;
            this.chUseNavigator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUseNavigator.Location = new System.Drawing.Point(12, 140);
            this.chUseNavigator.Name = "chUseNavigator";
            this.chUseNavigator.Size = new System.Drawing.Size(142, 17);
            this.chUseNavigator.TabIndex = 1;
            this.chUseNavigator.Text = "UseEmbeddedNavigator";
            this.chUseNavigator.UseVisualStyleBackColor = true;
            this.chUseNavigator.CheckedChanged += new System.EventHandler(this.chUseNavigator_CheckedChanged);
            // 
            // myVGridControl1
            // 
            this.myVGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.myVGridControl1.EmbeddedNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.myVGridControl1.EmbeddedNavigator.Location = new System.Drawing.Point(1, 165);
            this.myVGridControl1.EmbeddedNavigator.Name = "";
            this.myVGridControl1.EmbeddedNavigator.NavigatableControl = this.myVGridControl1;
            this.myVGridControl1.EmbeddedNavigator.Size = new System.Drawing.Size(262, 17);
            this.myVGridControl1.EmbeddedNavigator.TabIndex = 2;
            this.myVGridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.myVGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myVGridControl1.Name = "myVGridControl1";
            this.myVGridControl1.Size = new System.Drawing.Size(620, 183);
            this.myVGridControl1.TabIndex = 2;
            this.myVGridControl1.UseEmbeddedNavigator = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 183);
            this.Controls.Add(this.chUseNavigator);
            this.Controls.Add(this.myVGridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embedded Navigator";
            ((System.ComponentModel.ISupportInitialize)(this.myVGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chUseNavigator;
        private MyVGridControl myVGridControl1;

    }
}

