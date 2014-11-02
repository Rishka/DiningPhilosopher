namespace DiningPhilosophers
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
            this.phil1 = new System.Windows.Forms.Label();
            this.phil2 = new System.Windows.Forms.Label();
            this.phil3 = new System.Windows.Forms.Label();
            this.phil4 = new System.Windows.Forms.Label();
            this.phil5 = new System.Windows.Forms.Label();
            this.Philosopher1 = new System.Windows.Forms.Label();
            this.Philosoper2 = new System.Windows.Forms.Label();
            this.Philosoper3 = new System.Windows.Forms.Label();
            this.Philosoper4 = new System.Windows.Forms.Label();
            this.Philosoper5 = new System.Windows.Forms.Label();
            this.Fork2 = new System.Windows.Forms.CheckBox();
            this.Fork3 = new System.Windows.Forms.CheckBox();
            this.Fork4 = new System.Windows.Forms.CheckBox();
            this.Fork5 = new System.Windows.Forms.CheckBox();
            this.Fork1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // phil1
            // 
            this.phil1.AutoSize = true;
            this.phil1.Location = new System.Drawing.Point(170, 22);
            this.phil1.Name = "phil1";
            this.phil1.Size = new System.Drawing.Size(35, 13);
            this.phil1.TabIndex = 2;
            this.phil1.Text = "label1";
            // 
            // phil2
            // 
            this.phil2.AutoSize = true;
            this.phil2.Location = new System.Drawing.Point(8, 95);
            this.phil2.Name = "phil2";
            this.phil2.Size = new System.Drawing.Size(35, 13);
            this.phil2.TabIndex = 3;
            this.phil2.Text = "label2";
            // 
            // phil3
            // 
            this.phil3.AutoSize = true;
            this.phil3.Location = new System.Drawing.Point(53, 218);
            this.phil3.Name = "phil3";
            this.phil3.Size = new System.Drawing.Size(35, 13);
            this.phil3.TabIndex = 4;
            this.phil3.Text = "label3";
            // 
            // phil4
            // 
            this.phil4.AutoSize = true;
            this.phil4.Location = new System.Drawing.Point(297, 218);
            this.phil4.Name = "phil4";
            this.phil4.Size = new System.Drawing.Size(35, 13);
            this.phil4.TabIndex = 5;
            this.phil4.Text = "label4";
            // 
            // phil5
            // 
            this.phil5.AutoSize = true;
            this.phil5.Location = new System.Drawing.Point(297, 95);
            this.phil5.Name = "phil5";
            this.phil5.Size = new System.Drawing.Size(35, 13);
            this.phil5.TabIndex = 6;
            this.phil5.Text = "label5";
            // 
            // Philosopher1
            // 
            this.Philosopher1.AutoSize = true;
            this.Philosopher1.Location = new System.Drawing.Point(170, 9);
            this.Philosopher1.Name = "Philosopher1";
            this.Philosopher1.Size = new System.Drawing.Size(71, 13);
            this.Philosopher1.TabIndex = 7;
            this.Philosopher1.Text = "Philosopher 1";
            // 
            // Philosoper2
            // 
            this.Philosoper2.AutoSize = true;
            this.Philosoper2.Location = new System.Drawing.Point(8, 82);
            this.Philosoper2.Name = "Philosoper2";
            this.Philosoper2.Size = new System.Drawing.Size(71, 13);
            this.Philosoper2.TabIndex = 8;
            this.Philosoper2.Text = "Philosopher 2";
            // 
            // Philosoper3
            // 
            this.Philosoper3.AutoSize = true;
            this.Philosoper3.Location = new System.Drawing.Point(51, 205);
            this.Philosoper3.Name = "Philosoper3";
            this.Philosoper3.Size = new System.Drawing.Size(71, 13);
            this.Philosoper3.TabIndex = 9;
            this.Philosoper3.Text = "Philosopher 3";
            this.Philosoper3.Click += new System.EventHandler(this.Philosoper3_Click);
            // 
            // Philosoper4
            // 
            this.Philosoper4.AutoSize = true;
            this.Philosoper4.Location = new System.Drawing.Point(297, 205);
            this.Philosoper4.Name = "Philosoper4";
            this.Philosoper4.Size = new System.Drawing.Size(71, 13);
            this.Philosoper4.TabIndex = 10;
            this.Philosoper4.Text = "Philosopher 4";
            // 
            // Philosoper5
            // 
            this.Philosoper5.AutoSize = true;
            this.Philosoper5.Location = new System.Drawing.Point(297, 82);
            this.Philosoper5.Name = "Philosoper5";
            this.Philosoper5.Size = new System.Drawing.Size(71, 13);
            this.Philosoper5.TabIndex = 11;
            this.Philosoper5.Text = "Philosopher 5";
            // 
            // Fork2
            // 
            this.Fork2.AutoSize = true;
            this.Fork2.Location = new System.Drawing.Point(44, 41);
            this.Fork2.Name = "Fork2";
            this.Fork2.Size = new System.Drawing.Size(106, 17);
            this.Fork2.TabIndex = 12;
            this.Fork2.Text = "Fork 2: On Table";
            this.Fork2.UseVisualStyleBackColor = true;
            // 
            // Fork3
            // 
            this.Fork3.AutoSize = true;
            this.Fork3.Location = new System.Drawing.Point(44, 154);
            this.Fork3.Name = "Fork3";
            this.Fork3.Size = new System.Drawing.Size(106, 17);
            this.Fork3.TabIndex = 13;
            this.Fork3.Text = "Fork 3: On Table";
            this.Fork3.UseVisualStyleBackColor = true;
            this.Fork3.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Fork4
            // 
            this.Fork4.AutoSize = true;
            this.Fork4.Location = new System.Drawing.Point(173, 184);
            this.Fork4.Name = "Fork4";
            this.Fork4.Size = new System.Drawing.Size(106, 17);
            this.Fork4.TabIndex = 14;
            this.Fork4.Text = "Fork 4: On Table";
            this.Fork4.UseVisualStyleBackColor = true;
            // 
            // Fork5
            // 
            this.Fork5.AutoSize = true;
            this.Fork5.Location = new System.Drawing.Point(300, 154);
            this.Fork5.Name = "Fork5";
            this.Fork5.Size = new System.Drawing.Size(106, 17);
            this.Fork5.TabIndex = 15;
            this.Fork5.Text = "Fork 5: On Table";
            this.Fork5.UseVisualStyleBackColor = true;
            // 
            // Fork1
            // 
            this.Fork1.AutoSize = true;
            this.Fork1.Location = new System.Drawing.Point(285, 41);
            this.Fork1.Name = "Fork1";
            this.Fork1.Size = new System.Drawing.Size(106, 17);
            this.Fork1.TabIndex = 16;
            this.Fork1.Text = "Fork 1: On Table";
            this.Fork1.UseVisualStyleBackColor = true;
            this.Fork1.CheckedChanged += new System.EventHandler(this.Fork1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 270);
            this.Controls.Add(this.Fork1);
            this.Controls.Add(this.Fork5);
            this.Controls.Add(this.Fork4);
            this.Controls.Add(this.Fork3);
            this.Controls.Add(this.Fork2);
            this.Controls.Add(this.Philosoper5);
            this.Controls.Add(this.Philosoper4);
            this.Controls.Add(this.Philosoper3);
            this.Controls.Add(this.Philosoper2);
            this.Controls.Add(this.Philosopher1);
            this.Controls.Add(this.phil5);
            this.Controls.Add(this.phil4);
            this.Controls.Add(this.phil3);
            this.Controls.Add(this.phil2);
            this.Controls.Add(this.phil1);
            this.Name = "Form1";
            this.Text = "Dining Philosophers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phil1;
        private System.Windows.Forms.Label phil2;
        private System.Windows.Forms.Label phil3;
        private System.Windows.Forms.Label phil4;
        private System.Windows.Forms.Label phil5;
        private System.Windows.Forms.Label Philosopher1;
        private System.Windows.Forms.Label Philosoper2;
        private System.Windows.Forms.Label Philosoper3;
        private System.Windows.Forms.Label Philosoper4;
        private System.Windows.Forms.Label Philosoper5;
        private System.Windows.Forms.CheckBox Fork2;
        private System.Windows.Forms.CheckBox Fork3;
        private System.Windows.Forms.CheckBox Fork4;
        private System.Windows.Forms.CheckBox Fork5;
        private System.Windows.Forms.CheckBox Fork1;
    }
}

