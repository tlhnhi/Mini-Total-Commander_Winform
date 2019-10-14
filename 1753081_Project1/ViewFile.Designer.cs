namespace _1753081_Project1
{
    partial class ViewFile
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
            this.FileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FileContent
            // 
            this.FileContent.BackColor = System.Drawing.SystemColors.Window;
            this.FileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileContent.Location = new System.Drawing.Point(6, 5);
            this.FileContent.Multiline = true;
            this.FileContent.Name = "FileContent";
            this.FileContent.ReadOnly = true;
            this.FileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileContent.Size = new System.Drawing.Size(789, 443);
            this.FileContent.TabIndex = 0;
            // 
            // ViewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.FileContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewFile";
            this.Text = "ViewFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileContent;
    }
}