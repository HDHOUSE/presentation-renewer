namespace presentation_renewer
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
            this.buttonSelectPresentation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_presentationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_pathBackground = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectBackground = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectPresentation
            // 
            this.buttonSelectPresentation.Location = new System.Drawing.Point(15, 19);
            this.buttonSelectPresentation.Name = "buttonSelectPresentation";
            this.buttonSelectPresentation.Size = new System.Drawing.Size(75, 51);
            this.buttonSelectPresentation.TabIndex = 0;
            this.buttonSelectPresentation.Text = "Выбрать";
            this.buttonSelectPresentation.UseVisualStyleBackColor = true;
            this.buttonSelectPresentation.Click += new System.EventHandler(this.buttonSelectPresentation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_presentationPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSelectPresentation);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оригинальня презентация";
            // 
            // textBox_presentationPath
            // 
            this.textBox_presentationPath.Location = new System.Drawing.Point(146, 21);
            this.textBox_presentationPath.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_presentationPath.Multiline = true;
            this.textBox_presentationPath.Name = "textBox_presentationPath";
            this.textBox_presentationPath.ReadOnly = true;
            this.textBox_presentationPath.Size = new System.Drawing.Size(624, 49);
            this.textBox_presentationPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_pathBackground);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonSelectBackground);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фоновое изображение";
            // 
            // textBox_pathBackground
            // 
            this.textBox_pathBackground.Location = new System.Drawing.Point(146, 21);
            this.textBox_pathBackground.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_pathBackground.Multiline = true;
            this.textBox_pathBackground.Name = "textBox_pathBackground";
            this.textBox_pathBackground.ReadOnly = true;
            this.textBox_pathBackground.Size = new System.Drawing.Size(624, 49);
            this.textBox_pathBackground.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Путь:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSelectBackground
            // 
            this.buttonSelectBackground.Location = new System.Drawing.Point(15, 19);
            this.buttonSelectBackground.Name = "buttonSelectBackground";
            this.buttonSelectBackground.Size = new System.Drawing.Size(75, 51);
            this.buttonSelectBackground.TabIndex = 0;
            this.buttonSelectBackground.Text = "Выбрать";
            this.buttonSelectBackground.UseVisualStyleBackColor = true;
            this.buttonSelectBackground.Click += new System.EventHandler(this.buttonSelectBackground_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 223);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(241, 34);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Выполнить обновление";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(272, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 34);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 265);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Presentation renewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectPresentation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_presentationPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_pathBackground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectBackground;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

