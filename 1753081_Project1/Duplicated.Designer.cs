namespace _1753081_Project1
{
    partial class Duplicated
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
            this.Overwrite = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.OverwriteAll = new System.Windows.Forms.Button();
            this.SkipAll = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Overwrite
            // 
            this.Overwrite.Location = new System.Drawing.Point(12, 94);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(75, 23);
            this.Overwrite.TabIndex = 1;
            this.Overwrite.Text = "Overwrite";
            this.Overwrite.UseVisualStyleBackColor = true;
            this.Overwrite.Click += new System.EventHandler(this.Overwrite_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(93, 94);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(75, 23);
            this.Skip.TabIndex = 2;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // OverwriteAll
            // 
            this.OverwriteAll.Location = new System.Drawing.Point(174, 94);
            this.OverwriteAll.Name = "OverwriteAll";
            this.OverwriteAll.Size = new System.Drawing.Size(75, 23);
            this.OverwriteAll.TabIndex = 3;
            this.OverwriteAll.Text = "Overwrite all";
            this.OverwriteAll.UseVisualStyleBackColor = true;
            this.OverwriteAll.Click += new System.EventHandler(this.OverwriteAll_Click);
            // 
            // SkipAll
            // 
            this.SkipAll.Location = new System.Drawing.Point(255, 94);
            this.SkipAll.Name = "SkipAll";
            this.SkipAll.Size = new System.Drawing.Size(75, 23);
            this.SkipAll.TabIndex = 4;
            this.SkipAll.Text = "Skip all";
            this.SkipAll.UseVisualStyleBackColor = true;
            this.SkipAll.Click += new System.EventHandler(this.SkipAll_Click);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.Window;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(12, 12);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(320, 67);
            this.Message.TabIndex = 5;
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Duplicated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 131);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.SkipAll);
            this.Controls.Add(this.OverwriteAll);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Overwrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Duplicated";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicated files or folders!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Overwrite;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button OverwriteAll;
        private System.Windows.Forms.Button SkipAll;
        private System.Windows.Forms.TextBox Message;
    }
}