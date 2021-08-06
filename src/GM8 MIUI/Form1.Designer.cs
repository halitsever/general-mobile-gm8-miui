
namespace GM8_MIUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleDeviceRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.dualDeviceRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // singleDeviceRadioButton
            // 
            this.singleDeviceRadioButton.AutoSize = true;
            this.singleDeviceRadioButton.Depth = 0;
            this.singleDeviceRadioButton.Location = new System.Drawing.Point(413, 182);
            this.singleDeviceRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.singleDeviceRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.singleDeviceRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.singleDeviceRadioButton.Name = "singleDeviceRadioButton";
            this.singleDeviceRadioButton.Ripple = true;
            this.singleDeviceRadioButton.Size = new System.Drawing.Size(79, 37);
            this.singleDeviceRadioButton.TabIndex = 1;
            this.singleDeviceRadioButton.TabStop = true;
            this.singleDeviceRadioButton.Text = "Single";
            this.singleDeviceRadioButton.UseVisualStyleBackColor = true;
            // 
            // dualDeviceRadioButton
            // 
            this.dualDeviceRadioButton.AutoSize = true;
            this.dualDeviceRadioButton.Depth = 0;
            this.dualDeviceRadioButton.Location = new System.Drawing.Point(413, 241);
            this.dualDeviceRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.dualDeviceRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dualDeviceRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dualDeviceRadioButton.Name = "dualDeviceRadioButton";
            this.dualDeviceRadioButton.Ripple = true;
            this.dualDeviceRadioButton.Size = new System.Drawing.Size(68, 37);
            this.dualDeviceRadioButton.TabIndex = 2;
            this.dualDeviceRadioButton.TabStop = true;
            this.dualDeviceRadioButton.Text = "Dual";
            this.dualDeviceRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(413, 323);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(114, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "INSTALL MIUI";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(410, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(33, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "SIM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 494);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.dualDeviceRadioButton);
            this.Controls.Add(this.singleDeviceRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GM8 MIUI Installer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRadioButton singleDeviceRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton dualDeviceRadioButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

