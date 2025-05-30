namespace WinFormsApp_SaveLoadFragments
{
    partial class form_Main
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
            this.radioButton_SaveAs = new System.Windows.Forms.RadioButton();
            this.radioButton_Load = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_SaveAs
            // 
            this.radioButton_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_SaveAs.AutoSize = true;
            this.radioButton_SaveAs.Location = new System.Drawing.Point(45, 312);
            this.radioButton_SaveAs.Name = "radioButton_SaveAs";
            this.radioButton_SaveAs.Size = new System.Drawing.Size(152, 17);
            this.radioButton_SaveAs.TabIndex = 0;
            this.radioButton_SaveAs.TabStop = true;
            this.radioButton_SaveAs.Text = "Сохранить фрагмент как";
            this.radioButton_SaveAs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Load
            // 
            this.radioButton_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Load.AutoSize = true;
            this.radioButton_Load.Location = new System.Drawing.Point(329, 312);
            this.radioButton_Load.Name = "radioButton_Load";
            this.radioButton_Load.Size = new System.Drawing.Size(130, 17);
            this.radioButton_Load.TabIndex = 1;
            this.radioButton_Load.TabStop = true;
            this.radioButton_Load.Text = "Загрузить фрагмент";
            this.radioButton_Load.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.MinimumSize = new System.Drawing.Size(480, 280);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 280);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(498, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 341);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.radioButton_Load);
            this.Controls.Add(this.radioButton_SaveAs);
            this.Controls.Add(this.pictureBox);
            this.Name = "form_Main";
            this.Text = "Сохранение и загрузка фрагментов изображений";
            this.Resize += new System.EventHandler(this.form_Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_SaveAs;
        private System.Windows.Forms.RadioButton radioButton_Load;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Close;
    }
}

