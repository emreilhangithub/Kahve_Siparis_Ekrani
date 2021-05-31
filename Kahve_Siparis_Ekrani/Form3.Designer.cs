
namespace Kahve_Siparis_Ekrani
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sipIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sipAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sipTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sipAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sipTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kahveSiparisDataSet3 = new Kahve_Siparis_Ekrani.KahveSiparisDataSet3();
            this.kahveSiparisDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kahveSiparisDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kahveSiparisDataSet1 = new Kahve_Siparis_Ekrani.KahveSiparisDataSet1();
            this.kahveSiparisDataSet2 = new Kahve_Siparis_Ekrani.KahveSiparisDataSet2();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Kahve_Siparis_Ekrani.KahveSiparisDataSet2TableAdapters.ordersTableAdapter();
            this.ordersTableAdapter1 = new Kahve_Siparis_Ekrani.KahveSiparisDataSet3TableAdapters.ordersTableAdapter();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 35);
            this.panel2.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerimToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişlerimToolStripMenuItem
            // 
            this.siparişlerimToolStripMenuItem.Name = "siparişlerimToolStripMenuItem";
            this.siparişlerimToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.siparişlerimToolStripMenuItem.Text = "Siparişler";
            this.siparişlerimToolStripMenuItem.Click += new System.EventHandler(this.siparişlerimToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 100);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kahve Evi Siparişler Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(796, 542);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparişler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sipIdDataGridViewTextBoxColumn,
            this.sipAdSoyadDataGridViewTextBoxColumn,
            this.sipTelNoDataGridViewTextBoxColumn,
            this.sipAdresDataGridViewTextBoxColumn,
            this.sipTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(788, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // sipIdDataGridViewTextBoxColumn
            // 
            this.sipIdDataGridViewTextBoxColumn.DataPropertyName = "SipId";
            this.sipIdDataGridViewTextBoxColumn.HeaderText = "SipId";
            this.sipIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sipIdDataGridViewTextBoxColumn.Name = "sipIdDataGridViewTextBoxColumn";
            this.sipIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sipIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // sipAdSoyadDataGridViewTextBoxColumn
            // 
            this.sipAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "SipAdSoyad";
            this.sipAdSoyadDataGridViewTextBoxColumn.HeaderText = "SipAdSoyad";
            this.sipAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sipAdSoyadDataGridViewTextBoxColumn.Name = "sipAdSoyadDataGridViewTextBoxColumn";
            this.sipAdSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // sipTelNoDataGridViewTextBoxColumn
            // 
            this.sipTelNoDataGridViewTextBoxColumn.DataPropertyName = "SipTelNo";
            this.sipTelNoDataGridViewTextBoxColumn.HeaderText = "SipTelNo";
            this.sipTelNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sipTelNoDataGridViewTextBoxColumn.Name = "sipTelNoDataGridViewTextBoxColumn";
            this.sipTelNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // sipAdresDataGridViewTextBoxColumn
            // 
            this.sipAdresDataGridViewTextBoxColumn.DataPropertyName = "SipAdres";
            this.sipAdresDataGridViewTextBoxColumn.HeaderText = "SipAdres";
            this.sipAdresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sipAdresDataGridViewTextBoxColumn.Name = "sipAdresDataGridViewTextBoxColumn";
            this.sipAdresDataGridViewTextBoxColumn.Width = 150;
            // 
            // sipTutarDataGridViewTextBoxColumn
            // 
            this.sipTutarDataGridViewTextBoxColumn.DataPropertyName = "SipTutar";
            this.sipTutarDataGridViewTextBoxColumn.HeaderText = "SipTutar";
            this.sipTutarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sipTutarDataGridViewTextBoxColumn.Name = "sipTutarDataGridViewTextBoxColumn";
            this.sipTutarDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.kahveSiparisDataSet3;
            // 
            // kahveSiparisDataSet3
            // 
            this.kahveSiparisDataSet3.DataSetName = "KahveSiparisDataSet3";
            this.kahveSiparisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kahveSiparisDataSet1BindingSource
            // 
            this.kahveSiparisDataSet1BindingSource.DataSource = this.kahveSiparisDataSet1;
            this.kahveSiparisDataSet1BindingSource.Position = 0;
            // 
            // kahveSiparisDataSet1
            // 
            this.kahveSiparisDataSet1.DataSetName = "KahveSiparisDataSet1";
            this.kahveSiparisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kahveSiparisDataSet2
            // 
            this.kahveSiparisDataSet2.DataSetName = "KahveSiparisDataSet2";
            this.kahveSiparisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.kahveSiparisDataSet2;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Sipariş Sayfası";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kahveSiparisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kahveSiparisDataSet1BindingSource;
        private KahveSiparisDataSet1 kahveSiparisDataSet1;
        private System.Windows.Forms.BindingSource kahveSiparisDataSet2BindingSource;
        private KahveSiparisDataSet2 kahveSiparisDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private KahveSiparisDataSet2TableAdapters.ordersTableAdapter ordersTableAdapter;
        private KahveSiparisDataSet3 kahveSiparisDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private KahveSiparisDataSet3TableAdapters.ordersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipTutarDataGridViewTextBoxColumn;
        //private KahveSiparisDataSet2 kahveSiparisDataSet2;
    }
}