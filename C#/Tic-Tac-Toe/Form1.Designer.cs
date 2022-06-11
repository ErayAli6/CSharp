namespace TicTacToe
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
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b2.Location = new System.Drawing.Point(128, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(125, 81);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b3.Location = new System.Drawing.Point(250, 12);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(125, 81);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b4.Location = new System.Drawing.Point(9, 90);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(125, 81);
            this.b4.TabIndex = 4;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b5.Location = new System.Drawing.Point(128, 90);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(125, 81);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b6.Location = new System.Drawing.Point(250, 90);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(125, 81);
            this.b6.TabIndex = 6;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b7.Location = new System.Drawing.Point(9, 168);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(125, 81);
            this.b7.TabIndex = 7;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b8.Location = new System.Drawing.Point(128, 168);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(125, 81);
            this.b8.TabIndex = 8;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b9.Location = new System.Drawing.Point(250, 168);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(125, 81);
            this.b9.TabIndex = 9;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(9, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(122, 81);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 264);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b1;
    }
}

