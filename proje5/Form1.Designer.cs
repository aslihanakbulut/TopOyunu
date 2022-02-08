
namespace proje5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_oyuncu = new System.Windows.Forms.Button();
            this.btn_ply = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.puan_txt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_oyuncu
            // 
            this.button_oyuncu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_oyuncu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_oyuncu, "button_oyuncu");
            this.button_oyuncu.Name = "button_oyuncu";
            this.button_oyuncu.UseVisualStyleBackColor = false;
            this.button_oyuncu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseDown);
            this.button_oyuncu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseMove);
            this.button_oyuncu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_oyuncu_MouseUp);
            // 
            // btn_ply
            // 
            resources.ApplyResources(this.btn_ply, "btn_ply");
            this.btn_ply.Name = "btn_ply";
            this.btn_ply.UseVisualStyleBackColor = true;
            this.btn_ply.Click += new System.EventHandler(this.btn_ply_Click);
            // 
            // btn_pause
            // 
            resources.ApplyResources(this.btn_pause, "btn_pause");
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // puan_txt
            // 
            this.puan_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.puan_txt, "puan_txt");
            this.puan_txt.Name = "puan_txt";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.puan_txt);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_ply);
            this.Controls.Add(this.button_oyuncu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_oyuncu;
        private System.Windows.Forms.Button btn_ply;
        private System.Windows.Forms.Button btn_pause;
        public System.Windows.Forms.TextBox puan_txt;
        private System.Windows.Forms.Timer timer1;
    }
}

