namespace BreakfastList
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "Eine Scheibe Brot",
            "Einen Apfel",
            "Rührei mit Speck",
            "Eine Tasse Tee",
            "Ein Gipfeli"});
            this.combo.Location = new System.Drawing.Point(26, 128);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(328, 28);
            this.combo.TabIndex = 0;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(414, 128);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(122, 50);
            this.right.TabIndex = 1;
            this.right.Text = ">>";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(414, 208);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(122, 50);
            this.left.TabIndex = 2;
            this.left.Text = "<<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(598, 128);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(280, 164);
            this.list.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.list);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.combo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.ListBox list;
    }
}

