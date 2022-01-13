
namespace QuickGUI
{
    partial class Conversions
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
            this.ConversionTypeBox = new System.Windows.Forms.ComboBox();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.answerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConversionTypeBox
            // 
            this.ConversionTypeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConversionTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConversionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConversionTypeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConversionTypeBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.ConversionTypeBox.Items.AddRange(new object[] {
            "Angle",
            "Distance",
            "Energy",
            "Metric Units",
            "Number",
            "DataStorage",
            "Temperature",
            "Time"});
            this.ConversionTypeBox.Location = new System.Drawing.Point(73, 12);
            this.ConversionTypeBox.Name = "ConversionTypeBox";
            this.ConversionTypeBox.Size = new System.Drawing.Size(646, 23);
            this.ConversionTypeBox.TabIndex = 0;
            this.ConversionTypeBox.SelectedIndexChanged += new System.EventHandler(this.ReloadType);
            // 
            // destinationBox
            // 
            this.destinationBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.destinationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.destinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationBox.ForeColor = System.Drawing.SystemColors.Window;
            this.destinationBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.destinationBox.Location = new System.Drawing.Point(442, 94);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(277, 23);
            this.destinationBox.TabIndex = 0;
            this.destinationBox.SelectedIndexChanged += new System.EventHandler(this.Recalc);
            // 
            // originBox
            // 
            this.originBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.originBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.originBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originBox.ForeColor = System.Drawing.SystemColors.Window;
            this.originBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.originBox.Location = new System.Drawing.Point(73, 94);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(277, 23);
            this.originBox.TabIndex = 0;
            this.originBox.SelectedIndexChanged += new System.EventHandler(this.Recalc);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(73, 65);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(277, 23);
            this.inputBox.TabIndex = 1;
            this.inputBox.Leave += new System.EventHandler(this.Recalc);
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(442, 65);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(277, 23);
            this.answerText.TabIndex = 1;
            // 
            // Conversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.ConversionTypeBox);
            this.Name = "Conversions";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConversionTypeBox;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox answerText;
    }
}