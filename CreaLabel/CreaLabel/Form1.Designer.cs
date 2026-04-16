namespace CreaLabel
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
            label1 = new Label();
            label2 = new Label();
            txt_Testo = new TextBox();
            nmp_numero = new NumericUpDown();
            btn_conferma = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmp_numero).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(842, 131);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(447, 41);
            label1.TabIndex = 0;
            label1.Text = "Numero di label da aggiungere: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(676, 236);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(603, 41);
            label2.TabIndex = 1;
            label2.Text = "Testo generale da inserire nelle nuove label: ";
            // 
            // txt_Testo
            // 
            txt_Testo.Location = new Point(1332, 221);
            txt_Testo.Margin = new Padding(6, 6, 6, 6);
            txt_Testo.Name = "txt_Testo";
            txt_Testo.Size = new Size(323, 47);
            txt_Testo.TabIndex = 2;
            // 
            // nmp_numero
            // 
            nmp_numero.Location = new Point(1332, 127);
            nmp_numero.Margin = new Padding(6, 6, 6, 6);
            nmp_numero.Name = "nmp_numero";
            nmp_numero.Size = new Size(319, 47);
            nmp_numero.TabIndex = 3;
            // 
            // btn_conferma
            // 
            btn_conferma.Location = new Point(1332, 355);
            btn_conferma.Margin = new Padding(6, 6, 6, 6);
            btn_conferma.Name = "btn_conferma";
            btn_conferma.Size = new Size(319, 154);
            btn_conferma.TabIndex = 4;
            btn_conferma.Text = "Conferma e porta a video le nuove label";
            btn_conferma.UseVisualStyleBackColor = true;
            btn_conferma.Click += btn_conferma_Click;
            // 
            // button1
            // 
            button1.Location = new Point(839, 445);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(842, 603);
            button2.Name = "button2";
            button2.Size = new Size(490, 131);
            button2.TabIndex = 6;
            button2.Text = "Controlla esistenza degli oggetti creati run-time";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 922);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_conferma);
            Controls.Add(nmp_numero);
            Controls.Add(txt_Testo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmp_numero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Testo;
        private NumericUpDown nmp_numero;
        private Button btn_conferma;
        private Button button1;
        private Button button2;
    }
}
