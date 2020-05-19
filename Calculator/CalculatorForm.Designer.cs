namespace Calculator
{
    partial class CalculatorForm
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
            this.tblay_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Digit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tblay_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblay_Buttons
            // 
            this.tblay_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.tblay_Buttons.ColumnCount = 4;
            this.tblay_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblay_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblay_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblay_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblay_Buttons.Controls.Add(this.button2, 0, 6);
            this.tblay_Buttons.Controls.Add(this.lb_Digit, 0, 0);
            this.tblay_Buttons.Controls.Add(this.button1, 1, 0);
            this.tblay_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblay_Buttons.Location = new System.Drawing.Point(0, 0);
            this.tblay_Buttons.Margin = new System.Windows.Forms.Padding(30);
            this.tblay_Buttons.MinimumSize = new System.Drawing.Size(0, 100);
            this.tblay_Buttons.Name = "tblay_Buttons";
            this.tblay_Buttons.RowCount = 7;
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblay_Buttons.Size = new System.Drawing.Size(800, 450);
            this.tblay_Buttons.TabIndex = 0;
            // 
            // lb_Digit
            // 
            this.lb_Digit.AutoSize = true;
            this.lb_Digit.BackColor = System.Drawing.Color.White;
            this.lb_Digit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblay_Buttons.SetColumnSpan(this.lb_Digit, 4);
            this.lb_Digit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Digit.Location = new System.Drawing.Point(3, 0);
            this.lb_Digit.Name = "lb_Digit";
            this.lb_Digit.Size = new System.Drawing.Size(794, 64);
            this.lb_Digit.TabIndex = 0;
            this.lb_Digit.Text = "label1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(303, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(300, 300);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblay_Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.tblay_Buttons.ResumeLayout(false);
            this.tblay_Buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblay_Buttons;
        private System.Windows.Forms.Label lb_Digit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

