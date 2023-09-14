namespace Sapiens
{
    partial class endPlay
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
            this.textTitleMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowIndex = new System.Windows.Forms.Button();
            this.btnNewPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLabelResult = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.Label();
            this.imageResult = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitleMessage
            // 
            this.textTitleMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTitleMessage.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitleMessage.ForeColor = System.Drawing.Color.White;
            this.textTitleMessage.Location = new System.Drawing.Point(0, 0);
            this.textTitleMessage.Name = "textTitleMessage";
            this.textTitleMessage.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.textTitleMessage.Size = new System.Drawing.Size(550, 216);
            this.textTitleMessage.TabIndex = 3;
            this.textTitleMessage.Text = "Ganaste Donato Silva, pasaste la trivia Perezoso Sapiens";
            this.textTitleMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowIndex);
            this.panel1.Controls.Add(this.btnNewPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 815);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 85);
            this.panel1.TabIndex = 4;
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
            this.btnShowIndex.Click += new System.EventHandler(this.btnShowIndex_Click);
            // 
            // btnNewPlay
            // 
            this.btnNewPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPlay.BackgroundImage = global::Sapiens.Properties.Resources.btnAzul;
            this.btnNewPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPlay.FlatAppearance.BorderSize = 0;
            this.btnNewPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlay.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlay.ForeColor = System.Drawing.Color.White;
            this.btnNewPlay.Location = new System.Drawing.Point(355, 3);
            this.btnNewPlay.Margin = new System.Windows.Forms.Padding(16);
            this.btnNewPlay.Name = "btnNewPlay";
            this.btnNewPlay.Size = new System.Drawing.Size(170, 60);
            this.btnNewPlay.TabIndex = 0;
            this.btnNewPlay.Text = "Jugar";
            this.btnNewPlay.UseVisualStyleBackColor = true;
            this.btnNewPlay.Click += new System.EventHandler(this.btnNewPlay_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Que vas a hacer a continuación?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabelResult
            // 
            this.textLabelResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.textLabelResult.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabelResult.ForeColor = System.Drawing.Color.White;
            this.textLabelResult.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.textLabelResult.Location = new System.Drawing.Point(0, 216);
            this.textLabelResult.Name = "textLabelResult";
            this.textLabelResult.Padding = new System.Windows.Forms.Padding(8);
            this.textLabelResult.Size = new System.Drawing.Size(550, 53);
            this.textLabelResult.TabIndex = 8;
            this.textLabelResult.Text = "Resumen de la trivia:\r\n";
            this.textLabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textResult
            // 
            this.textResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.textResult.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.Color.White;
            this.textResult.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.textResult.Location = new System.Drawing.Point(0, 269);
            this.textResult.Name = "textResult";
            this.textResult.Padding = new System.Windows.Forms.Padding(26, 8, 8, 8);
            this.textResult.Size = new System.Drawing.Size(550, 103);
            this.textResult.TabIndex = 9;
            this.textResult.Text = "Total correctas: 0\r\nTotal Incorrectas: 0\r\nTotal Trivias: 0\r\n";
            this.textResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageResult
            // 
            this.imageResult.Image = global::Sapiens.Properties.Resources.ranuraFeliz2;
            this.imageResult.Location = new System.Drawing.Point(0, 378);
            this.imageResult.Margin = new System.Windows.Forms.Padding(16);
            this.imageResult.Name = "imageResult";
            this.imageResult.Size = new System.Drawing.Size(550, 343);
            this.imageResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageResult.TabIndex = 6;
            this.imageResult.TabStop = false;
            // 
            // endPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(550, 900);
            this.ControlBox = false;
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textLabelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textTitleMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "endPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "endPlay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textTitleMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowIndex;
        private System.Windows.Forms.Button btnNewPlay;
        private System.Windows.Forms.PictureBox imageResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textLabelResult;
        private System.Windows.Forms.Label textResult;
    }
}