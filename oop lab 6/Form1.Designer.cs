
namespace oop_lab_6
{
    partial class Bilyard
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
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.bob = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость шара";
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(102, 22);
            this.speedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(120, 20);
            this.speedUpDown.TabIndex = 1;
            this.speedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUpDown.ValueChanged += new System.EventHandler(this.speedUpDown_ValueChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(402, 415);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Пуск";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(483, 415);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // bob
            // 
            this.bob.BackColor = System.Drawing.Color.Transparent;
            this.bob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bob.Location = new System.Drawing.Point(12, 48);
            this.bob.Name = "bob";
            this.bob.Size = new System.Drawing.Size(546, 342);
            this.bob.TabIndex = 4;
            this.bob.TabStop = false;
            this.bob.Click += new System.EventHandler(this.bob_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Таймер:";
            // 
            // Bilyard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bob);
            this.Controls.Add(this.close);
            this.Controls.Add(this.start);
            this.Controls.Add(this.speedUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Bilyard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бильярд";
            this.Load += new System.EventHandler(this.Bilyard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBob);
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox bob;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

