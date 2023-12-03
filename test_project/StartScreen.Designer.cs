namespace test_project
{
    partial class StartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogEvent = new System.Windows.Forms.Button();
            this.SignEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note";
            // 
            // LogEvent
            // 
            this.LogEvent.Location = new System.Drawing.Point(237, 144);
            this.LogEvent.Name = "LogEvent";
            this.LogEvent.Size = new System.Drawing.Size(141, 66);
            this.LogEvent.TabIndex = 1;
            this.LogEvent.Text = "Login";
            this.LogEvent.UseVisualStyleBackColor = true;
            this.LogEvent.Click += new System.EventHandler(this.LogEvent_Click);
            // 
            // SignEvent
            // 
            this.SignEvent.Location = new System.Drawing.Point(237, 258);
            this.SignEvent.Name = "SignEvent";
            this.SignEvent.Size = new System.Drawing.Size(141, 66);
            this.SignEvent.TabIndex = 2;
            this.SignEvent.Text = "Sign Up";
            this.SignEvent.UseVisualStyleBackColor = true;
            this.SignEvent.Click += new System.EventHandler(this.SignEvent_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.SignEvent);
            this.Controls.Add(this.LogEvent);
            this.Controls.Add(this.label1);
            this.Name = "StartScreen";
            this.Text = "GetStarted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogEvent;
        private System.Windows.Forms.Button SignEvent;
    }
}

