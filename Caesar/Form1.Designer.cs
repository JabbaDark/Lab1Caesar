namespace Caesar
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
            this.CodeOne = new System.Windows.Forms.Button();
            this.CodeAll = new System.Windows.Forms.Button();
            this.MesMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Move = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MesFin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeOne
            // 
            this.CodeOne.Location = new System.Drawing.Point(242, 106);
            this.CodeOne.Name = "CodeOne";
            this.CodeOne.Size = new System.Drawing.Size(121, 21);
            this.CodeOne.TabIndex = 0;
            this.CodeOne.Text = "Зашифровать";
            this.CodeOne.UseVisualStyleBackColor = true;
            this.CodeOne.Click += new System.EventHandler(this.CodeOne_Click);
            // 
            // CodeAll
            // 
            this.CodeAll.Location = new System.Drawing.Point(242, 142);
            this.CodeAll.Name = "CodeAll";
            this.CodeAll.Size = new System.Drawing.Size(121, 23);
            this.CodeAll.TabIndex = 1;
            this.CodeAll.Text = "Все варианты";
            this.CodeAll.UseVisualStyleBackColor = true;
            this.CodeAll.Click += new System.EventHandler(this.CodeAll_Click);
            // 
            // MesMain
            // 
            this.MesMain.Location = new System.Drawing.Point(12, 39);
            this.MesMain.Name = "MesMain";
            this.MesMain.Size = new System.Drawing.Size(343, 20);
            this.MesMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходное сообщение";
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(70, 62);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(34, 20);
            this.Move.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сдвиг на";
            // 
            // MesFin
            // 
            this.MesFin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MesFin.Location = new System.Drawing.Point(12, 107);
            this.MesFin.Multiline = true;
            this.MesFin.Name = "MesFin";
            this.MesFin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MesFin.Size = new System.Drawing.Size(224, 368);
            this.MesFin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Полученные сообщения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Кодировать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Декодировать файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MesMain);
            this.Controls.Add(this.CodeAll);
            this.Controls.Add(this.CodeOne);
            this.Name = "Form1";
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CodeOne;
        private System.Windows.Forms.Button CodeAll;
        private System.Windows.Forms.TextBox MesMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Move;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MesFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

