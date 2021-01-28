namespace Aufgabe_1._2
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
            this.add = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list1 = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(582, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(179, 29);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(219, 66);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(337, 26);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neuer Eintrag";
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 20;
            this.list1.Location = new System.Drawing.Point(37, 153);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(723, 204);
            this.list1.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(37, 399);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(157, 31);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(582, 399);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(178, 31);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
    }
}

