namespace LanguageRichnessAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WordCountLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AverageSentenceLengthLabel = new System.Windows.Forms.Label();
            this.UniqueWordCountLabel = new System.Windows.Forms.Label();
            this.ComplexWordCountLabel = new System.Windows.Forms.Label();
            this.AverageWordLengthLabel = new System.Windows.Forms.Label();
            this.WordFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordCountLabel
            // 
            this.WordCountLabel.AutoSize = true;
            this.WordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordCountLabel.Location = new System.Drawing.Point(12, 76);
            this.WordCountLabel.Name = "WordCountLabel";
            this.WordCountLabel.Size = new System.Drawing.Size(94, 13);
            this.WordCountLabel.TabIndex = 0;
            this.WordCountLabel.Text = "Кількість слів:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(253, 77);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(255, 212);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // AverageSentenceLengthLabel
            // 
            this.AverageSentenceLengthLabel.AutoSize = true;
            this.AverageSentenceLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageSentenceLengthLabel.Location = new System.Drawing.Point(12, 102);
            this.AverageSentenceLengthLabel.Name = "AverageSentenceLengthLabel";
            this.AverageSentenceLengthLabel.Size = new System.Drawing.Size(168, 13);
            this.AverageSentenceLengthLabel.TabIndex = 2;
            this.AverageSentenceLengthLabel.Text = "Середня довжина речення:";
            // 
            // UniqueWordCountLabel
            // 
            this.UniqueWordCountLabel.AutoSize = true;
            this.UniqueWordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UniqueWordCountLabel.Location = new System.Drawing.Point(12, 132);
            this.UniqueWordCountLabel.Name = "UniqueWordCountLabel";
            this.UniqueWordCountLabel.Size = new System.Drawing.Size(106, 13);
            this.UniqueWordCountLabel.TabIndex = 3;
            this.UniqueWordCountLabel.Text = "Унікальних слів:";
            // 
            // ComplexWordCountLabel
            // 
            this.ComplexWordCountLabel.AutoSize = true;
            this.ComplexWordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComplexWordCountLabel.Location = new System.Drawing.Point(12, 161);
            this.ComplexWordCountLabel.Name = "ComplexWordCountLabel";
            this.ComplexWordCountLabel.Size = new System.Drawing.Size(95, 13);
            this.ComplexWordCountLabel.TabIndex = 4;
            this.ComplexWordCountLabel.Text = "Складних слів:";
            // 
            // AverageWordLengthLabel
            // 
            this.AverageWordLengthLabel.AutoSize = true;
            this.AverageWordLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageWordLengthLabel.Location = new System.Drawing.Point(12, 190);
            this.AverageWordLengthLabel.Name = "AverageWordLengthLabel";
            this.AverageWordLengthLabel.Size = new System.Drawing.Size(155, 13);
            this.AverageWordLengthLabel.TabIndex = 5;
            this.AverageWordLengthLabel.Text = "Середня довжина слова:";
            // 
            // WordFrequencyTextBox
            // 
            this.WordFrequencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordFrequencyTextBox.Location = new System.Drawing.Point(544, 76);
            this.WordFrequencyTextBox.Multiline = true;
            this.WordFrequencyTextBox.Name = "WordFrequencyTextBox";
            this.WordFrequencyTextBox.Size = new System.Drawing.Size(241, 212);
            this.WordFrequencyTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Імпорт тексту";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnalyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyzeButton.Location = new System.Drawing.Point(15, 225);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(195, 29);
            this.AnalyzeButton.TabIndex = 9;
            this.AnalyzeButton.Text = "Аналізувати";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SaveResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultsButton.Location = new System.Drawing.Point(600, 12);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(195, 34);
            this.SaveResultsButton.TabIndex = 10;
            this.SaveResultsButton.Text = "Зберегти в текстовий файл результат";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            this.SaveResultsButton.Click += new System.EventHandler(this.SaveResultsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Аналізатор різноманітності мови";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveResultsButton);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordFrequencyTextBox);
            this.Controls.Add(this.AverageWordLengthLabel);
            this.Controls.Add(this.ComplexWordCountLabel);
            this.Controls.Add(this.UniqueWordCountLabel);
            this.Controls.Add(this.AverageSentenceLengthLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.WordCountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Аналізатор різноманітності мови";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordCountLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label AverageSentenceLengthLabel;
        private System.Windows.Forms.Label UniqueWordCountLabel;
        private System.Windows.Forms.Label ComplexWordCountLabel;
        private System.Windows.Forms.Label AverageWordLengthLabel;
        private System.Windows.Forms.TextBox WordFrequencyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button SaveResultsButton;
        private System.Windows.Forms.Label label2;
    }
}

