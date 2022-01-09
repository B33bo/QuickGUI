
namespace QuickGUI
{
    partial class AddFunction
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
            this.FunctionList = new System.Windows.Forms.ListBox();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FunctionList
            // 
            this.FunctionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FunctionList.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.FunctionList.FormattingEnabled = true;
            this.FunctionList.ItemHeight = 31;
            this.FunctionList.Location = new System.Drawing.Point(12, 33);
            this.FunctionList.Name = "FunctionList";
            this.FunctionList.Size = new System.Drawing.Size(519, 314);
            this.FunctionList.TabIndex = 0;
            this.FunctionList.SelectedIndexChanged += new System.EventHandler(this.FunctionList_SelectedIndexChanged);
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ExplanationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.ExplanationLabel.Location = new System.Drawing.Point(12, 9);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(92, 21);
            this.ExplanationLabel.TabIndex = 1;
            this.ExplanationLabel.Text = "Explanation";
            this.ExplanationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Use";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UseFunction);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::QuickGUI.Properties.Resources.Plus;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(508, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddFunc);
            // 
            // AddFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(541, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.FunctionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFunction";
            this.Text = "AddMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FunctionList;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}