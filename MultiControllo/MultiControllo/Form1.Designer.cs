namespace MultiControllo
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
            label1 = new Label();
            txt_sport = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(631, 120);
            button1.Name = "button1";
            button1.Size = new Size(389, 58);
            button1.TabIndex = 0;
            button1.Text = "Switch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 268);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 1;
            label1.Text = "Digita lo sport che preferisci";
            // 
            // txt_sport
            // 
            txt_sport.Location = new Point(631, 360);
            txt_sport.Name = "txt_sport";
            txt_sport.Size = new Size(250, 47);
            txt_sport.TabIndex = 2;
            txt_sport.Text = "Finito";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 725);
            Controls.Add(txt_sport);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txt_sport;
    }
}
