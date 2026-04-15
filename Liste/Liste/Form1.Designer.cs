namespace Liste
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
            cmb_citta = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            txt_nuova = new TextBox();
            chk_nazionalita = new CheckBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // cmb_citta
            // 
            cmb_citta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_citta.FormattingEnabled = true;
            cmb_citta.Items.AddRange(new object[] { "Parma", "Como", "Milano", "Pavia", "Genova" });
            cmb_citta.Location = new Point(815, 58);
            cmb_citta.Name = "cmb_citta";
            cmb_citta.Size = new Size(370, 49);
            cmb_citta.TabIndex = 0;
            cmb_citta.SelectedIndexChanged += cmb_citta_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(815, 140);
            button1.Name = "button1";
            button1.Size = new Size(370, 90);
            button1.TabIndex = 1;
            button1.Text = "Numero di elementi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(815, 269);
            button2.Name = "button2";
            button2.Size = new Size(370, 107);
            button2.TabIndex = 2;
            button2.Text = "Valore della voce selezionata";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(815, 407);
            button3.Name = "button3";
            button3.Size = new Size(370, 107);
            button3.TabIndex = 3;
            button3.Text = "Indice della voce selezionata";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(815, 562);
            button4.Name = "button4";
            button4.Size = new Size(370, 107);
            button4.TabIndex = 4;
            button4.Text = "Aggiungi voce alla lista";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(407, 407);
            button5.Name = "button5";
            button5.Size = new Size(370, 107);
            button5.TabIndex = 5;
            button5.Text = "Selezione dell'indice desiderato";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(815, 706);
            label1.Name = "label1";
            label1.Size = new Size(335, 41);
            label1.TabIndex = 6;
            label1.Text = "Digita la città da inserire";
            // 
            // txt_nuova
            // 
            txt_nuova.Location = new Point(815, 767);
            txt_nuova.Name = "txt_nuova";
            txt_nuova.Size = new Size(370, 47);
            txt_nuova.TabIndex = 7;
            // 
            // chk_nazionalita
            // 
            chk_nazionalita.AutoSize = true;
            chk_nazionalita.Location = new Point(78, 94);
            chk_nazionalita.Name = "chk_nazionalita";
            chk_nazionalita.Size = new Size(150, 45);
            chk_nazionalita.TabIndex = 8;
            chk_nazionalita.Text = "Italiana";
            chk_nazionalita.UseVisualStyleBackColor = true;
            chk_nazionalita.CheckedChanged += chk_nazionalita_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(295, 103);
            button6.Name = "button6";
            button6.Size = new Size(335, 127);
            button6.TabIndex = 9;
            button6.Text = "Attivato/non attivato del checkbox";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(180, 625);
            button7.Name = "button7";
            button7.Size = new Size(488, 189);
            button7.TabIndex = 10;
            button7.Text = "Scorri oggetti nella form";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 880);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(chk_nazionalita);
            Controls.Add(txt_nuova);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmb_citta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_citta;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox txt_nuova;
        private CheckBox chk_nazionalita;
        private Button button6;
        private Button button7;
    }
}
