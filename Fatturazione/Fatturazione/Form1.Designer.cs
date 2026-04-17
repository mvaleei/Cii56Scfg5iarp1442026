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
            ((System.ComponentModel.ISupportInitialize)npm_numero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npm_importo).BeginInit();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 765);
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
    }
}
