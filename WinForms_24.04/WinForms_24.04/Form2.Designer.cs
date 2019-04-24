namespace WinForms_24._04
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtmena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbStrana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbZena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(29, 222);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOtmena
            // 
            this.btnOtmena.Location = new System.Drawing.Point(181, 221);
            this.btnOtmena.Name = "btnOtmena";
            this.btnOtmena.Size = new System.Drawing.Size(75, 23);
            this.btnOtmena.TabIndex = 1;
            this.btnOtmena.Text = "Отмена";
            this.btnOtmena.UseVisualStyleBackColor = true;
            this.btnOtmena.Click += new System.EventHandler(this.btnOtmena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(32, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(224, 20);
            this.txbName.TabIndex = 3;
            // 
            // txbStrana
            // 
            this.txbStrana.Location = new System.Drawing.Point(32, 87);
            this.txbStrana.Name = "txbStrana";
            this.txbStrana.Size = new System.Drawing.Size(224, 20);
            this.txbStrana.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Страна производитель";
            // 
            // txbZena
            // 
            this.txbZena.Location = new System.Drawing.Point(32, 148);
            this.txbZena.Name = "txbZena";
            this.txbZena.Size = new System.Drawing.Size(224, 20);
            this.txbZena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbZena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbStrana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtmena);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtmena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbStrana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbZena;
        private System.Windows.Forms.Label label3;
    }
}