namespace tic_tac_toe_ONLINE
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_TurnIndicator = new System.Windows.Forms.Button();
            this.Button_SideIndicator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 429);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.DarkRed;
            this.Button_Close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Close.Location = new System.Drawing.Point(447, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(208, 55);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.Text = "Exit game";
            this.Button_Close.UseVisualStyleBackColor = false;
            // 
            // Button_TurnIndicator
            // 
            this.Button_TurnIndicator.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_TurnIndicator.Location = new System.Drawing.Point(447, 134);
            this.Button_TurnIndicator.Name = "Button_TurnIndicator";
            this.Button_TurnIndicator.Size = new System.Drawing.Size(208, 55);
            this.Button_TurnIndicator.TabIndex = 3;
            this.Button_TurnIndicator.UseVisualStyleBackColor = true;
            // 
            // Button_SideIndicator
            // 
            this.Button_SideIndicator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_SideIndicator.Location = new System.Drawing.Point(447, 73);
            this.Button_SideIndicator.Name = "Button_SideIndicator";
            this.Button_SideIndicator.Size = new System.Drawing.Size(208, 55);
            this.Button_SideIndicator.TabIndex = 4;
            this.Button_SideIndicator.Text = "You are playing crosses";
            this.Button_SideIndicator.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 453);
            this.Controls.Add(this.Button_SideIndicator);
            this.Controls.Add(this.Button_TurnIndicator);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button Button_Close;
        private Button Button_TurnIndicator;
        private Button Button_SideIndicator;
    }
}