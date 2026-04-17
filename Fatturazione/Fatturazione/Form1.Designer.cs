namespace Fatturazione
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
            npm_numero = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            npm_importo = new NumericUpDown();
            txt_cliente = new TextBox();
            cmb_tipo = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            lbl_numero_fatture = new Label();
            button2 = new Button();
            label6 = new Label();
            nmp_Ricerca = new NumericUpDown();
            label7 = new Label();
            lbl_trovata = new Label();
            ((System.ComponentModel.ISupportInitialize)npm_numero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npm_importo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmp_Ricerca).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 0;
            label1.Text = "Numero fattura";
            // 
            // npm_numero
            // 
            npm_numero.Location = new Point(317, 38);
            npm_numero.Name = "npm_numero";
            npm_numero.Size = new Size(115, 47);
            npm_numero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 125);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 2;
            label2.Text = "Importo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 204);
            label3.Name = "label3";
            label3.Size = new Size(110, 41);
            label3.TabIndex = 3;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 286);
            label4.Name = "label4";
            label4.Size = new Size(205, 41);
            label4.TabIndex = 4;
            label4.Text = "Tipo prodotto";
            // 
            // npm_importo
            // 
            npm_importo.Location = new Point(317, 125);
            npm_importo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            npm_importo.Name = "npm_importo";
            npm_importo.Size = new Size(250, 47);
            npm_importo.TabIndex = 5;
            // 
            // txt_cliente
            // 
            txt_cliente.Location = new Point(317, 204);
            txt_cliente.Name = "txt_cliente";
            txt_cliente.Size = new Size(250, 47);
            txt_cliente.TabIndex = 6;
            // 
            // cmb_tipo
            // 
            cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.Items.AddRange(new object[] { "Alimentari", "Edilizia", "Informatica", "Lusso" });
            cmb_tipo.Location = new Point(317, 283);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(250, 49);
            cmb_tipo.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(65, 383);
            button1.Name = "button1";
            button1.Size = new Size(504, 75);
            button1.TabIndex = 8;
            button1.Text = "Inserisci fattura in archivio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 498);
            label5.Name = "label5";
            label5.Size = new Size(367, 41);
            label5.TabIndex = 9;
            label5.Text = "Fatture presenti in archivio";
            // 
            // lbl_numero_fatture
            // 
            lbl_numero_fatture.AutoSize = true;
            lbl_numero_fatture.Location = new Point(472, 498);
            lbl_numero_fatture.Name = "lbl_numero_fatture";
            lbl_numero_fatture.Size = new Size(97, 41);
            lbl_numero_fatture.TabIndex = 10;
            lbl_numero_fatture.Text = "label6";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(785, 142);
            button2.Name = "button2";
            button2.Size = new Size(457, 79);
            button2.TabIndex = 11;
            button2.Text = "Avvia ricerca";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(785, 61);
            label6.Name = "label6";
            label6.Size = new Size(277, 41);
            label6.TabIndex = 12;
            label6.Text = "Fattura da ricercare:";
            // 
            // nmp_Ricerca
            // 
            nmp_Ricerca.Location = new Point(1109, 70);
            nmp_Ricerca.Name = "nmp_Ricerca";
            nmp_Ricerca.Size = new Size(133, 47);
            nmp_Ricerca.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(785, 241);
            label7.Name = "label7";
            label7.Size = new Size(323, 41);
            label7.TabIndex = 14;
            label7.Text = "Dettagli fattura trovata:";
            // 
            // lbl_trovata
            // 
            lbl_trovata.AutoSize = true;
            lbl_trovata.ForeColor = Color.DarkGoldenrod;
            lbl_trovata.Location = new Point(785, 291);
            lbl_trovata.Name = "lbl_trovata";
            lbl_trovata.Size = new Size(323, 41);
            lbl_trovata.TabIndex = 15;
            lbl_trovata.Text = "Dettagli fattura trovata:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 765);
            Controls.Add(lbl_trovata);
            Controls.Add(label7);
            Controls.Add(nmp_Ricerca);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(lbl_numero_fatture);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cmb_tipo);
            Controls.Add(txt_cliente);
            Controls.Add(npm_importo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(npm_numero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)npm_numero).EndInit();
            ((System.ComponentModel.ISupportInitialize)npm_importo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmp_Ricerca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown npm_numero;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown npm_importo;
        private TextBox txt_cliente;
        private ComboBox cmb_tipo;
        private Button button1;
        private Label label5;
        private Label lbl_numero_fatture;
        private Button button2;
        private Label label6;
        private NumericUpDown nmp_Ricerca;
        private Label label7;
        private Label lbl_trovata;
    }
}
