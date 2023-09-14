namespace Sapiens
{
    partial class Play
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
            this.components = new System.ComponentModel.Container();
            this.QuiestionTrivia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTrivia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.valueTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numberCorrect = new System.Windows.Forms.Label();
            this.btnTrivia3 = new System.Windows.Forms.Button();
            this.btnTrivia1 = new System.Windows.Forms.Button();
            this.btnTrivia2 = new System.Windows.Forms.Button();
            this.imageTrivia = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTrivia)).BeginInit();
            this.SuspendLayout();
            // 
            // QuiestionTrivia
            // 
            this.QuiestionTrivia.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuiestionTrivia.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuiestionTrivia.ForeColor = System.Drawing.Color.White;
            this.QuiestionTrivia.Location = new System.Drawing.Point(0, 200);
            this.QuiestionTrivia.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.QuiestionTrivia.Name = "QuiestionTrivia";
            this.QuiestionTrivia.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.QuiestionTrivia.Size = new System.Drawing.Size(550, 146);
            this.QuiestionTrivia.TabIndex = 5;
            this.QuiestionTrivia.Text = "Trivia para Donato Silva:\r\n¿Que animal es el unico oso nativo de Sudamerica?";
            this.QuiestionTrivia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Sapiens.Properties.Resources.banner_2_180;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 808);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 92);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.numberTrivia);
            this.panel4.Location = new System.Drawing.Point(46, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 74);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° Trivia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTrivia
            // 
            this.numberTrivia.AllowDrop = true;
            this.numberTrivia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.numberTrivia.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberTrivia.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTrivia.ForeColor = System.Drawing.Color.White;
            this.numberTrivia.Location = new System.Drawing.Point(0, 0);
            this.numberTrivia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberTrivia.Name = "numberTrivia";
            this.numberTrivia.Size = new System.Drawing.Size(131, 46);
            this.numberTrivia.TabIndex = 2;
            this.numberTrivia.Text = "1";
            this.numberTrivia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.valueTime);
            this.panel1.Location = new System.Drawing.Point(195, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 74);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Segundos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueTime
            // 
            this.valueTime.AllowDrop = true;
            this.valueTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.valueTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.valueTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTime.ForeColor = System.Drawing.Color.White;
            this.valueTime.Location = new System.Drawing.Point(0, 0);
            this.valueTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueTime.Name = "valueTime";
            this.valueTime.Size = new System.Drawing.Size(148, 46);
            this.valueTime.TabIndex = 2;
            this.valueTime.Text = "30";
            this.valueTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numberCorrect);
            this.panel3.Location = new System.Drawing.Point(361, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 74);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correctas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberCorrect
            // 
            this.numberCorrect.AllowDrop = true;
            this.numberCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.numberCorrect.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberCorrect.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCorrect.ForeColor = System.Drawing.Color.White;
            this.numberCorrect.Location = new System.Drawing.Point(0, 0);
            this.numberCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberCorrect.Name = "numberCorrect";
            this.numberCorrect.Size = new System.Drawing.Size(138, 46);
            this.numberCorrect.TabIndex = 2;
            this.numberCorrect.Text = "0";
            this.numberCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrivia3
            // 
            this.btnTrivia3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrivia3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnTrivia3.BackgroundImage = global::Sapiens.Properties.Resources.btnNaranja;
            this.btnTrivia3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrivia3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrivia3.FlatAppearance.BorderSize = 0;
            this.btnTrivia3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrivia3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrivia3.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrivia3.Location = new System.Drawing.Point(143, 582);
            this.btnTrivia3.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnTrivia3.Name = "btnTrivia3";
            this.btnTrivia3.Size = new System.Drawing.Size(257, 40);
            this.btnTrivia3.TabIndex = 8;
            this.btnTrivia3.Text = "Oso de anteojos";
            this.btnTrivia3.UseVisualStyleBackColor = false;
            this.btnTrivia3.Click += new System.EventHandler(this.btnTrivia3_Click);
            // 
            // btnTrivia1
            // 
            this.btnTrivia1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrivia1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnTrivia1.BackgroundImage = global::Sapiens.Properties.Resources.btnNaranja;
            this.btnTrivia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrivia1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrivia1.FlatAppearance.BorderSize = 0;
            this.btnTrivia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrivia1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrivia1.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrivia1.Location = new System.Drawing.Point(143, 462);
            this.btnTrivia1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnTrivia1.Name = "btnTrivia1";
            this.btnTrivia1.Size = new System.Drawing.Size(257, 40);
            this.btnTrivia1.TabIndex = 7;
            this.btnTrivia1.Text = "Oso pardo";
            this.btnTrivia1.UseVisualStyleBackColor = false;
            this.btnTrivia1.Click += new System.EventHandler(this.btnTrivia1_Click);
            // 
            // btnTrivia2
            // 
            this.btnTrivia2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrivia2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnTrivia2.BackgroundImage = global::Sapiens.Properties.Resources.btnNaranja;
            this.btnTrivia2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrivia2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrivia2.FlatAppearance.BorderSize = 0;
            this.btnTrivia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrivia2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrivia2.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrivia2.Location = new System.Drawing.Point(143, 522);
            this.btnTrivia2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnTrivia2.Name = "btnTrivia2";
            this.btnTrivia2.Size = new System.Drawing.Size(257, 40);
            this.btnTrivia2.TabIndex = 6;
            this.btnTrivia2.Text = "Oso polar";
            this.btnTrivia2.UseVisualStyleBackColor = false;
            this.btnTrivia2.Click += new System.EventHandler(this.btnTrivia2_Click);
            // 
            // imageTrivia
            // 
            this.imageTrivia.BackColor = System.Drawing.Color.Black;
            this.imageTrivia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageTrivia.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageTrivia.Image = global::Sapiens.Properties.Resources.OsoAnteojos;
            this.imageTrivia.Location = new System.Drawing.Point(0, 0);
            this.imageTrivia.Margin = new System.Windows.Forms.Padding(4);
            this.imageTrivia.Name = "imageTrivia";
            this.imageTrivia.Size = new System.Drawing.Size(550, 200);
            this.imageTrivia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageTrivia.TabIndex = 4;
            this.imageTrivia.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTrivia3);
            this.Controls.Add(this.btnTrivia1);
            this.Controls.Add(this.btnTrivia2);
            this.Controls.Add(this.QuiestionTrivia);
            this.Controls.Add(this.imageTrivia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageTrivia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label valueTime;
        private System.Windows.Forms.PictureBox imageTrivia;
        private System.Windows.Forms.Label QuiestionTrivia;
        private System.Windows.Forms.Button btnTrivia2;
        private System.Windows.Forms.Button btnTrivia1;
        private System.Windows.Forms.Button btnTrivia3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberCorrect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberTrivia;
        private System.Windows.Forms.Timer timer1;
    }
}