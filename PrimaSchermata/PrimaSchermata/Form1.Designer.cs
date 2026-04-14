namespace PrimaSchermata
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
            btn_bottone1 = new Button();
            button2 = new Button();
            txt_nome = new TextBox();
            label1 = new Label();
            button1 = new Button();
            nmp_anno = new NumericUpDown();
            label2 = new Label();
            btn_anno = new Button();
            ((System.ComponentModel.ISupportInitialize)nmp_anno).BeginInit();
            SuspendLayout();
            // 
            // btn_bottone1
            // 
            btn_bottone1.Location = new Point(478, 109);
            btn_bottone1.Name = "btn_bottone1";
            btn_bottone1.Size = new Size(295, 80);
            btn_bottone1.TabIndex = 0;
            btn_bottone1.Text = "Pulsante mio";
            btn_bottone1.UseVisualStyleBackColor = true;
            btn_bottone1.Click += btn_bottone1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(839, 109);
            button2.Name = "button2";
            button2.Size = new Size(323, 80);
            button2.TabIndex = 1;
            button2.Text = "Secondo pulsante";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(478, 308);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(250, 47);
            txt_nome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 249);
            label1.Name = "label1";
            label1.Size = new Size(283, 41);
            label1.TabIndex = 3;
            label1.Text = "Inserisci il tuo nome";
            // 
            // button1
            // 
            button1.Location = new Point(801, 302);
            button1.Name = "button1";
            button1.Size = new Size(343, 58);
            button1.TabIndex = 4;
            button1.Text = "Leggi nome digitato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nmp_anno
            // 
            nmp_anno.Location = new Point(472, 482);
            nmp_anno.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nmp_anno.Name = "nmp_anno";
            nmp_anno.Size = new Size(300, 47);
            nmp_anno.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 413);
            label2.Name = "label2";
            label2.Size = new Size(201, 41);
            label2.TabIndex = 6;
            label2.Text = "Anno odierno";
            // 
            // btn_anno
            // 
            btn_anno.Location = new Point(816, 475);
            btn_anno.Name = "btn_anno";
            btn_anno.Size = new Size(433, 58);
            btn_anno.TabIndex = 7;
            btn_anno.Text = "Visualizza anno digitato";
            btn_anno.UseVisualStyleBackColor = true;
            btn_anno.Click += btn_anno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1760, 867);
            Controls.Add(btn_anno);
            Controls.Add(label2);
            Controls.Add(nmp_anno);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt_nome);
            Controls.Add(button2);
            Controls.Add(btn_bottone1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schermata di prova";
            ((System.ComponentModel.ISupportInitialize)nmp_anno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_bottone1;
        private Button button2;
        private TextBox txt_nome;
        private Label label1;
        private Button button1;
        private NumericUpDown nmp_anno;
        private Label label2;
        private Button btn_anno;
    }
}
