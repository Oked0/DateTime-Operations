namespace DateTimeOperations
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
            Разн = new Label();
            dtpDate1 = new DateTimePicker();
            dtpDate2 = new DateTimePicker();
            btnDateDiff = new Button();
            lblDateDiffResult = new Label();
            label1 = new Label();
            dtpYear = new DateTimePicker();
            btnIsLeap = new Button();
            lblIsLeapResult = new Label();
            label2 = new Label();
            dtpTime = new DateTimePicker();
            btnTimeOfDay = new Button();
            lblTimeOfDayResult = new Label();
            label3 = new Label();
            dtpFormat = new DateTimePicker();
            cmbFormat = new ComboBox();
            btnFormat = new Button();
            lblFormatResult = new Label();
            SuspendLayout();
            // 
            // Разн
            // 
            Разн.AutoSize = true;
            Разн.Location = new Point(67, 30);
            Разн.Name = "Разн";
            Разн.Size = new Size(133, 15);
            Разн.TabIndex = 0;
            Разн.Text = "Разница между датами";
            // 
            // dtpDate1
            // 
            dtpDate1.Format = DateTimePickerFormat.Short;
            dtpDate1.Location = new Point(38, 63);
            dtpDate1.Name = "dtpDate1";
            dtpDate1.Size = new Size(200, 23);
            dtpDate1.TabIndex = 1;
            // 
            // dtpDate2
            // 
            dtpDate2.Format = DateTimePickerFormat.Short;
            dtpDate2.Location = new Point(38, 107);
            dtpDate2.Name = "dtpDate2";
            dtpDate2.Size = new Size(200, 23);
            dtpDate2.TabIndex = 2;
            // 
            // btnDateDiff
            // 
            btnDateDiff.Location = new Point(57, 156);
            btnDateDiff.Name = "btnDateDiff";
            btnDateDiff.Size = new Size(156, 61);
            btnDateDiff.TabIndex = 3;
            btnDateDiff.Text = "Вычислить разницу";
            btnDateDiff.UseVisualStyleBackColor = true;
            btnDateDiff.Click += btnDateDiff_Click;
            // 
            // lblDateDiffResult
            // 
            lblDateDiffResult.AutoSize = true;
            lblDateDiffResult.Location = new Point(115, 239);
            lblDateDiffResult.Name = "lblDateDiffResult";
            lblDateDiffResult.Size = new Size(0, 15);
            lblDateDiffResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 30);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 5;
            label1.Text = " Проверка високосного года";
            // 
            // dtpYear
            // 
            dtpYear.CustomFormat = "yyyy";
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.Location = new Point(385, 72);
            dtpYear.Name = "dtpYear";
            dtpYear.Size = new Size(200, 23);
            dtpYear.TabIndex = 6;
            // 
            // btnIsLeap
            // 
            btnIsLeap.Location = new Point(402, 107);
            btnIsLeap.Name = "btnIsLeap";
            btnIsLeap.Size = new Size(138, 49);
            btnIsLeap.TabIndex = 7;
            btnIsLeap.Text = "Проверить";
            btnIsLeap.UseVisualStyleBackColor = true;
            btnIsLeap.Click += btnIsLeap_Click;
            // 
            // lblIsLeapResult
            // 
            lblIsLeapResult.AutoSize = true;
            lblIsLeapResult.Location = new Point(449, 169);
            lblIsLeapResult.Name = "lblIsLeapResult";
            lblIsLeapResult.Size = new Size(0, 15);
            lblIsLeapResult.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(743, 30);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 9;
            label2.Text = "Определение времени суток";
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(736, 63);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(200, 23);
            dtpTime.TabIndex = 10;
            // 
            // btnTimeOfDay
            // 
            btnTimeOfDay.Location = new Point(784, 109);
            btnTimeOfDay.Name = "btnTimeOfDay";
            btnTimeOfDay.Size = new Size(107, 47);
            btnTimeOfDay.TabIndex = 11;
            btnTimeOfDay.Text = "Определить время суток";
            btnTimeOfDay.UseVisualStyleBackColor = true;
            btnTimeOfDay.Click += btnTimeOfDay_Click;
            // 
            // lblTimeOfDayResult
            // 
            lblTimeOfDayResult.AutoSize = true;
            lblTimeOfDayResult.Location = new Point(818, 179);
            lblTimeOfDayResult.Name = "lblTimeOfDayResult";
            lblTimeOfDayResult.Size = new Size(0, 15);
            lblTimeOfDayResult.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 304);
            label3.Name = "label3";
            label3.Size = new Size(193, 15);
            label3.TabIndex = 13;
            label3.Text = "Форматирование даты и времени";
            // 
            // dtpFormat
            // 
            dtpFormat.Location = new Point(385, 340);
            dtpFormat.Name = "dtpFormat";
            dtpFormat.Size = new Size(200, 23);
            dtpFormat.TabIndex = 14;
            // 
            // cmbFormat
            // 
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Location = new Point(385, 379);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(121, 23);
            cmbFormat.TabIndex = 15;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(385, 421);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(161, 42);
            btnFormat.TabIndex = 16;
            btnFormat.Text = "Форматировать";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // lblFormatResult
            // 
            lblFormatResult.AutoSize = true;
            lblFormatResult.Location = new Point(434, 478);
            lblFormatResult.Name = "lblFormatResult";
            lblFormatResult.Size = new Size(0, 15);
            lblFormatResult.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 525);
            Controls.Add(lblFormatResult);
            Controls.Add(btnFormat);
            Controls.Add(cmbFormat);
            Controls.Add(dtpFormat);
            Controls.Add(label3);
            Controls.Add(lblTimeOfDayResult);
            Controls.Add(btnTimeOfDay);
            Controls.Add(dtpTime);
            Controls.Add(label2);
            Controls.Add(lblIsLeapResult);
            Controls.Add(btnIsLeap);
            Controls.Add(dtpYear);
            Controls.Add(label1);
            Controls.Add(lblDateDiffResult);
            Controls.Add(btnDateDiff);
            Controls.Add(dtpDate2);
            Controls.Add(dtpDate1);
            Controls.Add(Разн);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Разн;
        private DateTimePicker dtpDate1;
        private DateTimePicker dtpDate2;
        private Button btnDateDiff;
        private Label lblDateDiffResult;
        private Label label1;
        private DateTimePicker dtpYear;
        private Button btnIsLeap;
        private Label lblIsLeapResult;
        private Label label2;
        private DateTimePicker dtpTime;
        private Button btnTimeOfDay;
        private Label lblTimeOfDayResult;
        private Label label3;
        private DateTimePicker dtpFormat;
        private ComboBox cmbFormat;
        private Button btnFormat;
        private Label lblFormatResult;
    }
}
