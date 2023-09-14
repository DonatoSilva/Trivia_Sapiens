namespace Sapiens
{
    partial class opcIncorrect
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textTitleMessage = new System.Windows.Forms.Label();
            this.btnShowIndex = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.textTextMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sapiens.Properties.Resources.ranuraAsustado;
            this.pictureBox1.Location = new System.Drawing.Point(0, 358);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textTitleMessage
            // 
            this.textTitleMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTitleMessage.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitleMessage.ForeColor = System.Drawing.Color.White;
            this.textTitleMessage.Location = new System.Drawing.Point(0, 0);
            this.textTitleMessage.Name = "textTitleMessage";
            this.textTitleMessage.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.textTitleMessage.Size = new System.Drawing.Size(550, 175);
            this.textTitleMessage.TabIndex = 1;
            this.textTitleMessage.Text = "!Nooooo!, que paso Donato silva";
            this.textTitleMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowIndex
            // 
            this.btnShowIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowIndex.BackgroundImage = global::Sapiens.Properties.Resources.btnAzul;
            this.btnShowIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowIndex.FlatAppearance.BorderSize = 0;
            this.btnShowIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowIndex.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowIndex.ForeColor = System.Drawing.Color.White;
            this.btnShowIndex.Location = new System.Drawing.Point(25, 3);
            this.btnShowIndex.Margin = new System.Windows.Forms.Padding(16);
            this.btnShowIndex.Name = "btnShowIndex";
            this.btnShowIndex.Size = new System.Drawing.Size(170, 60);
            this.btnShowIndex.TabIndex = 1;
            this.btnShowIndex.Text = "Inicio";
            this.btnShowIndex.UseVisualStyleBackColor = true;
            this.btnShowIndex.Click += new System.EventHandler(this.BtnShowIndex_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextQuestion.BackgroundImage = global::Sapiens.Properties.Resources.btnAzul;
            this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.FlatAppearance.BorderSize = 0;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
            this.btnNextQuestion.Location = new System.Drawing.Point(355, 3);
            this.btnNextQuestion.Margin = new System.Windows.Forms.Padding(16);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(170, 60);
            this.btnNextQuestion.TabIndex = 0;
            this.btnNextQuestion.Text = "Siguiente";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // textTextMessage
            // 
            this.textTextMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTextMessage.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTextMessage.ForeColor = System.Drawing.Color.White;
            this.textTextMessage.Location = new System.Drawing.Point(0, 175);
            this.textTextMessage.Name = "textTextMessage";
            this.textTextMessage.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.textTextMessage.Size = new System.Drawing.Size(550, 96);
            this.textTextMessage.TabIndex = 3;
            this.textTextMessage.Text = "¡Oops! Respuesta incorrecta. Intenta de nuevo.";
            this.textTextMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Que vas a hacer a continuación?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowIndex);
            this.panel1.Controls.Add(this.btnNextQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 815);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 85);
            this.panel1.TabIndex = 2;
            // 
            // opcIncorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(550, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTextMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textTitleMessage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcIncorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "opcIncorrect";
            this.Load += new System.EventHandler(this.opcIncorrect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textTitleMessage;
        private System.Windows.Forms.Label textTextMessage;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnShowIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}