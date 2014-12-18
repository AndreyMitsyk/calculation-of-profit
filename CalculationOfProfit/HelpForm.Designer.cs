namespace CalculationOfProfit
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.tb_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Help
            // 
            this.tb_Help.BackColor = System.Drawing.Color.White;
            this.tb_Help.CausesValidation = false;
            this.tb_Help.Location = new System.Drawing.Point(12, 12);
            this.tb_Help.Multiline = true;
            this.tb_Help.Name = "tb_Help";
            this.tb_Help.ReadOnly = true;
            this.tb_Help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Help.Size = new System.Drawing.Size(255, 318);
            this.tb_Help.TabIndex = 14;
            this.tb_Help.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 342);
            this.Controls.Add(this.tb_Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Help;
    }
}