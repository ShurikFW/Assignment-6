namespace Assignment_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlayerPic = new System.Windows.Forms.PictureBox();
            this.CpuPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 0;
            this.button1.Tag = "R";
            this.button1.Text = "Rock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeChoiseEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 54);
            this.button2.TabIndex = 1;
            this.button2.Tag = "P";
            this.button2.Text = "Paper";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MakeChoiseEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 54);
            this.button3.TabIndex = 2;
            this.button3.Tag = "S";
            this.button3.Text = "Sciccors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeChoiseEvent);
            // 
            // PlayerPic
            // 
            this.PlayerPic.Location = new System.Drawing.Point(110, 86);
            this.PlayerPic.Name = "PlayerPic";
            this.PlayerPic.Size = new System.Drawing.Size(224, 184);
            this.PlayerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPic.TabIndex = 3;
            this.PlayerPic.TabStop = false;
            this.PlayerPic.Click += new System.EventHandler(this.PlayerPic_Click);
            // 
            // CpuPic
            // 
            this.CpuPic.Location = new System.Drawing.Point(473, 86);
            this.CpuPic.Name = "CpuPic";
            this.CpuPic.Size = new System.Drawing.Size(232, 184);
            this.CpuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CpuPic.TabIndex = 4;
            this.CpuPic.TabStop = false;
            this.CpuPic.Tag = "";
            this.CpuPic.Click += new System.EventHandler(this.CpuPic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "PLAYER";
            this.label4.Click += new System.EventHandler(this.PLAYER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "COMPUTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "PLAYER RESULT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "COMPUTER RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CpuPic);
            this.Controls.Add(this.PlayerPic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Tag = "R";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.MakeChoiseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox PlayerPic;
        private System.Windows.Forms.PictureBox CpuPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

