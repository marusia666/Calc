
namespace Calculator
{
    partial class History
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.Res1_textBox = new System.Windows.Forms.TextBox();
            this.SpLast_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Undo);
            this.panel1.Controls.Add(this.Redo);
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Controls.Add(this.Res1_textBox);
            this.panel1.Controls.Add(this.SpLast_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 614);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(232)))));
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Undo.Location = new System.Drawing.Point(440, 297);
            this.Undo.Margin = new System.Windows.Forms.Padding(4);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(306, 90);
            this.Undo.TabIndex = 148;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(232)))));
            this.Redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Redo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redo.Location = new System.Drawing.Point(0, 297);
            this.Redo.Margin = new System.Windows.Forms.Padding(4);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(306, 90);
            this.Redo.TabIndex = 147;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = false;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(707, 0);
            this.Close_button.Margin = new System.Windows.Forms.Padding(4);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(39, 42);
            this.Close_button.TabIndex = 146;
            this.Close_button.Text = "x";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Res1_textBox
            // 
            this.Res1_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Res1_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res1_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Res1_textBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res1_textBox.Location = new System.Drawing.Point(127, 74);
            this.Res1_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Res1_textBox.Multiline = true;
            this.Res1_textBox.Name = "Res1_textBox";
            this.Res1_textBox.Size = new System.Drawing.Size(615, 75);
            this.Res1_textBox.TabIndex = 106;
            // 
            // SpLast_button
            // 
            this.SpLast_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(232)))));
            this.SpLast_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpLast_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SpLast_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpLast_button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpLast_button.Location = new System.Drawing.Point(0, 74);
            this.SpLast_button.Margin = new System.Windows.Forms.Padding(4);
            this.SpLast_button.Name = "SpLast_button";
            this.SpLast_button.Size = new System.Drawing.Size(119, 73);
            this.SpLast_button.TabIndex = 105;
            this.SpLast_button.Text = "show last step";
            this.SpLast_button.UseVisualStyleBackColor = false;
            this.SpLast_button.Click += new System.EventHandler(this.SpLast_button_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(746, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "History";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.TextBox Res1_textBox;
        private System.Windows.Forms.Button SpLast_button;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
    }
}