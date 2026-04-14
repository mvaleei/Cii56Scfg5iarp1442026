namespace eta
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
            txt_nome = new TextBox();
            label2 = new Label();
            nmp_anno = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmp_anno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 41);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(373, 52);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(325, 47);
            txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 142);
            label2.Name = "label2";
            label2.Size = new Size(221, 41);
            label2.TabIndex = 2;
            label2.Text = "Anno di nascita";
            // 
            // nmp_anno
            // 
            nmp_anno.Location = new Point(373, 140);
            nmp_anno.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmp_anno.Name = "nmp_anno";
            nmp_anno.Size = new Size(325, 47);
            nmp_anno.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(109, 236);
            button1.Name = "button1";
            button1.Size = new Size(589, 128);
            button1.TabIndex = 4;
            button1.Text = "Visualizza dati anagrafici";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 468);
            Controls.Add(button1);
            Controls.Add(nmp_anno);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmp_anno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nome;
        private Label label2;
        private NumericUpDown nmp_anno;
        private Button button1;
    }
}
