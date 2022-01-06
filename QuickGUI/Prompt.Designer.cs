
namespace QuickGUI
{
    partial class Prompt
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
            this.newVar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newVar
            // 
            this.newVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.newVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newVar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newVar.Location = new System.Drawing.Point(12, 12);
            this.newVar.Name = "newVar";
            this.newVar.Size = new System.Drawing.Size(410, 27);
            this.newVar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(262, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Close);
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(434, 83);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newVar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox newVar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}