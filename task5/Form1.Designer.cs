namespace task5
{
    partial class Form1
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
            this.OpacityBtn = new System.Windows.Forms.Button();
            this.ColorBackgroundBtn = new System.Windows.Forms.Button();
            this.MessageBtn = new System.Windows.Forms.Button();
            this.btnSetOfActions = new System.Windows.Forms.Button();
            this.OpacityCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorBackgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OpacityBtn
            // 
            this.OpacityBtn.Location = new System.Drawing.Point(0, 2);
            this.OpacityBtn.Name = "OpacityBtn";
            this.OpacityBtn.Size = new System.Drawing.Size(75, 23);
            this.OpacityBtn.TabIndex = 0;
            this.OpacityBtn.Text = "Прозорість";
            this.OpacityBtn.UseVisualStyleBackColor = true;
            this.OpacityBtn.Click += new System.EventHandler(this.OpacityBtn_Click);
            // 
            // ColorBackgroundBtn
            // 
            this.ColorBackgroundBtn.Location = new System.Drawing.Point(81, 2);
            this.ColorBackgroundBtn.Name = "ColorBackgroundBtn";
            this.ColorBackgroundBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorBackgroundBtn.TabIndex = 1;
            this.ColorBackgroundBtn.Text = "Колір тла";
            this.ColorBackgroundBtn.UseVisualStyleBackColor = true;
            this.ColorBackgroundBtn.Click += new System.EventHandler(this.ColorBackgroundBtn_Click);
            // 
            // MessageBtn
            // 
            this.MessageBtn.Location = new System.Drawing.Point(162, 2);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Size = new System.Drawing.Size(75, 23);
            this.MessageBtn.TabIndex = 2;
            this.MessageBtn.Text = "Hello World";
            this.MessageBtn.UseVisualStyleBackColor = true;
            this.MessageBtn.Click += new System.EventHandler(this.MessageBtn_Click);
            // 
            // btnSetOfActions
            // 
            this.btnSetOfActions.Location = new System.Drawing.Point(0, 31);
            this.btnSetOfActions.Name = "btnSetOfActions";
            this.btnSetOfActions.Size = new System.Drawing.Size(237, 23);
            this.btnSetOfActions.TabIndex = 3;
            this.btnSetOfActions.Text = "супермегакнопка";
            this.btnSetOfActions.UseVisualStyleBackColor = true;
            this.btnSetOfActions.Click += new System.EventHandler(this.btnSetOfActions_Click);
            // 
            // OpacityCheckBox
            // 
            this.OpacityCheckBox.AutoSize = true;
            this.OpacityCheckBox.Location = new System.Drawing.Point(0, 76);
            this.OpacityCheckBox.Name = "OpacityCheckBox";
            this.OpacityCheckBox.Size = new System.Drawing.Size(246, 17);
            this.OpacityCheckBox.TabIndex = 4;
            this.OpacityCheckBox.Text = "\"супермегакнопка\" поглинає \"Прозорість\"";
            this.OpacityCheckBox.UseVisualStyleBackColor = true;
            this.OpacityCheckBox.CheckedChanged += new System.EventHandler(this.OpacityCheckBox_CheckedChanged);
            // 
            // ColorBackgroundCheckBox
            // 
            this.ColorBackgroundCheckBox.AutoSize = true;
            this.ColorBackgroundCheckBox.Location = new System.Drawing.Point(0, 99);
            this.ColorBackgroundCheckBox.Name = "ColorBackgroundCheckBox";
            this.ColorBackgroundCheckBox.Size = new System.Drawing.Size(236, 17);
            this.ColorBackgroundCheckBox.TabIndex = 5;
            this.ColorBackgroundCheckBox.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            this.ColorBackgroundCheckBox.UseVisualStyleBackColor = true;
            this.ColorBackgroundCheckBox.CheckedChanged += new System.EventHandler(this.ColorBackgroundCheckBox_CheckedChanged);
            // 
            // MessageCheckBox
            // 
            this.MessageCheckBox.AutoSize = true;
            this.MessageCheckBox.Location = new System.Drawing.Point(0, 122);
            this.MessageCheckBox.Name = "MessageCheckBox";
            this.MessageCheckBox.Size = new System.Drawing.Size(244, 17);
            this.MessageCheckBox.TabIndex = 6;
            this.MessageCheckBox.Text = "\"супермегакнопка\" поглинає \"Hello World\"";
            this.MessageCheckBox.UseVisualStyleBackColor = true;
            this.MessageCheckBox.CheckedChanged += new System.EventHandler(this.MessageCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageCheckBox);
            this.Controls.Add(this.ColorBackgroundCheckBox);
            this.Controls.Add(this.OpacityCheckBox);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.ColorBackgroundBtn);
            this.Controls.Add(this.OpacityBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpacityBtn;
        private System.Windows.Forms.Button ColorBackgroundBtn;
        private System.Windows.Forms.Button MessageBtn;
        private System.Windows.Forms.Button btnSetOfActions;
        private System.Windows.Forms.CheckBox OpacityCheckBox;
        private System.Windows.Forms.CheckBox ColorBackgroundCheckBox;
        private System.Windows.Forms.CheckBox MessageCheckBox;
    }
}

