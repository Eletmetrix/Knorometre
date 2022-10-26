
namespace Knorometre
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
            this.components = new System.ComponentModel.Container();
            this.TurSayac = new System.Windows.Forms.Label();
            this.GenelSayac = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.TurListesi = new System.Windows.Forms.ListView();
            this.TurSayi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurSure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TamSure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurSayac
            // 
            this.TurSayac.Dock = System.Windows.Forms.DockStyle.Top;
            this.TurSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurSayac.Location = new System.Drawing.Point(0, 0);
            this.TurSayac.Margin = new System.Windows.Forms.Padding(7, 0, 63, 0);
            this.TurSayac.Name = "TurSayac";
            this.TurSayac.Size = new System.Drawing.Size(514, 78);
            this.TurSayac.TabIndex = 0;
            this.TurSayac.Text = "00:00:00.00";
            this.TurSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenelSayac
            // 
            this.GenelSayac.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenelSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenelSayac.Location = new System.Drawing.Point(0, 78);
            this.GenelSayac.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.GenelSayac.Name = "GenelSayac";
            this.GenelSayac.Size = new System.Drawing.Size(514, 34);
            this.GenelSayac.TabIndex = 1;
            this.GenelSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn2);
            this.groupBox1.Controls.Add(this.Btn1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(514, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.White;
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn2.Enabled = false;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn2.Location = new System.Drawing.Point(302, 30);
            this.Btn2.Margin = new System.Windows.Forms.Padding(2);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(210, 57);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Tur";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.White;
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn1.Location = new System.Drawing.Point(2, 30);
            this.Btn1.Margin = new System.Windows.Forms.Padding(2);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(210, 57);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Başla";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // TurListesi
            // 
            this.TurListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TurSayi,
            this.TurSure,
            this.TamSure});
            this.TurListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurListesi.FullRowSelect = true;
            this.TurListesi.GridLines = true;
            this.TurListesi.HideSelection = false;
            this.TurListesi.Location = new System.Drawing.Point(0, 112);
            this.TurListesi.Margin = new System.Windows.Forms.Padding(2);
            this.TurListesi.Name = "TurListesi";
            this.TurListesi.Size = new System.Drawing.Size(514, 200);
            this.TurListesi.TabIndex = 3;
            this.TurListesi.UseCompatibleStateImageBehavior = false;
            this.TurListesi.View = System.Windows.Forms.View.Details;
            this.TurListesi.Visible = false;
            // 
            // TurSayi
            // 
            this.TurSayi.Text = "Tur Sayısı";
            this.TurSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TurSayi.Width = 110;
            // 
            // TurSure
            // 
            this.TurSure.Text = "Tur Süresi";
            this.TurSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TurSure.Width = 200;
            // 
            // TamSure
            // 
            this.TamSure.Text = "Geçen Süre";
            this.TamSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TamSure.Width = 200;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 401);
            this.Controls.Add(this.TurListesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenelSayac);
            this.Controls.Add(this.TurSayac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(530, 440);
            this.Name = "Form1";
            this.Text = "Knorometre";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TurSayac;
        private System.Windows.Forms.Label GenelSayac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.ListView TurListesi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader TurSayi;
        private System.Windows.Forms.ColumnHeader TurSure;
        private System.Windows.Forms.ColumnHeader TamSure;
    }
}

