namespace costrutti
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
            txt_citta = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 249);
            button1.Name = "button1";
            button1.Size = new Size(372, 87);
            button1.TabIndex = 0;
            button1.Text = "Costrutto if";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 93);
            label1.Name = "label1";
            label1.Size = new Size(372, 41);
            label1.TabIndex = 1;
            label1.Text = "Digita la tua città di nascita";
            // 
            // txt_citta
            // 
            txt_citta.Location = new Point(102, 171);
            txt_citta.Name = "txt_citta";
            txt_citta.Size = new Size(372, 47);
            txt_citta.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(txt_citta);
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
        private TextBox txt_citta;
    }
}
