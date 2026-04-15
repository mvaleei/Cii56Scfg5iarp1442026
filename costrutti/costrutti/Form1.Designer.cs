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
            label2 = new Label();
            nmp_anni = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmp_anni).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 104);
            label2.Name = "label2";
            label2.Size = new Size(262, 41);
            label2.TabIndex = 3;
            label2.Text = "Inserisci i tuoi anni";
            // 
            // nmp_anni
            // 
            nmp_anni.Location = new Point(700, 172);
            nmp_anni.Name = "nmp_anni";
            nmp_anni.Size = new Size(304, 47);
            nmp_anni.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(700, 249);
            button2.Name = "button2";
            button2.Size = new Size(304, 104);
            button2.TabIndex = 5;
            button2.Text = "Controlla anni - AND/OR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(button2);
            Controls.Add(nmp_anni);
            Controls.Add(label2);
            Controls.Add(txt_citta);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmp_anni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txt_citta;
        private Label label2;
        private NumericUpDown nmp_anni;
        private Button button2;
    }
}
