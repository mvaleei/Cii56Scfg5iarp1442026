namespace classi
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            lbl_numero = new Label();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 61);
            button1.Name = "button1";
            button1.Size = new Size(383, 190);
            button1.TabIndex = 0;
            button1.Text = "Gestione oggetti custom, derivanti da classi personalizzate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(813, 111);
            button2.Name = "button2";
            button2.Size = new Size(348, 170);
            button2.TabIndex = 1;
            button2.Text = "Chiamare metodo scrivere (OVERLOADING)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(381, 384);
            button3.Name = "button3";
            button3.Size = new Size(314, 128);
            button3.TabIndex = 2;
            button3.Text = "Crea pennarello con il SOLO colore";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(813, 384);
            button4.Name = "button4";
            button4.Size = new Size(348, 128);
            button4.TabIndex = 3;
            button4.Text = "Crea pennarello con la SOLA dimensione";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1316, 130);
            button5.Name = "button5";
            button5.Size = new Size(342, 95);
            button5.TabIndex = 4;
            button5.Text = "Hiding information";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1328, 410);
            button6.Name = "button6";
            button6.Size = new Size(330, 118);
            button6.TabIndex = 5;
            button6.Text = "Gestione multi oggetti";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1328, 589);
            label1.Name = "label1";
            label1.Size = new Size(454, 41);
            label1.TabIndex = 6;
            label1.Text = "Numero di elementi nell'arraylist:";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(1822, 590);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(97, 41);
            lbl_numero.TabIndex = 7;
            lbl_numero.Text = "label2";
            // 
            // button7
            // 
            button7.Location = new Point(1752, 236);
            button7.Name = "button7";
            button7.Size = new Size(351, 149);
            button7.TabIndex = 8;
            button7.Text = "Lettura dati di arraylist globale";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(813, 638);
            button8.Name = "button8";
            button8.Size = new Size(348, 140);
            button8.TabIndex = 9;
            button8.Text = "Valore/Riferimento";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2155, 823);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(lbl_numero);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label lbl_numero;
        private Button button7;
        private Button button8;
    }
}
