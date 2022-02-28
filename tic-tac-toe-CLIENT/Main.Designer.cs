namespace tic_tac_toe_CLIENT
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
            this.button_exit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.numericbox_id = new System.Windows.Forms.NumericUpDown();
            this.button_start_offline = new System.Windows.Forms.Button();
            this.button_join_session = new System.Windows.Forms.Button();
            this.button_start_session = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Panel();
            this.textbox_side = new System.Windows.Forms.TextBox();
            this.textbox_session_id = new System.Windows.Forms.TextBox();
            this.textbox_turn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.board_0_0 = new System.Windows.Forms.Button();
            this.board_0_1 = new System.Windows.Forms.Button();
            this.board_0_2 = new System.Windows.Forms.Button();
            this.board_1_0 = new System.Windows.Forms.Button();
            this.board_1_1 = new System.Windows.Forms.Button();
            this.board_1_2 = new System.Windows.Forms.Button();
            this.board_2_0 = new System.Windows.Forms.Button();
            this.board_2_1 = new System.Windows.Forms.Button();
            this.board_2_2 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_id)).BeginInit();
            this.game.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Location = new System.Drawing.Point(855, 16);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(46, 53);
            this.button_exit.TabIndex = 0;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Coral;
            this.menu.Controls.Add(this.numericbox_id);
            this.menu.Controls.Add(this.button_start_offline);
            this.menu.Controls.Add(this.button_join_session);
            this.menu.Controls.Add(this.button_start_session);
            this.menu.Location = new System.Drawing.Point(14, 16);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(834, 635);
            this.menu.TabIndex = 1;
            // 
            // numericbox_id
            // 
            this.numericbox_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numericbox_id.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericbox_id.Location = new System.Drawing.Point(207, 415);
            this.numericbox_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericbox_id.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericbox_id.Name = "numericbox_id";
            this.numericbox_id.Size = new System.Drawing.Size(207, 27);
            this.numericbox_id.TabIndex = 3;
            this.numericbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_start_offline
            // 
            this.button_start_offline.Location = new System.Drawing.Point(421, 189);
            this.button_start_offline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start_offline.Name = "button_start_offline";
            this.button_start_offline.Size = new System.Drawing.Size(207, 256);
            this.button_start_offline.TabIndex = 2;
            this.button_start_offline.Text = "Start offline game";
            this.button_start_offline.UseVisualStyleBackColor = true;
            this.button_start_offline.Click += new System.EventHandler(this.button_start_offline_Click);
            // 
            // button_join_session
            // 
            this.button_join_session.Location = new System.Drawing.Point(207, 321);
            this.button_join_session.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_join_session.Name = "button_join_session";
            this.button_join_session.Size = new System.Drawing.Size(207, 85);
            this.button_join_session.TabIndex = 1;
            this.button_join_session.Text = "Join session";
            this.button_join_session.UseVisualStyleBackColor = true;
            this.button_join_session.Click += new System.EventHandler(this.button_join_session_Click);
            // 
            // button_start_session
            // 
            this.button_start_session.Location = new System.Drawing.Point(207, 189);
            this.button_start_session.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start_session.Name = "button_start_session";
            this.button_start_session.Size = new System.Drawing.Size(207, 124);
            this.button_start_session.TabIndex = 0;
            this.button_start_session.Text = "Create session";
            this.button_start_session.UseVisualStyleBackColor = true;
            this.button_start_session.Click += new System.EventHandler(this.button_start_session_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.Gold;
            this.game.Controls.Add(this.textbox_side);
            this.game.Controls.Add(this.textbox_session_id);
            this.game.Controls.Add(this.textbox_turn);
            this.game.Controls.Add(this.tableLayoutPanel2);
            this.game.Location = new System.Drawing.Point(14, 16);
            this.game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(834, 635);
            this.game.TabIndex = 3;
            this.game.Visible = false;
            // 
            // textbox_side
            // 
            this.textbox_side.Location = new System.Drawing.Point(547, 43);
            this.textbox_side.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_side.Name = "textbox_side";
            this.textbox_side.Size = new System.Drawing.Size(283, 27);
            this.textbox_side.TabIndex = 3;
            this.textbox_side.Visible = false;
            // 
            // textbox_session_id
            // 
            this.textbox_session_id.Location = new System.Drawing.Point(547, 81);
            this.textbox_session_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_session_id.Name = "textbox_session_id";
            this.textbox_session_id.Size = new System.Drawing.Size(283, 27);
            this.textbox_session_id.TabIndex = 2;
            this.textbox_session_id.Visible = false;
            // 
            // textbox_turn
            // 
            this.textbox_turn.Location = new System.Drawing.Point(547, 4);
            this.textbox_turn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_turn.Name = "textbox_turn";
            this.textbox_turn.Size = new System.Drawing.Size(283, 27);
            this.textbox_turn.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.board_0_0, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.board_0_1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.board_0_2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.board_1_0, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.board_1_1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.board_1_2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.board_2_0, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.board_2_1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.board_2_2, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 627);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // board_0_0
            // 
            this.board_0_0.BackColor = System.Drawing.Color.Gold;
            this.board_0_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_0_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_0_0.Location = new System.Drawing.Point(0, 0);
            this.board_0_0.Margin = new System.Windows.Forms.Padding(0);
            this.board_0_0.Name = "board_0_0";
            this.board_0_0.Size = new System.Drawing.Size(178, 208);
            this.board_0_0.TabIndex = 0;
            this.board_0_0.UseVisualStyleBackColor = false;
            // 
            // board_0_1
            // 
            this.board_0_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_0_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_0_1.Location = new System.Drawing.Point(179, 0);
            this.board_0_1.Margin = new System.Windows.Forms.Padding(0);
            this.board_0_1.Name = "board_0_1";
            this.board_0_1.Size = new System.Drawing.Size(178, 208);
            this.board_0_1.TabIndex = 1;
            this.board_0_1.UseVisualStyleBackColor = false;
            // 
            // board_0_2
            // 
            this.board_0_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_0_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_0_2.Location = new System.Drawing.Point(358, 0);
            this.board_0_2.Margin = new System.Windows.Forms.Padding(0);
            this.board_0_2.Name = "board_0_2";
            this.board_0_2.Size = new System.Drawing.Size(179, 208);
            this.board_0_2.TabIndex = 2;
            this.board_0_2.UseVisualStyleBackColor = false;
            // 
            // board_1_0
            // 
            this.board_1_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_1_0.Location = new System.Drawing.Point(0, 209);
            this.board_1_0.Margin = new System.Windows.Forms.Padding(0);
            this.board_1_0.Name = "board_1_0";
            this.board_1_0.Size = new System.Drawing.Size(178, 208);
            this.board_1_0.TabIndex = 3;
            this.board_1_0.UseVisualStyleBackColor = false;
            // 
            // board_1_1
            // 
            this.board_1_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_1_1.Location = new System.Drawing.Point(179, 209);
            this.board_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.board_1_1.Name = "board_1_1";
            this.board_1_1.Size = new System.Drawing.Size(178, 208);
            this.board_1_1.TabIndex = 4;
            this.board_1_1.UseVisualStyleBackColor = false;
            // 
            // board_1_2
            // 
            this.board_1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_1_2.Location = new System.Drawing.Point(358, 209);
            this.board_1_2.Margin = new System.Windows.Forms.Padding(0);
            this.board_1_2.Name = "board_1_2";
            this.board_1_2.Size = new System.Drawing.Size(179, 208);
            this.board_1_2.TabIndex = 5;
            this.board_1_2.UseVisualStyleBackColor = false;
            // 
            // board_2_0
            // 
            this.board_2_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_2_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_2_0.Location = new System.Drawing.Point(0, 418);
            this.board_2_0.Margin = new System.Windows.Forms.Padding(0);
            this.board_2_0.Name = "board_2_0";
            this.board_2_0.Size = new System.Drawing.Size(178, 209);
            this.board_2_0.TabIndex = 6;
            this.board_2_0.UseVisualStyleBackColor = false;
            // 
            // board_2_1
            // 
            this.board_2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_2_1.Location = new System.Drawing.Point(179, 418);
            this.board_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.board_2_1.Name = "board_2_1";
            this.board_2_1.Size = new System.Drawing.Size(178, 209);
            this.board_2_1.TabIndex = 7;
            this.board_2_1.UseVisualStyleBackColor = false;
            // 
            // board_2_2
            // 
            this.board_2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.board_2_2.Location = new System.Drawing.Point(358, 418);
            this.board_2_2.Margin = new System.Windows.Forms.Padding(0);
            this.board_2_2.Name = "board_2_2";
            this.board_2_2.Size = new System.Drawing.Size(179, 209);
            this.board_2_2.TabIndex = 8;
            this.board_2_2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 667);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericbox_id)).EndInit();
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_exit;
        private Panel menu;
        private Button button_start_offline;
        private Button button_join_session;
        private Button button_start_session;
        private Panel game;
        private TableLayoutPanel tableLayoutPanel2;
        private Button board_0_0;
        private Button board_0_1;
        private Button board_0_2;
        private Button board_1_0;
        private Button board_1_1;
        private Button board_1_2;
        private Button board_2_0;
        private Button board_2_1;
        private Button board_2_2;
        private TextBox textbox_turn;
        private NumericUpDown numericbox_id;
        private TextBox textbox_session_id;
        private TextBox textbox_side;
    }
}