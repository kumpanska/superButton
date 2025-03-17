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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.ColorBackgroundBtn);
            this.Controls.Add(this.OpacityBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpacityBtn;
        private System.Windows.Forms.Button ColorBackgroundBtn;
        private System.Windows.Forms.Button MessageBtn;
        private System.Windows.Forms.Button btnSetOfActions;
    }
}

