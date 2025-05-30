namespace Calc_Trigo
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
            this.btnSin = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCoTan = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Button();
            this.DelAll = new System.Windows.Forms.Button();
            this.znak = new System.Windows.Forms.Button();
            this.Step2 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.Step3 = new System.Windows.Forms.Button();
            this.StepX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(112, 164);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(47, 23);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(112, 94);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(284, 44);
            this.Display.TabIndex = 1;
            this.Display.Text = "Введите значение.";
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(187, 164);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(44, 23);
            this.btnCos.TabIndex = 2;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(186, 203);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(45, 23);
            this.btnTan.TabIndex = 3;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCoTan
            // 
            this.btnCoTan.Location = new System.Drawing.Point(112, 201);
            this.btnCoTan.Name = "btnCoTan";
            this.btnCoTan.Size = new System.Drawing.Size(45, 23);
            this.btnCoTan.TabIndex = 4;
            this.btnCoTan.Text = "ctn";
            this.btnCoTan.UseVisualStyleBackColor = true;
            this.btnCoTan.Click += new System.EventHandler(this.btnCoTan_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(36, 165);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(47, 20);
            this.Plus.TabIndex = 5;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(36, 201);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 25);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(36, 245);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(47, 23);
            this.Mult.TabIndex = 7;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(36, 289);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(47, 23);
            this.Div.TabIndex = 8;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(36, 330);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(47, 22);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "=";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // DelAll
            // 
            this.DelAll.Location = new System.Drawing.Point(267, 184);
            this.DelAll.Name = "DelAll";
            this.DelAll.Size = new System.Drawing.Size(22, 23);
            this.DelAll.TabIndex = 11;
            this.DelAll.Text = "C";
            this.DelAll.UseVisualStyleBackColor = true;
            this.DelAll.Click += new System.EventHandler(this.DelAll_Click);
            // 
            // znak
            // 
            this.znak.Location = new System.Drawing.Point(48, 102);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(47, 21);
            this.znak.TabIndex = 12;
            this.znak.Text = "Sign";
            this.znak.UseVisualStyleBackColor = true;
            this.znak.Click += new System.EventHandler(this.znak_Click);
            // 
            // Step2
            // 
            this.Step2.Location = new System.Drawing.Point(112, 243);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(45, 25);
            this.Step2.TabIndex = 13;
            this.Step2.Text = "^2";
            this.Step2.UseVisualStyleBackColor = true;
            this.Step2.Click += new System.EventHandler(this.Step2_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(98, 27);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Step3
            // 
            this.Step3.Location = new System.Drawing.Point(187, 244);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(44, 24);
            this.Step3.TabIndex = 15;
            this.Step3.Text = "^3";
            this.Step3.UseVisualStyleBackColor = true;
            this.Step3.Click += new System.EventHandler(this.Step3_Click);
            // 
            // StepX
            // 
            this.StepX.Location = new System.Drawing.Point(255, 245);
            this.StepX.Name = "StepX";
            this.StepX.Size = new System.Drawing.Size(45, 23);
            this.StepX.TabIndex = 16;
            this.StepX.Text = "^X";
            this.StepX.UseVisualStyleBackColor = true;
            this.StepX.Click += new System.EventHandler(this.StepX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 390);
            this.Controls.Add(this.StepX);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.DelAll);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.btnCoTan);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.btnSin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCoTan;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Button DelAll;
        private System.Windows.Forms.Button znak;
        private System.Windows.Forms.Button Step2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button Step3;
        private System.Windows.Forms.Button StepX;
    }
}

