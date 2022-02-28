namespace tic_tac_toe_ONLINE
{
    partial class Menu
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
            this.Button_CreateSession = new System.Windows.Forms.Button();
            this.Button_JoinSession = new System.Windows.Forms.Button();
            this.NumericUpDown_SessionId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SessionId)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_CreateSession
            // 
            this.Button_CreateSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_CreateSession.Location = new System.Drawing.Point(12, 12);
            this.Button_CreateSession.Name = "Button_CreateSession";
            this.Button_CreateSession.Size = new System.Drawing.Size(360, 145);
            this.Button_CreateSession.TabIndex = 0;
            this.Button_CreateSession.Text = "Create online session";
            this.Button_CreateSession.UseVisualStyleBackColor = true;
            this.Button_CreateSession.Click += new System.EventHandler(this.Button_CreateSession_Click);
            // 
            // Button_JoinSession
            // 
            this.Button_JoinSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_JoinSession.Location = new System.Drawing.Point(12, 163);
            this.Button_JoinSession.Name = "Button_JoinSession";
            this.Button_JoinSession.Size = new System.Drawing.Size(360, 145);
            this.Button_JoinSession.TabIndex = 1;
            this.Button_JoinSession.Text = "Join online session";
            this.Button_JoinSession.UseVisualStyleBackColor = true;
            this.Button_JoinSession.Click += new System.EventHandler(this.Button_JoinSession_Click);
            // 
            // NumericUpDown_SessionId
            // 
            this.NumericUpDown_SessionId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericUpDown_SessionId.Location = new System.Drawing.Point(12, 314);
            this.NumericUpDown_SessionId.Maximum = new decimal(new int[] {
            -1,
            65535,
            0,
            0});
            this.NumericUpDown_SessionId.Name = "NumericUpDown_SessionId";
            this.NumericUpDown_SessionId.Size = new System.Drawing.Size(360, 35);
            this.NumericUpDown_SessionId.TabIndex = 2;
            this.NumericUpDown_SessionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.NumericUpDown_SessionId);
            this.Controls.Add(this.Button_JoinSession);
            this.Controls.Add(this.Button_CreateSession);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SessionId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Button_CreateSession;
        private Button Button_JoinSession;
        private NumericUpDown NumericUpDown_SessionId;
    }
}