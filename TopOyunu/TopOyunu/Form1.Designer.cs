
namespace TopOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_oyuncu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.puan_txt = new System.Windows.Forms.TextBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_ply = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 455);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(480, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 20);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 20);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_oyuncu
            // 
            this.button_oyuncu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_oyuncu.FlatAppearance.BorderSize = 0;
            this.button_oyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oyuncu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_oyuncu.Location = new System.Drawing.Point(320, 430);
            this.button_oyuncu.Name = "button_oyuncu";
            this.button_oyuncu.Size = new System.Drawing.Size(180, 20);
            this.button_oyuncu.TabIndex = 10;
            this.button_oyuncu.UseVisualStyleBackColor = false;
            this.button_oyuncu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseDown);
            this.button_oyuncu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseMove);
            this.button_oyuncu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(762, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 455);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // puan_txt
            // 
            this.puan_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puan_txt.Location = new System.Drawing.Point(638, 26);
            this.puan_txt.Name = "puan_txt";
            this.puan_txt.Size = new System.Drawing.Size(113, 20);
            this.puan_txt.TabIndex = 14;
            // 
            // btn_pause
            // 
            this.btn_pause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pause.Location = new System.Drawing.Point(662, 412);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(94, 29);
            this.btn_pause.TabIndex = 13;
            this.btn_pause.Text = "PAUSE";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_ply
            // 
            this.btn_ply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ply.Location = new System.Drawing.Point(562, 412);
            this.btn_ply.Name = "btn_ply";
            this.btn_ply.Size = new System.Drawing.Size(94, 29);
            this.btn_ply.TabIndex = 12;
            this.btn_ply.Text = "PLAY";
            this.btn_ply.UseVisualStyleBackColor = true;
            this.btn_ply.Click += new System.EventHandler(this.btn_ply_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.puan_txt);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_ply);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_oyuncu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_oyuncu;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox puan_txt;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_ply;
        private System.Windows.Forms.Timer timer1;
    }
}

