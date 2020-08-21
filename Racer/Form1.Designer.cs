namespace Racer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carorange = new System.Windows.Forms.PictureBox();
            this.carblue = new System.Windows.Forms.PictureBox();
            this.mycar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carorange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(84, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 108);
            this.label1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 108);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(84, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 108);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(84, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 108);
            this.label4.TabIndex = 3;
            // 
            // carorange
            // 
            this.carorange.Image = global::Racer.Properties.Resources.car21;
            this.carorange.Location = new System.Drawing.Point(135, 12);
            this.carorange.Name = "carorange";
            this.carorange.Size = new System.Drawing.Size(43, 54);
            this.carorange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carorange.TabIndex = 6;
            this.carorange.TabStop = false;
            // 
            // carblue
            // 
            this.carblue.Image = global::Racer.Properties.Resources.car11;
            this.carblue.Location = new System.Drawing.Point(24, 39);
            this.carblue.Name = "carblue";
            this.carblue.Size = new System.Drawing.Size(43, 54);
            this.carblue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carblue.TabIndex = 5;
            this.carblue.TabStop = false;
            // 
            // mycar
            // 
            this.mycar.Image = global::Racer.Properties.Resources.car3;
            this.mycar.Location = new System.Drawing.Point(107, 325);
            this.mycar.Name = "mycar";
            this.mycar.Size = new System.Drawing.Size(47, 57);
            this.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mycar.TabIndex = 4;
            this.mycar.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(190, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carorange);
            this.Controls.Add(this.carblue);
            this.Controls.Add(this.mycar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Гоночнки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carorange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox mycar;
        private System.Windows.Forms.PictureBox carblue;
        private System.Windows.Forms.PictureBox carorange;
        private System.Windows.Forms.Label label5;
    }
}

