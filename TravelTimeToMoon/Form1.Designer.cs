namespace ReisedauerMond
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.inhours = new System.Windows.Forms.RadioButton();
            this.indays = new System.Windows.Forms.RadioButton();
            this.calcbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcbutton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.input);
            this.groupBox1.Controls.Add(this.inhours);
            this.groupBox1.Controls.Add(this.indays);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reisedauer zum Mond berechnen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geschwindigkeit in km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(199, 119);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(95, 26);
            this.input.TabIndex = 2;
            // 
            // inhours
            // 
            this.inhours.AutoSize = true;
            this.inhours.Location = new System.Drawing.Point(184, 42);
            this.inhours.Name = "inhours";
            this.inhours.Size = new System.Drawing.Size(111, 24);
            this.inhours.TabIndex = 1;
            this.inhours.TabStop = true;
            this.inhours.Text = "in Stunden";
            this.inhours.UseVisualStyleBackColor = true;
            // 
            // indays
            // 
            this.indays.AutoSize = true;
            this.indays.Location = new System.Drawing.Point(18, 42);
            this.indays.Name = "indays";
            this.indays.Size = new System.Drawing.Size(95, 24);
            this.indays.TabIndex = 0;
            this.indays.TabStop = true;
            this.indays.Text = "in Tagen";
            this.indays.UseVisualStyleBackColor = true;
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(18, 175);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(275, 51);
            this.calcbutton.TabIndex = 5;
            this.calcbutton.Text = "Reisedauer berechnen";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reisedauer";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(123, 287);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(182, 26);
            this.output.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 346);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RadioButton inhours;
        private System.Windows.Forms.RadioButton indays;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output;
    }
}

