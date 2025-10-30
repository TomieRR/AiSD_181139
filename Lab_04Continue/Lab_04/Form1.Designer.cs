namespace Lab_04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDodajPo = new Button();
            buttonDodajPrzed = new Button();
            textBoxLiczba = new TextBox();
            labelWynik = new Label();
            SuspendLayout();
            // 
            // buttonDodajPo
            // 
            buttonDodajPo.Location = new Point(180, 327);
            buttonDodajPo.Name = "buttonDodajPo";
            buttonDodajPo.Size = new Size(202, 47);
            buttonDodajPo.TabIndex = 0;
            buttonDodajPo.Text = "Dodaj Po";
            buttonDodajPo.UseVisualStyleBackColor = true;
            buttonDodajPo.Click += buttonDodajPo_Click;
            // 
            // buttonDodajPrzed
            // 
            buttonDodajPrzed.Location = new Point(401, 327);
            buttonDodajPrzed.Name = "buttonDodajPrzed";
            buttonDodajPrzed.Size = new Size(213, 47);
            buttonDodajPrzed.TabIndex = 1;
            buttonDodajPrzed.Text = "Dodaj Przed";
            buttonDodajPrzed.UseVisualStyleBackColor = true;
            // 
            // textBoxLiczba
            // 
            textBoxLiczba.Location = new Point(180, 49);
            textBoxLiczba.Name = "textBoxLiczba";
            textBoxLiczba.Size = new Size(434, 23);
            textBoxLiczba.TabIndex = 2;
            textBoxLiczba.Text = "1";
            // 
            // labelWynik
            // 
            labelWynik.AutoSize = true;
            labelWynik.Location = new Point(24, 192);
            labelWynik.Name = "labelWynik";
            labelWynik.Size = new Size(40, 15);
            labelWynik.TabIndex = 3;
            labelWynik.Text = "Wynik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWynik);
            Controls.Add(textBoxLiczba);
            Controls.Add(buttonDodajPrzed);
            Controls.Add(buttonDodajPo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodajPo;
        private Button buttonDodajPrzed;
        private TextBox textBoxLiczba;
        private Label labelWynik;
    }
}