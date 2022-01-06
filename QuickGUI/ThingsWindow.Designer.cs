
namespace QuickGUI
{
    partial class ThingsWindow
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
            this.triangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // triangle
            // 
            this.triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.triangle.BackgroundImage = global::QuickGUI.Properties.Resources.TriangleRuler;
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.Location = new System.Drawing.Point(13, 13);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(99, 93);
            this.triangle.TabIndex = 0;
            this.triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.triangle.UseVisualStyleBackColor = false;
            this.triangle.Click += new System.EventHandler(this.OpenTab);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Triangle";
            // 
            // ThingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.triangle);
            this.Name = "ThingsWindow";
            this.Text = "Things";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Label label1;
    }
}