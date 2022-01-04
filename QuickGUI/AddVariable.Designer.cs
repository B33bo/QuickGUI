
namespace QuickGUI
{
    partial class AddVariable
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
            this.VariableContainer = new System.Windows.Forms.ListBox();
            this.Use = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VariableContainer
            // 
            this.VariableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.VariableContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VariableContainer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VariableContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.VariableContainer.FormattingEnabled = true;
            this.VariableContainer.ItemHeight = 28;
            this.VariableContainer.Location = new System.Drawing.Point(9, 12);
            this.VariableContainer.Name = "VariableContainer";
            this.VariableContainer.Size = new System.Drawing.Size(400, 340);
            this.VariableContainer.TabIndex = 0;
            // 
            // Use
            // 
            this.Use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.Use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Use.Location = new System.Drawing.Point(9, 358);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(317, 23);
            this.Use.TabIndex = 1;
            this.Use.Text = "Use";
            this.Use.UseVisualStyleBackColor = false;
            this.Use.Click += new System.EventHandler(this.UseVariable);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuickGUI.Properties.Resources.Doodler;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(332, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EditVar);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::QuickGUI.Properties.Resources.Close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(360, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveVar);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::QuickGUI.Properties.Resources.Plus;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(386, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddVar);
            // 
            // AddVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(414, 386);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.VariableContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddVariable";
            this.Text = "AddVariable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox VariableContainer;
        private System.Windows.Forms.Button Use;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}