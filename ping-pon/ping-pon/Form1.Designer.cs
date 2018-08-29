namespace ping_pon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.p2score = new System.Windows.Forms.Label();
            this.p1score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(395, 175);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(12, 12);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.Location = new System.Drawing.Point(298, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(66, 10);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.player1.Location = new System.Drawing.Point(298, 371);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(66, 10);
            this.player1.TabIndex = 2;
            this.player1.TabStop = false;
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.BackColor = System.Drawing.Color.Transparent;
            this.p2score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2score.ForeColor = System.Drawing.Color.Black;
            this.p2score.Location = new System.Drawing.Point(3, 0);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(36, 37);
            this.p2score.TabIndex = 3;
            this.p2score.Text = "0";
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.BackColor = System.Drawing.Color.Transparent;
            this.p1score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1score.ForeColor = System.Drawing.Color.Black;
            this.p1score.Location = new System.Drawing.Point(3, 335);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(36, 37);
            this.p1score.TabIndex = 4;
            this.p1score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(-4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador 2\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(-4, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jugador 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ping_pon.Properties.Resources.Sin_títuuulolo;
            this.ClientSize = new System.Drawing.Size(753, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.ball);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

