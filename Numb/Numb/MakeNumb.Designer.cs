namespace Numb
{
    partial class MakeNumb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(226, 102);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(132, 143);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 2;
            label2.Text = "Номер телефона";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(161, 186);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 4;
            label3.Text = "Дата встречи";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(278, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(147, 229);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 6;
            label4.Text = "Место встречи";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(278, 274);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(121, 272);
            label5.Name = "label5";
            label5.Size = new Size(151, 21);
            label5.TabIndex = 8;
            label5.Text = "Описание встречи";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(434, 319);
            button1.Name = "button1";
            button1.Size = new Size(158, 39);
            button1.TabIndex = 10;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(191, 319);
            button2.Name = "button2";
            button2.Size = new Size(158, 39);
            button2.TabIndex = 11;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(278, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // MakeNumb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MakeNumb";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
    }
}