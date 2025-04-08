namespace HangingManApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblKelime = new Label();
            txtHarf = new TextBox();
            btnTahmin = new Button();
            lblCan = new Label();
            picAdam = new PictureBox();
            lblMesaj = new Label();
            btnYeniden = new Button();
            ((System.ComponentModel.ISupportInitialize)picAdam).BeginInit();
            SuspendLayout();
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Location = new Point(601, 30);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(49, 15);
            lblKelime.TabIndex = 0;
            lblKelime.Text = "Kelime: ";
            // 
            // txtHarf
            // 
            txtHarf.Location = new Point(274, 415);
            txtHarf.Name = "txtHarf";
            txtHarf.Size = new Size(109, 23);
            txtHarf.TabIndex = 1;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(405, 412);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(114, 26);
            btnTahmin.TabIndex = 2;
            btnTahmin.Text = "Make a Guess";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(601, 67);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(40, 15);
            lblCan.TabIndex = 3;
            lblCan.Text = "Can: 6";
            // 
            // picAdam
            // 
            picAdam.Image = (Image)resources.GetObject("picAdam.Image");
            picAdam.Location = new Point(47, 44);
            picAdam.Name = "picAdam";
            picAdam.Size = new Size(171, 287);
            picAdam.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdam.TabIndex = 4;
            picAdam.TabStop = false;
            picAdam.Click += picAdam_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(264, 44);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 5;
            lblMesaj.Text = "label1";
            // 
            // btnYeniden
            // 
            btnYeniden.Location = new Point(659, 411);
            btnYeniden.Name = "btnYeniden";
            btnYeniden.Size = new Size(115, 27);
            btnYeniden.TabIndex = 6;
            btnYeniden.Text = "Try Again";
            btnYeniden.UseVisualStyleBackColor = true;
            btnYeniden.Click += btnYeniden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYeniden);
            Controls.Add(lblMesaj);
            Controls.Add(picAdam);
            Controls.Add(lblCan);
            Controls.Add(btnTahmin);
            Controls.Add(txtHarf);
            Controls.Add(lblKelime);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAdam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKelime;
        private TextBox txtHarf;
        private Button btnTahmin;
        private Label lblCan;
        private PictureBox picAdam;
        private Label lblMesaj;
        private Button btnYeniden;
    }
}
