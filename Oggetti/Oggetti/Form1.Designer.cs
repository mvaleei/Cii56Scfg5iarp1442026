namespace Oggetti
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
            cmb_start = new ComboBox();
            button2 = new Button();
            cmb_end = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(762, 172);
            button1.Name = "button1";
            button1.Size = new Size(351, 96);
            button1.TabIndex = 0;
            button1.Text = "Gestione array";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmb_start
            // 
            cmb_start.FormattingEnabled = true;
            cmb_start.Items.AddRange(new object[] { "Nuoto", "Tennis", "Calcio", "Pallavolo" });
            cmb_start.Location = new Point(141, 330);
            cmb_start.Name = "cmb_start";
            cmb_start.Size = new Size(387, 49);
            cmb_start.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(603, 303);
            button2.Name = "button2";
            button2.Size = new Size(206, 100);
            button2.TabIndex = 2;
            button2.Text = "Copia valori";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmb_end
            // 
            cmb_end.FormattingEnabled = true;
            cmb_end.Location = new Point(885, 330);
            cmb_end.Name = "cmb_end";
            cmb_end.Size = new Size(302, 49);
            cmb_end.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(583, 483);
            button3.Name = "button3";
            button3.Size = new Size(458, 108);
            button3.TabIndex = 4;
            button3.Text = "Aggiungi oggetto in runtime";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(141, 474);
            button4.Name = "button4";
            button4.Size = new Size(387, 127);
            button4.TabIndex = 5;
            button4.Text = "Numero di oggetti grafici presenti nella form";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(141, 644);
            button5.Name = "button5";
            button5.Size = new Size(900, 102);
            button5.TabIndex = 6;
            button5.Text = "Controlla nomi oggetti grafici";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 795);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(cmb_end);
            Controls.Add(button2);
            Controls.Add(cmb_start);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox cmb_start;
        private Button button2;
        private ComboBox cmb_end;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
