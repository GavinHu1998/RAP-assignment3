namespace TradingCardsA3
{
    partial class Form1
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
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.buttonViewCard = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelStat1 = new System.Windows.Forms.Label();
            this.labelStat2 = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Location = new System.Drawing.Point(431, 549);
            this.buttonAddCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(120, 45);
            this.buttonAddCard.TabIndex = 0;
            this.buttonAddCard.Text = "Add Card";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // buttonViewCard
            // 
            this.buttonViewCard.Location = new System.Drawing.Point(672, 549);
            this.buttonViewCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewCard.Name = "buttonViewCard";
            this.buttonViewCard.Size = new System.Drawing.Size(120, 45);
            this.buttonViewCard.TabIndex = 1;
            this.buttonViewCard.Text = "Delete";
            this.buttonViewCard.UseVisualStyleBackColor = true;
            this.buttonViewCard.Click += new System.EventHandler(this.buttonViewCard_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(55, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 544);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 276);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(426, 420);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTeam.Location = new System.Drawing.Point(636, 420);
            this.labelTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(64, 25);
            this.labelTeam.TabIndex = 5;
            this.labelTeam.Text = "Team";
            // 
            // labelStat1
            // 
            this.labelStat1.AutoSize = true;
            this.labelStat1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStat1.Location = new System.Drawing.Point(426, 479);
            this.labelStat1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStat1.Name = "labelStat1";
            this.labelStat1.Size = new System.Drawing.Size(90, 25);
            this.labelStat1.TabIndex = 6;
            this.labelStat1.Text = "Stat 1";
            this.labelStat1.Click += new System.EventHandler(this.labelStat1_Click);
            // 
            // labelStat2
            // 
            this.labelStat2.AutoSize = true;
            this.labelStat2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStat2.Location = new System.Drawing.Point(636, 479);
            this.labelStat2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStat2.Name = "labelStat2";
            this.labelStat2.Size = new System.Drawing.Size(90, 25);
            this.labelStat2.TabIndex = 7;
            this.labelStat2.Text = "Stat 2";
            this.labelStat2.Click += new System.EventHandler(this.labelStat2_Click);
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Location = new System.Drawing.Point(431, 50);
            this.panelCard.Margin = new System.Windows.Forms.Padding(2);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(367, 336);
            this.panelCard.TabIndex = 8;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 650);
            this.Controls.Add(this.buttonViewCard);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.labelStat2);
            this.Controls.Add(this.labelStat1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTeam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Button buttonViewCard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelStat1;
        private System.Windows.Forms.Label labelStat2;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

