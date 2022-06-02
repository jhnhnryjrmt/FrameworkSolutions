namespace FrameworkSolutions
{
    partial class BaseFormList
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
            this.infoBarLite1 = new inamsoft.ui.LiteControls.InfoBarLite();
            this.SuspendLayout();
            // 
            // infoBarLite1
            // 
            this.infoBarLite1.BackColor = System.Drawing.SystemColors.Window;
            this.infoBarLite1.BackStyle = inamsoft.ui.LiteControls.BackStyle.Gradient;
            this.infoBarLite1.BorderSide = System.Windows.Forms.Border3DSide.Bottom;
            this.infoBarLite1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.infoBarLite1.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoBarLite1.GradientEndColor = System.Drawing.Color.White;
            this.infoBarLite1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.infoBarLite1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.infoBarLite1.Image = null;
            this.infoBarLite1.ImageAlign = inamsoft.ui.LiteControls.ImageAlignment.TopLeft;
            this.infoBarLite1.ImageOffsetX = 2;
            this.infoBarLite1.ImageOffsetY = 0;
            this.infoBarLite1.Location = new System.Drawing.Point(0, 0);
            this.infoBarLite1.Name = "infoBarLite1";
            this.infoBarLite1.Size = new System.Drawing.Size(457, 60);
            this.infoBarLite1.TabIndex = 0;
            this.infoBarLite1.Text1 = "Peace at home, peace in the world!";
            this.infoBarLite1.Text1Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.infoBarLite1.Text1ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoBarLite1.Text1OffsetX = 0;
            this.infoBarLite1.Text1OffsetY = 0;
            this.infoBarLite1.Text2 = "The quick brown fox lazily jumped over the bridge.";
            this.infoBarLite1.Text2Font = new System.Drawing.Font("Tahoma", 8F);
            this.infoBarLite1.Text2ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoBarLite1.Text2OffsetX = 20;
            this.infoBarLite1.Text2OffsetY = 0;
            // 
            // BaseFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.Controls.Add(this.infoBarLite1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseFormList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseFormList";
            this.ResumeLayout(false);

        }

        #endregion

        private inamsoft.ui.LiteControls.InfoBarLite infoBarLite1;
    }
}