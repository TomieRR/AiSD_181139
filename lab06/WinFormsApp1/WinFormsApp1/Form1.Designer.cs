namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttongeneruj = new System.Windows.Forms.Button();
            this.buttonSofrowanieWs = new System.Windows.Forms.Button();
            this.buttonSortowanieWyb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttongeneruj
            // 
            this.buttongeneruj.Location = new System.Drawing.Point(368, 79);
            this.buttongeneruj.Name = "buttongeneruj";
            this.buttongeneruj.Size = new System.Drawing.Size(133, 23);
            this.buttongeneruj.TabIndex = 2;
            this.buttongeneruj.Text = "Generuj";
            this.buttongeneruj.UseVisualStyleBackColor = true;
            this.buttongeneruj.Click += new System.EventHandler(this.buttongeneruj_Click);
            // 
            // buttonSofrowanieWs
            // 
            this.buttonSofrowanieWs.Location = new System.Drawing.Point(542, 126);
            this.buttonSofrowanieWs.Name = "buttonSofrowanieWs";
            this.buttonSofrowanieWs.Size = new System.Drawing.Size(144, 25);
            this.buttonSofrowanieWs.TabIndex = 3;
            this.buttonSofrowanieWs.Text = "SortujPrzezWstawianie";
            this.buttonSofrowanieWs.UseVisualStyleBackColor = true;
            this.buttonSofrowanieWs.Click += new System.EventHandler(this.buttonSofrowanieWs_Click);
            // 
            // buttonSortowanieWyb
            // 
            this.buttonSortowanieWyb.Location = new System.Drawing.Point(542, 236);
            this.buttonSortowanieWyb.Name = "buttonSortowanieWyb";
            this.buttonSortowanieWyb.Size = new System.Drawing.Size(144, 27);
            this.buttonSortowanieWyb.TabIndex = 4;
            this.buttonSortowanieWyb.Text = "SortujPrzezWybieranie";
            this.buttonSortowanieWyb.UseVisualStyleBackColor = true;
            this.buttonSortowanieWyb.Click += new System.EventHandler(this.buttonSortowanieWyb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSortowanieWyb);
            this.Controls.Add(this.buttonSofrowanieWs);
            this.Controls.Add(this.buttongeneruj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttongeneruj;
        private Button buttonSofrowanieWs;
        private Button buttonSortowanieWyb;
    }
}