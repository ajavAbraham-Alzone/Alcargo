namespace CopilotWindowApp
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
            ClickHere = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // ClickHere
            // 
            ClickHere.Location = new Point(256, 192);
            ClickHere.Name = "ClickHere";
            ClickHere.Size = new Size(75, 23);
            ClickHere.TabIndex = 1;
            ClickHere.Text = "Click Here";
            ClickHere.UseVisualStyleBackColor = true;
            ClickHere.Click += ClickHere_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 104);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Type Here";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 23);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(ClickHere);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ClickHere;
        private Label label1;
        private TextBox textBox2;
    }
}
