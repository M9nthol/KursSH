namespace Numb
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 298);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 0;
            button1.Text = "Назначенные встречи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 232);
            button2.Name = "button2";
            button2.Size = new Size(149, 36);
            button2.TabIndex = 1;
            button2.Text = "Добавить встречу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(316, 369);
            button3.Name = "button3";
            button3.Size = new Size(149, 36);
            button3.TabIndex = 2;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(295, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 3;
            label1.Text = "Встречи сегодня";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(295, 108);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(295, 67);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(295, 152);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
