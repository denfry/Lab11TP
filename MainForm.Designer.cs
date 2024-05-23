namespace Lab11TP
{
    partial class MainForm
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
            this.panelSpectator1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilm1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowInfo1 = new System.Windows.Forms.Button();
            this.btnDisconnect1 = new System.Windows.Forms.Button();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.btnShowMovie1 = new System.Windows.Forms.Button();
            this.panelSpectator2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnShowInfo2 = new System.Windows.Forms.Button();
            this.btnDisconnect2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSpectator1.SuspendLayout();
            this.panelSpectator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSpectator1
            // 
            this.panelSpectator1.Controls.Add(this.listBox1);
            this.panelSpectator1.Controls.Add(this.btnShowInfo1);
            this.panelSpectator1.Controls.Add(this.btnDisconnect1);
            this.panelSpectator1.Controls.Add(this.btnConnect1);
            this.panelSpectator1.Location = new System.Drawing.Point(212, 12);
            this.panelSpectator1.Name = "panelSpectator1";
            this.panelSpectator1.Size = new System.Drawing.Size(334, 219);
            this.panelSpectator1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 160);
            this.listBox1.TabIndex = 8;
            // 
            // txtFilm1
            // 
            this.txtFilm1.Location = new System.Drawing.Point(27, 192);
            this.txtFilm1.Name = "txtFilm1";
            this.txtFilm1.Size = new System.Drawing.Size(120, 20);
            this.txtFilm1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберете дату:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите название:";
            // 
            // btnShowInfo1
            // 
            this.btnShowInfo1.Location = new System.Drawing.Point(227, 193);
            this.btnShowInfo1.Name = "btnShowInfo1";
            this.btnShowInfo1.Size = new System.Drawing.Size(106, 23);
            this.btnShowInfo1.TabIndex = 3;
            this.btnShowInfo1.Text = "Показать инфо";
            this.btnShowInfo1.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect1
            // 
            this.btnDisconnect1.Location = new System.Drawing.Point(115, 193);
            this.btnDisconnect1.Name = "btnDisconnect1";
            this.btnDisconnect1.Size = new System.Drawing.Size(106, 23);
            this.btnDisconnect1.TabIndex = 2;
            this.btnDisconnect1.Text = "Отключиться";
            this.btnDisconnect1.UseVisualStyleBackColor = true;
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(3, 193);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(106, 23);
            this.btnConnect1.TabIndex = 1;
            this.btnConnect1.Text = "Подключиться";
            this.btnConnect1.UseVisualStyleBackColor = true;
            // 
            // btnShowMovie1
            // 
            this.btnShowMovie1.Location = new System.Drawing.Point(37, 346);
            this.btnShowMovie1.Name = "btnShowMovie1";
            this.btnShowMovie1.Size = new System.Drawing.Size(103, 23);
            this.btnShowMovie1.TabIndex = 0;
            this.btnShowMovie1.Text = "Показать фильм";
            this.btnShowMovie1.UseVisualStyleBackColor = true;
            // 
            // panelSpectator2
            // 
            this.panelSpectator2.Controls.Add(this.listBox2);
            this.panelSpectator2.Controls.Add(this.btnShowInfo2);
            this.panelSpectator2.Controls.Add(this.btnDisconnect2);
            this.panelSpectator2.Controls.Add(this.btnConnect2);
            this.panelSpectator2.Location = new System.Drawing.Point(212, 260);
            this.panelSpectator2.Name = "panelSpectator2";
            this.panelSpectator2.Size = new System.Drawing.Size(334, 219);
            this.panelSpectator2.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(330, 160);
            this.listBox2.TabIndex = 8;
            // 
            // btnShowInfo2
            // 
            this.btnShowInfo2.Location = new System.Drawing.Point(227, 193);
            this.btnShowInfo2.Name = "btnShowInfo2";
            this.btnShowInfo2.Size = new System.Drawing.Size(106, 23);
            this.btnShowInfo2.TabIndex = 3;
            this.btnShowInfo2.Text = "Показать инфо";
            this.btnShowInfo2.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect2
            // 
            this.btnDisconnect2.Location = new System.Drawing.Point(115, 193);
            this.btnDisconnect2.Name = "btnDisconnect2";
            this.btnDisconnect2.Size = new System.Drawing.Size(106, 23);
            this.btnDisconnect2.TabIndex = 2;
            this.btnDisconnect2.Text = "Отключиться";
            this.btnDisconnect2.UseVisualStyleBackColor = true;
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(3, 193);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(106, 23);
            this.btnConnect2.TabIndex = 1;
            this.btnConnect2.Text = "Подключиться";
            this.btnConnect2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 253);
            this.panel1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 491);
            this.Controls.Add(this.txtFilm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelSpectator2);
            this.Controls.Add(this.panelSpectator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowMovie1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №11";
            this.panelSpectator1.ResumeLayout(false);
            this.panelSpectator2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSpectator1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtFilm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowInfo1;
        private System.Windows.Forms.Button btnDisconnect1;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnShowMovie1;
        private System.Windows.Forms.Panel panelSpectator2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnShowInfo2;
        private System.Windows.Forms.Button btnDisconnect2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Panel panel1;
    }
}

