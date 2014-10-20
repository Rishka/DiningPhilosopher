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
            this.endButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.phil1 = new System.Windows.Forms.Label();
            this.phil2 = new System.Windows.Forms.Label();
            this.phil3 = new System.Windows.Forms.Label();
            this.phil4 = new System.Windows.Forms.Label();
            this.phil5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(842, 555);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 0;
            this.endButton.Text = "Stop";
            this.endButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(761, 555);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // phil1
            // 
            this.phil1.AutoSize = true;
            this.phil1.Location = new System.Drawing.Point(307, 268);
            this.phil1.Name = "phil1";
            this.phil1.Size = new System.Drawing.Size(35, 13);
            this.phil1.TabIndex = 2;
            this.phil1.Text = "label1";
            // 
            // phil2
            // 
            this.phil2.AutoSize = true;
            this.phil2.Location = new System.Drawing.Point(307, 281);
            this.phil2.Name = "phil2";
            this.phil2.Size = new System.Drawing.Size(35, 13);
            this.phil2.TabIndex = 3;
            this.phil2.Text = "label2";
            // 
            // phil3
            // 
            this.phil3.AutoSize = true;
            this.phil3.Location = new System.Drawing.Point(307, 294);
            this.phil3.Name = "phil3";
            this.phil3.Size = new System.Drawing.Size(35, 13);
            this.phil3.TabIndex = 4;
            this.phil3.Text = "label3";
            // 
            // phil4
            // 
            this.phil4.AutoSize = true;
            this.phil4.Location = new System.Drawing.Point(307, 307);
            this.phil4.Name = "phil4";
            this.phil4.Size = new System.Drawing.Size(35, 13);
            this.phil4.TabIndex = 5;
            this.phil4.Text = "label4";
            // 
            // phil5
            // 
            this.phil5.AutoSize = true;
            this.phil5.Location = new System.Drawing.Point(307, 320);
            this.phil5.Name = "phil5";
            this.phil5.Size = new System.Drawing.Size(35, 13);
            this.phil5.TabIndex = 6;
            this.phil5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 590);
            this.Controls.Add(this.phil5);
            this.Controls.Add(this.phil4);
            this.Controls.Add(this.phil3);
            this.Controls.Add(this.phil2);
            this.Controls.Add(this.phil1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label phil1;
        private System.Windows.Forms.Label phil2;
        private System.Windows.Forms.Label phil3;
        private System.Windows.Forms.Label phil4;
        private System.Windows.Forms.Label phil5;
    }
}

