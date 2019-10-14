namespace _1753081_Project1
{
    partial class About
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
            this.Name = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.InfoP = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.CloseAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(10, 110);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(131, 19);
            this.Name.TabIndex = 0;
            this.Name.Text = "Trần Lê Hồng Nhi";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(10, 130);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(99, 19);
            this.Class.TabIndex = 1;
            this.Class.Text = "Lớp: 17CLC2";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(10, 150);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(118, 19);
            this.ID.TabIndex = 2;
            this.ID.Text = "MSSV: 1753081";
            // 
            // InfoP
            // 
            this.InfoP.AutoSize = true;
            this.InfoP.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoP.Location = new System.Drawing.Point(10, 28);
            this.InfoP.Name = "InfoP";
            this.InfoP.Size = new System.Drawing.Size(448, 23);
            this.InfoP.TabIndex = 3;
            this.InfoP.Text = "Xây dựng một ứng dụng tương tự Total Commander";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(10, 55);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(224, 19);
            this.Subject.TabIndex = 4;
            this.Subject.Text = "Môn học: Lập trình Windows";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(10, 10);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(65, 19);
            this.Info.TabIndex = 5;
            this.Info.Text = "Đồ án 1";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(10, 90);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(153, 19);
            this.Student.TabIndex = 6;
            this.Student.Text = "Sinh viên thực hiện";
            // 
            // CloseAbout
            // 
            this.CloseAbout.Location = new System.Drawing.Point(383, 150);
            this.CloseAbout.Name = "CloseAbout";
            this.CloseAbout.Size = new System.Drawing.Size(75, 23);
            this.CloseAbout.TabIndex = 7;
            this.CloseAbout.Text = "OK";
            this.CloseAbout.UseVisualStyleBackColor = true;
            this.CloseAbout.Click += new System.EventHandler(this.CloseAbout_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 181);
            this.Controls.Add(this.CloseAbout);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.InfoP);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label InfoP;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Button CloseAbout;
    }
}