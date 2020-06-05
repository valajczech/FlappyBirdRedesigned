namespace FlappyBirdRecreated
{
    partial class ActualGame
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualGame));
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.GameObject_Player = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_jumping = new System.Windows.Forms.Label();
            this.lbl_falling = new System.Windows.Forms.Label();
            this.gameSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.DownColumn_1 = new System.Windows.Forms.PictureBox();
            this.DownColumn_2 = new System.Windows.Forms.PictureBox();
            this.UpColumn_1 = new System.Windows.Forms.PictureBox();
            this.UpColumn_2 = new System.Windows.Forms.PictureBox();
            this.lbl_death = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_bckMain = new System.Windows.Forms.Button();
            this.DownColumn_3 = new System.Windows.Forms.PictureBox();
            this.UpColumn_3 = new System.Windows.Forms.PictureBox();
            this.trolololo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameObject_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trolololo)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 1;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // GameObject_Player
            // 
            this.GameObject_Player.BackColor = System.Drawing.Color.Transparent;
            this.GameObject_Player.Enabled = false;
            this.GameObject_Player.Image = ((System.Drawing.Image)(resources.GetObject("GameObject_Player.Image")));
            this.GameObject_Player.Location = new System.Drawing.Point(213, 181);
            this.GameObject_Player.Name = "GameObject_Player";
            this.GameObject_Player.Size = new System.Drawing.Size(50, 50);
            this.GameObject_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameObject_Player.TabIndex = 2;
            this.GameObject_Player.TabStop = false;
            this.GameObject_Player.Click += new System.EventHandler(this.GameObject_Player_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jump";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fall";
            // 
            // lbl_jumping
            // 
            this.lbl_jumping.AutoSize = true;
            this.lbl_jumping.Location = new System.Drawing.Point(96, 112);
            this.lbl_jumping.Name = "lbl_jumping";
            this.lbl_jumping.Size = new System.Drawing.Size(13, 13);
            this.lbl_jumping.TabIndex = 5;
            this.lbl_jumping.Text = "0";
            // 
            // lbl_falling
            // 
            this.lbl_falling.AutoSize = true;
            this.lbl_falling.Location = new System.Drawing.Point(96, 85);
            this.lbl_falling.Name = "lbl_falling";
            this.lbl_falling.Size = new System.Drawing.Size(13, 13);
            this.lbl_falling.TabIndex = 6;
            this.lbl_falling.Text = "0";
            // 
            // gameSpeedTimer
            // 
            this.gameSpeedTimer.Enabled = true;
            this.gameSpeedTimer.Interval = 7500;
            this.gameSpeedTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // DownColumn_1
            // 
            this.DownColumn_1.BackColor = System.Drawing.Color.Transparent;
            this.DownColumn_1.Image = ((System.Drawing.Image)(resources.GetObject("DownColumn_1.Image")));
            this.DownColumn_1.Location = new System.Drawing.Point(222, 285);
            this.DownColumn_1.Name = "DownColumn_1";
            this.DownColumn_1.Size = new System.Drawing.Size(100, 400);
            this.DownColumn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DownColumn_1.TabIndex = 9;
            this.DownColumn_1.TabStop = false;
            // 
            // DownColumn_2
            // 
            this.DownColumn_2.BackColor = System.Drawing.Color.Transparent;
            this.DownColumn_2.Image = ((System.Drawing.Image)(resources.GetObject("DownColumn_2.Image")));
            this.DownColumn_2.Location = new System.Drawing.Point(485, 285);
            this.DownColumn_2.Name = "DownColumn_2";
            this.DownColumn_2.Size = new System.Drawing.Size(100, 400);
            this.DownColumn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DownColumn_2.TabIndex = 10;
            this.DownColumn_2.TabStop = false;
            // 
            // UpColumn_1
            // 
            this.UpColumn_1.BackColor = System.Drawing.Color.Transparent;
            this.UpColumn_1.Image = ((System.Drawing.Image)(resources.GetObject("UpColumn_1.Image")));
            this.UpColumn_1.Location = new System.Drawing.Point(222, -249);
            this.UpColumn_1.Name = "UpColumn_1";
            this.UpColumn_1.Size = new System.Drawing.Size(100, 400);
            this.UpColumn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UpColumn_1.TabIndex = 11;
            this.UpColumn_1.TabStop = false;
            // 
            // UpColumn_2
            // 
            this.UpColumn_2.BackColor = System.Drawing.Color.Transparent;
            this.UpColumn_2.Image = ((System.Drawing.Image)(resources.GetObject("UpColumn_2.Image")));
            this.UpColumn_2.Location = new System.Drawing.Point(726, -249);
            this.UpColumn_2.Name = "UpColumn_2";
            this.UpColumn_2.Size = new System.Drawing.Size(100, 400);
            this.UpColumn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UpColumn_2.TabIndex = 12;
            this.UpColumn_2.TabStop = false;
            // 
            // lbl_death
            // 
            this.lbl_death.AutoSize = true;
            this.lbl_death.BackColor = System.Drawing.Color.Transparent;
            this.lbl_death.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_death.Location = new System.Drawing.Point(278, 137);
            this.lbl_death.Name = "lbl_death";
            this.lbl_death.Size = new System.Drawing.Size(260, 55);
            this.lbl_death.TabIndex = 13;
            this.lbl_death.Text = "You DIED!";
            this.lbl_death.Visible = false;
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_restart.Location = new System.Drawing.Point(342, 206);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(124, 25);
            this.lbl_restart.TabIndex = 14;
            this.lbl_restart.Text = "Try again?";
            this.lbl_restart.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Lime;
            this.btn_restart.Location = new System.Drawing.Point(319, 248);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 15;
            this.btn_restart.Text = "YES";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_bckMain
            // 
            this.btn_bckMain.BackColor = System.Drawing.Color.IndianRed;
            this.btn_bckMain.Location = new System.Drawing.Point(414, 248);
            this.btn_bckMain.Name = "btn_bckMain";
            this.btn_bckMain.Size = new System.Drawing.Size(75, 23);
            this.btn_bckMain.TabIndex = 16;
            this.btn_bckMain.Text = "NO";
            this.btn_bckMain.UseVisualStyleBackColor = false;
            this.btn_bckMain.Visible = false;
            this.btn_bckMain.Click += new System.EventHandler(this.btn_bckMain_Click);
            // 
            // DownColumn_3
            // 
            this.DownColumn_3.BackColor = System.Drawing.Color.Transparent;
            this.DownColumn_3.Image = ((System.Drawing.Image)(resources.GetObject("DownColumn_3.Image")));
            this.DownColumn_3.Location = new System.Drawing.Point(726, 275);
            this.DownColumn_3.Name = "DownColumn_3";
            this.DownColumn_3.Size = new System.Drawing.Size(100, 400);
            this.DownColumn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DownColumn_3.TabIndex = 17;
            this.DownColumn_3.TabStop = false;
            // 
            // UpColumn_3
            // 
            this.UpColumn_3.BackColor = System.Drawing.Color.Transparent;
            this.UpColumn_3.Image = ((System.Drawing.Image)(resources.GetObject("UpColumn_3.Image")));
            this.UpColumn_3.Location = new System.Drawing.Point(485, -249);
            this.UpColumn_3.Name = "UpColumn_3";
            this.UpColumn_3.Size = new System.Drawing.Size(100, 400);
            this.UpColumn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UpColumn_3.TabIndex = 18;
            this.UpColumn_3.TabStop = false;
            // 
            // trolololo
            // 
            this.trolololo.BackColor = System.Drawing.Color.Transparent;
            this.trolololo.Image = global::FlappyBirdRecreated.Properties.Resources.trollface;
            this.trolololo.Location = new System.Drawing.Point(1, 442);
            this.trolololo.Name = "trolololo";
            this.trolololo.Size = new System.Drawing.Size(22, 19);
            this.trolololo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trolololo.TabIndex = 19;
            this.trolololo.TabStop = false;
            this.trolololo.Visible = false;
            this.trolololo.Click += new System.EventHandler(this.trolololo_Click);
            // 
            // ActualGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FlappyBirdRecreated.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.trolololo);
            this.Controls.Add(this.btn_bckMain);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.lbl_death);
            this.Controls.Add(this.UpColumn_3);
            this.Controls.Add(this.DownColumn_3);
            this.Controls.Add(this.UpColumn_2);
            this.Controls.Add(this.UpColumn_1);
            this.Controls.Add(this.DownColumn_2);
            this.Controls.Add(this.DownColumn_1);
            this.Controls.Add(this.lbl_falling);
            this.Controls.Add(this.lbl_jumping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameObject_Player);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ActualGame";
            this.Text = "FlappyBird Recreated";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GameObject_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownColumn_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpColumn_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trolololo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox GameObject_Player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_jumping;
        private System.Windows.Forms.Label lbl_falling;
        private System.Windows.Forms.Timer gameSpeedTimer;
        private System.Windows.Forms.PictureBox DownColumn_1;
        private System.Windows.Forms.PictureBox DownColumn_2;
        private System.Windows.Forms.PictureBox UpColumn_1;
        private System.Windows.Forms.PictureBox UpColumn_2;
        private System.Windows.Forms.Label lbl_death;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_bckMain;
        private System.Windows.Forms.PictureBox DownColumn_3;
        private System.Windows.Forms.PictureBox UpColumn_3;
        private System.Windows.Forms.PictureBox trolololo;
    }
}

