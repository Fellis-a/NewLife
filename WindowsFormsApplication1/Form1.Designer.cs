namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlusV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRes = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultS = new System.Windows.Forms.Button();
            this.btnMultV = new System.Windows.Forms.Button();
            this.btnLeng = new System.Windows.Forms.Button();
            this.Z1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Z2 = new System.Windows.Forms.TextBox();
            this.lbZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y1:";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(43, 10);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(64, 20);
            this.X1.TabIndex = 2;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(44, 41);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(62, 20);
            this.Y1.TabIndex = 3;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(164, 41);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(62, 20);
            this.Y2.TabIndex = 7;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(163, 10);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(64, 20);
            this.X2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "x2:";
            // 
            // btnPlusV
            // 
            this.btnPlusV.Location = new System.Drawing.Point(44, 185);
            this.btnPlusV.Name = "btnPlusV";
            this.btnPlusV.Size = new System.Drawing.Size(204, 24);
            this.btnPlusV.TabIndex = 8;
            this.btnPlusV.Text = "Сложить вектора";
            this.btnPlusV.UseVisualStyleBackColor = true;
            this.btnPlusV.Click += new System.EventHandler(this.btnPlusV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(71, 104);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(35, 13);
            this.lbRes.TabIndex = 11;
            this.lbRes.Text = "label6";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(212, 104);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(35, 13);
            this.lbX.TabIndex = 12;
            this.lbX.Text = "label6";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(212, 130);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(35, 13);
            this.lbY.TabIndex = 13;
            this.lbY.Text = "label7";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(43, 215);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(205, 22);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "Вычесть вектора";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultS
            // 
            this.btnMultS.Location = new System.Drawing.Point(45, 243);
            this.btnMultS.Name = "btnMultS";
            this.btnMultS.Size = new System.Drawing.Size(203, 22);
            this.btnMultS.TabIndex = 15;
            this.btnMultS.Text = "Скалярное произведение";
            this.btnMultS.UseVisualStyleBackColor = true;
            this.btnMultS.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMultV
            // 
            this.btnMultV.Location = new System.Drawing.Point(45, 271);
            this.btnMultV.Name = "btnMultV";
            this.btnMultV.Size = new System.Drawing.Size(202, 21);
            this.btnMultV.TabIndex = 16;
            this.btnMultV.Text = "Векторное произведение";
            this.btnMultV.UseVisualStyleBackColor = true;
            this.btnMultV.Click += new System.EventHandler(this.btnMuldR_Click);
            // 
            // btnLeng
            // 
            this.btnLeng.Location = new System.Drawing.Point(45, 298);
            this.btnLeng.Name = "btnLeng";
            this.btnLeng.Size = new System.Drawing.Size(202, 23);
            this.btnLeng.TabIndex = 17;
            this.btnLeng.Text = "Длина вектора";
            this.btnLeng.UseVisualStyleBackColor = true;
            this.btnLeng.Click += new System.EventHandler(this.btnLeng_Click);
            // 
            // Z1
            // 
            this.Z1.Location = new System.Drawing.Point(43, 69);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(64, 20);
            this.Z1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "z1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "z2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Z2
            // 
            this.Z2.Location = new System.Drawing.Point(164, 68);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(63, 20);
            this.Z2.TabIndex = 21;
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Location = new System.Drawing.Point(212, 153);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(35, 13);
            this.lbZ.TabIndex = 22;
            this.lbZ.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 333);
            this.Controls.Add(this.lbZ);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Z1);
            this.Controls.Add(this.btnLeng);
            this.Controls.Add(this.btnMultV);
            this.Controls.Add(this.btnMultS);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPlusV);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlusV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultS;
        private System.Windows.Forms.Button btnMultV;
        private System.Windows.Forms.Button btnLeng;
        private System.Windows.Forms.TextBox Z1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Z2;
        private System.Windows.Forms.Label lbZ;
    }
}

