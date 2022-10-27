namespace BookClient
{
    partial class FrmPerfume
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
            this.dgv_perfume = new System.Windows.Forms.DataGridView();
            this.lbl_text1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfume)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_perfume
            // 
            this.dgv_perfume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfume.Location = new System.Drawing.Point(31, 64);
            this.dgv_perfume.Name = "dgv_perfume";
            this.dgv_perfume.RowHeadersWidth = 51;
            this.dgv_perfume.RowTemplate.Height = 24;
            this.dgv_perfume.Size = new System.Drawing.Size(751, 198);
            this.dgv_perfume.TabIndex = 0;
            this.dgv_perfume.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_perfume_CellClick);
            this.dgv_perfume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_perfume_CellContentClick);
            this.dgv_perfume.SelectionChanged += new System.EventHandler(this.dgv_perfume_SelectionChanged);
            // 
            // lbl_text1
            // 
            this.lbl_text1.AutoSize = true;
            this.lbl_text1.Location = new System.Drawing.Point(28, 29);
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Size = new System.Drawing.Size(65, 16);
            this.lbl_text1.TabIndex = 1;
            this.lbl_text1.Text = "Keyword :";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(99, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(491, 22);
            this.txt_search.TabIndex = 2;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(606, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(70, 28);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(477, 314);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 39);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(120, 289);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(321, 22);
            this.txtid.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(49, 292);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 16);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Id :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(120, 331);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(321, 22);
            this.txtname.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(49, 334);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name :";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(120, 375);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(321, 22);
            this.txtbrand.TabIndex = 11;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(49, 378);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(49, 16);
            this.lbl_brand.TabIndex = 10;
            this.lbl_brand.Text = "Brand :";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(120, 418);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(321, 22);
            this.txtorigin.TabIndex = 14;
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Location = new System.Drawing.Point(49, 421);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(48, 16);
            this.lbl_origin.TabIndex = 13;
            this.lbl_origin.Text = "Origin :";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(477, 367);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 39);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(477, 421);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 39);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(120, 462);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(321, 22);
            this.txtprice.TabIndex = 18;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(49, 465);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(44, 16);
            this.lbl_price.TabIndex = 17;
            this.lbl_price.Text = "Price :";
            // 
            // FrmPerfume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.lbl_origin);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_text1);
            this.Controls.Add(this.dgv_perfume);
            this.Name = "FrmPerfume";
            this.Text = "Frm_Perfume";
            this.Load += new System.EventHandler(this.FrmPerfume_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_perfume;
        private System.Windows.Forms.Label lbl_text1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lbl_price;
    }
}

