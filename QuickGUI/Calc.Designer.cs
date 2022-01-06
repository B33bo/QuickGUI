using System;
using System.Runtime.InteropServices;


namespace QuickGUI
{
    partial class Calc
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
            this.equationText = new System.Windows.Forms.TextBox();
            this.key_dp = new System.Windows.Forms.Button();
            this.key_0 = new System.Windows.Forms.Button();
            this.key_i = new System.Windows.Forms.Button();
            this.key_3 = new System.Windows.Forms.Button();
            this.key_2 = new System.Windows.Forms.Button();
            this.key_1 = new System.Windows.Forms.Button();
            this.key_5 = new System.Windows.Forms.Button();
            this.key_4 = new System.Windows.Forms.Button();
            this.key_9 = new System.Windows.Forms.Button();
            this.key_8 = new System.Windows.Forms.Button();
            this.key_7 = new System.Windows.Forms.Button();
            this.key_ans = new System.Windows.Forms.Button();
            this.key_plus = new System.Windows.Forms.Button();
            this.key_timesalt = new System.Windows.Forms.Button();
            this.key_dividealt = new System.Windows.Forms.Button();
            this.key_minus = new System.Windows.Forms.Button();
            this.key_backspace = new System.Windows.Forms.Button();
            this.key_clear = new System.Windows.Forms.Button();
            this.key_degrees = new System.Windows.Forms.Button();
            this.key_power = new System.Windows.Forms.Button();
            this.key_factorial = new System.Windows.Forms.Button();
            this.key_root = new System.Windows.Forms.Button();
            this.key_percent = new System.Windows.Forms.Button();
            this.key_E = new System.Windows.Forms.Button();
            this.func = new System.Windows.Forms.Button();
            this.var = new System.Windows.Forms.Button();
            this.key_6 = new System.Windows.Forms.Button();
            this.key_openbrack = new System.Windows.Forms.Button();
            this.key_closebrack = new System.Windows.Forms.Button();
            this.key_speech = new System.Windows.Forms.Button();
            this.keepOnTop = new System.Windows.Forms.CheckBox();
            this.key_comma = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.things = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equationText
            // 
            this.equationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.equationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equationText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.equationText.Location = new System.Drawing.Point(12, 12);
            this.equationText.Name = "equationText";
            this.equationText.Size = new System.Drawing.Size(392, 54);
            this.equationText.TabIndex = 2;
            this.equationText.Text = "1+1";
            this.equationText.TextChanged += new System.EventHandler(this.UpdateEquationString);
            // 
            // key_dp
            // 
            this.key_dp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_dp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_dp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_dp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_dp.FlatAppearance.BorderSize = 3;
            this.key_dp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_dp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_dp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_dp.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_dp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_dp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_dp.Location = new System.Drawing.Point(12, 425);
            this.key_dp.Name = "key_dp";
            this.key_dp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_dp.Size = new System.Drawing.Size(71, 63);
            this.key_dp.TabIndex = 3;
            this.key_dp.Text = ".";
            this.key_dp.UseVisualStyleBackColor = false;
            this.key_dp.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_0
            // 
            this.key_0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_0.FlatAppearance.BorderSize = 3;
            this.key_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_0.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_0.Location = new System.Drawing.Point(89, 425);
            this.key_0.Name = "key_0";
            this.key_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_0.Size = new System.Drawing.Size(71, 63);
            this.key_0.TabIndex = 4;
            this.key_0.Text = "0";
            this.key_0.UseVisualStyleBackColor = false;
            this.key_0.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_i
            // 
            this.key_i.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_i.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_i.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_i.FlatAppearance.BorderSize = 3;
            this.key_i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_i.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_i.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_i.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_i.Location = new System.Drawing.Point(166, 425);
            this.key_i.Name = "key_i";
            this.key_i.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_i.Size = new System.Drawing.Size(71, 63);
            this.key_i.TabIndex = 5;
            this.key_i.Text = "i";
            this.key_i.UseVisualStyleBackColor = false;
            this.key_i.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_3
            // 
            this.key_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_3.FlatAppearance.BorderSize = 3;
            this.key_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_3.Location = new System.Drawing.Point(166, 356);
            this.key_3.Name = "key_3";
            this.key_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_3.Size = new System.Drawing.Size(71, 63);
            this.key_3.TabIndex = 8;
            this.key_3.Text = "3";
            this.key_3.UseVisualStyleBackColor = false;
            this.key_3.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_2
            // 
            this.key_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_2.FlatAppearance.BorderSize = 3;
            this.key_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_2.Location = new System.Drawing.Point(89, 356);
            this.key_2.Name = "key_2";
            this.key_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_2.Size = new System.Drawing.Size(71, 63);
            this.key_2.TabIndex = 7;
            this.key_2.Text = "2";
            this.key_2.UseVisualStyleBackColor = false;
            this.key_2.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_1
            // 
            this.key_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_1.FlatAppearance.BorderSize = 3;
            this.key_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_1.Location = new System.Drawing.Point(12, 356);
            this.key_1.Name = "key_1";
            this.key_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_1.Size = new System.Drawing.Size(71, 63);
            this.key_1.TabIndex = 6;
            this.key_1.Text = "1";
            this.key_1.UseVisualStyleBackColor = false;
            this.key_1.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_5
            // 
            this.key_5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_5.FlatAppearance.BorderSize = 3;
            this.key_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_5.Location = new System.Drawing.Point(89, 287);
            this.key_5.Name = "key_5";
            this.key_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_5.Size = new System.Drawing.Size(71, 63);
            this.key_5.TabIndex = 10;
            this.key_5.Text = "5";
            this.key_5.UseVisualStyleBackColor = false;
            this.key_5.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_4
            // 
            this.key_4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_4.FlatAppearance.BorderSize = 3;
            this.key_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_4.Location = new System.Drawing.Point(12, 287);
            this.key_4.Name = "key_4";
            this.key_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_4.Size = new System.Drawing.Size(71, 63);
            this.key_4.TabIndex = 9;
            this.key_4.Text = "4";
            this.key_4.UseVisualStyleBackColor = false;
            this.key_4.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_9
            // 
            this.key_9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_9.FlatAppearance.BorderSize = 3;
            this.key_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_9.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_9.Location = new System.Drawing.Point(166, 218);
            this.key_9.Name = "key_9";
            this.key_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_9.Size = new System.Drawing.Size(71, 63);
            this.key_9.TabIndex = 14;
            this.key_9.Text = "9";
            this.key_9.UseVisualStyleBackColor = false;
            this.key_9.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_8
            // 
            this.key_8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_8.FlatAppearance.BorderSize = 3;
            this.key_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_8.Location = new System.Drawing.Point(89, 218);
            this.key_8.Name = "key_8";
            this.key_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_8.Size = new System.Drawing.Size(71, 63);
            this.key_8.TabIndex = 13;
            this.key_8.Text = "8";
            this.key_8.UseVisualStyleBackColor = false;
            this.key_8.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_7
            // 
            this.key_7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_7.FlatAppearance.BorderSize = 3;
            this.key_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_7.Location = new System.Drawing.Point(12, 218);
            this.key_7.Name = "key_7";
            this.key_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_7.Size = new System.Drawing.Size(71, 63);
            this.key_7.TabIndex = 12;
            this.key_7.Text = "7";
            this.key_7.UseVisualStyleBackColor = false;
            this.key_7.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_ans
            // 
            this.key_ans.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_ans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_ans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_ans.FlatAppearance.BorderSize = 3;
            this.key_ans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_ans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_ans.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_ans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_ans.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_ans.Location = new System.Drawing.Point(335, 494);
            this.key_ans.Name = "key_ans";
            this.key_ans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_ans.Size = new System.Drawing.Size(71, 63);
            this.key_ans.TabIndex = 15;
            this.key_ans.Text = "=";
            this.key_ans.UseVisualStyleBackColor = false;
            this.key_ans.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_plus
            // 
            this.key_plus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_plus.FlatAppearance.BorderSize = 3;
            this.key_plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_plus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_plus.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_plus.Location = new System.Drawing.Point(258, 356);
            this.key_plus.Name = "key_plus";
            this.key_plus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_plus.Size = new System.Drawing.Size(71, 63);
            this.key_plus.TabIndex = 16;
            this.key_plus.Text = "+";
            this.key_plus.UseVisualStyleBackColor = false;
            this.key_plus.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_timesalt
            // 
            this.key_timesalt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_timesalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_timesalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_timesalt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_timesalt.FlatAppearance.BorderSize = 3;
            this.key_timesalt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_timesalt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_timesalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_timesalt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_timesalt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_timesalt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_timesalt.Location = new System.Drawing.Point(258, 218);
            this.key_timesalt.Name = "key_timesalt";
            this.key_timesalt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_timesalt.Size = new System.Drawing.Size(71, 63);
            this.key_timesalt.TabIndex = 17;
            this.key_timesalt.Text = "×";
            this.key_timesalt.UseVisualStyleBackColor = false;
            this.key_timesalt.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_dividealt
            // 
            this.key_dividealt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_dividealt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_dividealt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_dividealt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_dividealt.FlatAppearance.BorderSize = 3;
            this.key_dividealt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_dividealt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_dividealt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_dividealt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_dividealt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_dividealt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_dividealt.Location = new System.Drawing.Point(258, 149);
            this.key_dividealt.Name = "key_dividealt";
            this.key_dividealt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_dividealt.Size = new System.Drawing.Size(71, 63);
            this.key_dividealt.TabIndex = 19;
            this.key_dividealt.Text = "÷";
            this.key_dividealt.UseVisualStyleBackColor = false;
            this.key_dividealt.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_minus
            // 
            this.key_minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_minus.FlatAppearance.BorderSize = 3;
            this.key_minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_minus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_minus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_minus.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_minus.Location = new System.Drawing.Point(258, 287);
            this.key_minus.Name = "key_minus";
            this.key_minus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_minus.Size = new System.Drawing.Size(71, 63);
            this.key_minus.TabIndex = 18;
            this.key_minus.Text = "-";
            this.key_minus.UseVisualStyleBackColor = false;
            this.key_minus.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_backspace
            // 
            this.key_backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_backspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_backspace.FlatAppearance.BorderSize = 3;
            this.key_backspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_backspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_backspace.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_backspace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_backspace.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_backspace.Location = new System.Drawing.Point(89, 75);
            this.key_backspace.Name = "key_backspace";
            this.key_backspace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_backspace.Size = new System.Drawing.Size(71, 63);
            this.key_backspace.TabIndex = 20;
            this.key_backspace.Text = "<-";
            this.key_backspace.UseVisualStyleBackColor = false;
            this.key_backspace.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_clear
            // 
            this.key_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_clear.FlatAppearance.BorderSize = 3;
            this.key_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_clear.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_clear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_clear.Location = new System.Drawing.Point(166, 75);
            this.key_clear.Name = "key_clear";
            this.key_clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_clear.Size = new System.Drawing.Size(71, 63);
            this.key_clear.TabIndex = 21;
            this.key_clear.Text = "C";
            this.key_clear.UseVisualStyleBackColor = false;
            this.key_clear.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_degrees
            // 
            this.key_degrees.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_degrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_degrees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_degrees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_degrees.FlatAppearance.BorderSize = 3;
            this.key_degrees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_degrees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_degrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_degrees.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_degrees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_degrees.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_degrees.Location = new System.Drawing.Point(335, 356);
            this.key_degrees.Name = "key_degrees";
            this.key_degrees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_degrees.Size = new System.Drawing.Size(71, 63);
            this.key_degrees.TabIndex = 16;
            this.key_degrees.Text = "°";
            this.key_degrees.UseVisualStyleBackColor = false;
            this.key_degrees.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_power
            // 
            this.key_power.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_power.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_power.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_power.FlatAppearance.BorderSize = 3;
            this.key_power.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_power.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_power.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_power.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_power.Location = new System.Drawing.Point(335, 218);
            this.key_power.Name = "key_power";
            this.key_power.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_power.Size = new System.Drawing.Size(71, 63);
            this.key_power.TabIndex = 17;
            this.key_power.Text = "^";
            this.key_power.UseVisualStyleBackColor = false;
            this.key_power.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_factorial
            // 
            this.key_factorial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_factorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_factorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_factorial.FlatAppearance.BorderSize = 3;
            this.key_factorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_factorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_factorial.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_factorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_factorial.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_factorial.Location = new System.Drawing.Point(335, 287);
            this.key_factorial.Name = "key_factorial";
            this.key_factorial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_factorial.Size = new System.Drawing.Size(71, 63);
            this.key_factorial.TabIndex = 18;
            this.key_factorial.Text = "!";
            this.key_factorial.UseVisualStyleBackColor = false;
            this.key_factorial.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_root
            // 
            this.key_root.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_root.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_root.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_root.FlatAppearance.BorderSize = 3;
            this.key_root.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_root.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_root.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_root.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_root.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_root.Location = new System.Drawing.Point(335, 149);
            this.key_root.Name = "key_root";
            this.key_root.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_root.Size = new System.Drawing.Size(71, 63);
            this.key_root.TabIndex = 19;
            this.key_root.Text = "√";
            this.key_root.UseVisualStyleBackColor = false;
            this.key_root.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_percent
            // 
            this.key_percent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_percent.FlatAppearance.BorderSize = 3;
            this.key_percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_percent.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_percent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_percent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_percent.Location = new System.Drawing.Point(258, 75);
            this.key_percent.Name = "key_percent";
            this.key_percent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_percent.Size = new System.Drawing.Size(71, 63);
            this.key_percent.TabIndex = 22;
            this.key_percent.Text = "%";
            this.key_percent.UseVisualStyleBackColor = false;
            this.key_percent.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_E
            // 
            this.key_E.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_E.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_E.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_E.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.key_E.FlatAppearance.BorderSize = 3;
            this.key_E.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_E.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_E.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_E.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_E.Location = new System.Drawing.Point(335, 75);
            this.key_E.Name = "key_E";
            this.key_E.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_E.Size = new System.Drawing.Size(71, 63);
            this.key_E.TabIndex = 23;
            this.key_E.Text = "×10ˣ";
            this.key_E.UseVisualStyleBackColor = false;
            this.key_E.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // func
            // 
            this.func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.func.Cursor = System.Windows.Forms.Cursors.Hand;
            this.func.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.func.FlatAppearance.BorderSize = 3;
            this.func.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.func.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.func.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.func.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.func.Location = new System.Drawing.Point(12, 144);
            this.func.Name = "func";
            this.func.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.func.Size = new System.Drawing.Size(71, 63);
            this.func.TabIndex = 24;
            this.func.Text = "f(n)";
            this.func.UseVisualStyleBackColor = false;
            this.func.Click += new System.EventHandler(this.OpenWindow);
            // 
            // var
            // 
            this.var.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.var.Cursor = System.Windows.Forms.Cursors.Hand;
            this.var.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.var.FlatAppearance.BorderSize = 3;
            this.var.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.var.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.var.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.var.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.var.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.var.Location = new System.Drawing.Point(89, 144);
            this.var.Name = "var";
            this.var.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var.Size = new System.Drawing.Size(71, 63);
            this.var.TabIndex = 25;
            this.var.Text = "n";
            this.var.UseVisualStyleBackColor = false;
            this.var.Click += new System.EventHandler(this.OpenWindow);
            // 
            // key_6
            // 
            this.key_6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.key_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.key_6.FlatAppearance.BorderSize = 3;
            this.key_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_6.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_6.Location = new System.Drawing.Point(166, 287);
            this.key_6.Name = "key_6";
            this.key_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_6.Size = new System.Drawing.Size(71, 63);
            this.key_6.TabIndex = 10;
            this.key_6.Text = "6";
            this.key_6.UseVisualStyleBackColor = false;
            this.key_6.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_openbrack
            // 
            this.key_openbrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_openbrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_openbrack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.key_openbrack.FlatAppearance.BorderSize = 3;
            this.key_openbrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_openbrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_openbrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_openbrack.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_openbrack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_openbrack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_openbrack.Location = new System.Drawing.Point(89, 494);
            this.key_openbrack.Name = "key_openbrack";
            this.key_openbrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_openbrack.Size = new System.Drawing.Size(71, 63);
            this.key_openbrack.TabIndex = 14;
            this.key_openbrack.Text = "(";
            this.key_openbrack.UseVisualStyleBackColor = false;
            this.key_openbrack.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_closebrack
            // 
            this.key_closebrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_closebrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_closebrack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.key_closebrack.FlatAppearance.BorderSize = 3;
            this.key_closebrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_closebrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_closebrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_closebrack.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_closebrack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_closebrack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_closebrack.Location = new System.Drawing.Point(166, 494);
            this.key_closebrack.Name = "key_closebrack";
            this.key_closebrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.key_closebrack.Size = new System.Drawing.Size(71, 63);
            this.key_closebrack.TabIndex = 14;
            this.key_closebrack.Text = ")";
            this.key_closebrack.UseVisualStyleBackColor = false;
            this.key_closebrack.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // key_speech
            // 
            this.key_speech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.key_speech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_speech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_speech.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.key_speech.FlatAppearance.BorderSize = 3;
            this.key_speech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_speech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_speech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_speech.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_speech.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_speech.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_speech.Location = new System.Drawing.Point(12, 494);
            this.key_speech.Name = "key_speech";
            this.key_speech.Size = new System.Drawing.Size(71, 63);
            this.key_speech.TabIndex = 26;
            this.key_speech.Text = "\"";
            this.key_speech.UseVisualStyleBackColor = false;
            this.key_speech.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // keepOnTop
            // 
            this.keepOnTop.AutoSize = true;
            this.keepOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.keepOnTop.ForeColor = System.Drawing.Color.Goldenrod;
            this.keepOnTop.Location = new System.Drawing.Point(311, 47);
            this.keepOnTop.Name = "keepOnTop";
            this.keepOnTop.Size = new System.Drawing.Size(93, 19);
            this.keepOnTop.TabIndex = 27;
            this.keepOnTop.Text = "Keep On Top";
            this.keepOnTop.UseVisualStyleBackColor = false;
            this.keepOnTop.CheckedChanged += new System.EventHandler(this.KeepOnTopToggle);
            // 
            // key_comma
            // 
            this.key_comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.key_comma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_comma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.key_comma.FlatAppearance.BorderSize = 3;
            this.key_comma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_comma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_comma.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.key_comma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_comma.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.key_comma.Location = new System.Drawing.Point(258, 494);
            this.key_comma.Name = "key_comma";
            this.key_comma.Size = new System.Drawing.Size(71, 63);
            this.key_comma.TabIndex = 26;
            this.key_comma.Text = ",";
            this.key_comma.UseVisualStyleBackColor = false;
            this.key_comma.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(258, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 63);
            this.button4.TabIndex = 26;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CalcKeyPress);
            // 
            // things
            // 
            this.things.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.things.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.things.Cursor = System.Windows.Forms.Cursors.Hand;
            this.things.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.things.FlatAppearance.BorderSize = 3;
            this.things.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.things.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.things.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.things.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.things.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.things.Location = new System.Drawing.Point(12, 75);
            this.things.Name = "things";
            this.things.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.things.Size = new System.Drawing.Size(71, 63);
            this.things.TabIndex = 20;
            this.things.Text = "...";
            this.things.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.things.UseVisualStyleBackColor = false;
            this.things.Click += new System.EventHandler(this.OpenWindow);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(416, 565);
            this.Controls.Add(this.keepOnTop);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.key_comma);
            this.Controls.Add(this.key_speech);
            this.Controls.Add(this.var);
            this.Controls.Add(this.func);
            this.Controls.Add(this.key_E);
            this.Controls.Add(this.key_percent);
            this.Controls.Add(this.key_clear);
            this.Controls.Add(this.things);
            this.Controls.Add(this.key_backspace);
            this.Controls.Add(this.key_root);
            this.Controls.Add(this.key_dividealt);
            this.Controls.Add(this.key_factorial);
            this.Controls.Add(this.key_minus);
            this.Controls.Add(this.key_power);
            this.Controls.Add(this.key_timesalt);
            this.Controls.Add(this.key_degrees);
            this.Controls.Add(this.key_plus);
            this.Controls.Add(this.key_ans);
            this.Controls.Add(this.key_closebrack);
            this.Controls.Add(this.key_openbrack);
            this.Controls.Add(this.key_9);
            this.Controls.Add(this.key_8);
            this.Controls.Add(this.key_7);
            this.Controls.Add(this.key_6);
            this.Controls.Add(this.key_5);
            this.Controls.Add(this.key_4);
            this.Controls.Add(this.key_3);
            this.Controls.Add(this.key_2);
            this.Controls.Add(this.key_1);
            this.Controls.Add(this.key_i);
            this.Controls.Add(this.key_0);
            this.Controls.Add(this.key_dp);
            this.Controls.Add(this.equationText);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox equationText;
        private System.Windows.Forms.Button key_dp;
        private System.Windows.Forms.Button key_0;
        private System.Windows.Forms.Button key_i;
        private System.Windows.Forms.Button key_3;
        private System.Windows.Forms.Button key_2;
        private System.Windows.Forms.Button key_1;
        private System.Windows.Forms.Button key_5;
        private System.Windows.Forms.Button key_4;
        private System.Windows.Forms.Button key_9;
        private System.Windows.Forms.Button key_8;
        private System.Windows.Forms.Button key_7;
        private System.Windows.Forms.Button key_ans;
        private System.Windows.Forms.Button key_plus;
        private System.Windows.Forms.Button key_timesalt;
        private System.Windows.Forms.Button key_dividealt;
        private System.Windows.Forms.Button key_minus;
        private System.Windows.Forms.Button key_backspace;
        private System.Windows.Forms.Button key_clear;
        private System.Windows.Forms.Button key_degrees;
        private System.Windows.Forms.Button key_power;
        private System.Windows.Forms.Button key_factorial;
        private System.Windows.Forms.Button key_root;
        private System.Windows.Forms.Button key_percent;
        private System.Windows.Forms.Button key_E;
        private System.Windows.Forms.Button func;
        private System.Windows.Forms.Button var;
        private System.Windows.Forms.Button key_6;
        private System.Windows.Forms.Button key_openbrack;
        private System.Windows.Forms.Button key_closebrack;
        private System.Windows.Forms.Button key_speech;
        private System.Windows.Forms.CheckBox keepOnTop;
        private System.Windows.Forms.Button key_comma;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button things;
    }
}

