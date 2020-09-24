namespace Porjeto_Final
{
    partial class FrmRanking
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdVoltarJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(149, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmdVoltarJogo
            // 
            this.cmdVoltarJogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVoltarJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVoltarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltarJogo.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdVoltarJogo.Location = new System.Drawing.Point(249, 265);
            this.cmdVoltarJogo.Name = "cmdVoltarJogo";
            this.cmdVoltarJogo.Size = new System.Drawing.Size(107, 37);
            this.cmdVoltarJogo.TabIndex = 23;
            this.cmdVoltarJogo.Text = "Voltar";
            this.cmdVoltarJogo.UseVisualStyleBackColor = false;
            this.cmdVoltarJogo.Click += new System.EventHandler(this.cmdVoltarJogo_Click);
            // 
            // FrmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Porjeto_Final.Properties.Resources._240_F_345880772_zIT2mkdCzTthplO7xqaGGrMspN0jw0ll;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 338);
            this.Controls.Add(this.cmdVoltarJogo);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.FrmRanking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdVoltarJogo;
    }
}