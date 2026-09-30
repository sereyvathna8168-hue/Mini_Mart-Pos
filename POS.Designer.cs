namespace Mini_Mart_Pos
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProductList = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblCartSummary = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.btnSkincare = new System.Windows.Forms.Button();
            this.btnBentoBox = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnMeat = new System.Windows.Forms.Button();
            this.btnCookie = new System.Windows.Forms.Button();
            this.btnEggs = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnSoda = new System.Windows.Forms.Button();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.Location = new System.Drawing.Point(40, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Main product search...";
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnProductList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.Location = new System.Drawing.Point(420, 20);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(150, 40);
            this.btnProductList.TabIndex = 2;
            this.btnProductList.Text = "Product Add/ List";
            this.btnProductList.UseVisualStyleBackColor = false;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colQty,
            this.colPrice,
            this.colTotal});
            this.dgvCart.Location = new System.Drawing.Point(10, 10);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(480, 190);
            this.dgvCart.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnVoid);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.dgvCart);
            this.panel4.Location = new System.Drawing.Point(750, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 280);
            this.panel4.TabIndex = 4;
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(160, 220);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(150, 40);
            this.btnVoid.TabIndex = 5;
            this.btnVoid.Text = "VOID SALE";
            this.btnVoid.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(20, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR ALL";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCompleteSale);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblTax);
            this.panel3.Controls.Add(this.lblSubtotal);
            this.panel3.Controls.Add(this.lblCartSummary);
            this.panel3.Location = new System.Drawing.Point(750, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 200);
            this.panel3.TabIndex = 5;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(15, 145);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(450, 35);
            this.btnCompleteSale.TabIndex = 6;
            this.btnCompleteSale.Text = "COMPLETE SALE";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "TOTAL:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(15, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 1);
            this.panel5.TabIndex = 3;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(15, 80);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(36, 20);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(15, 50);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 20);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblCartSummary
            // 
            this.lblCartSummary.AutoSize = true;
            this.lblCartSummary.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartSummary.Location = new System.Drawing.Point(15, 15);
            this.lblCartSummary.Name = "lblCartSummary";
            this.lblCartSummary.Size = new System.Drawing.Size(134, 25);
            this.lblCartSummary.TabIndex = 0;
            this.lblCartSummary.Text = "Cart Summary";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnPOS);
            this.panel6.Controls.Add(this.btnDashboard);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 661);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1348, 60);
            this.panel6.TabIndex = 8;
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPOS.Location = new System.Drawing.Point(473, 3);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(80, 50);
            this.btnPOS.TabIndex = 6;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPOS.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashboard.Location = new System.Drawing.Point(647, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(103, 50);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVegetables, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSkincare, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBentoBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFastFood, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMeat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCookie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEggs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMilk, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCoca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSoda, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(303, 269);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 120);
            this.button11.TabIndex = 29;
            this.button11.Text = "Snacks";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnVegetables
            // 
            this.btnVegetables.AutoSize = true;
            this.btnVegetables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVegetables.Image = ((System.Drawing.Image)(resources.GetObject("btnVegetables.Image")));
            this.btnVegetables.Location = new System.Drawing.Point(153, 269);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(120, 120);
            this.btnVegetables.TabIndex = 28;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVegetables.UseVisualStyleBackColor = true;
            // 
            // btnSkincare
            // 
            this.btnSkincare.AutoSize = true;
            this.btnSkincare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkincare.Image = ((System.Drawing.Image)(resources.GetObject("btnSkincare.Image")));
            this.btnSkincare.Location = new System.Drawing.Point(3, 269);
            this.btnSkincare.Name = "btnSkincare";
            this.btnSkincare.Size = new System.Drawing.Size(120, 120);
            this.btnSkincare.TabIndex = 27;
            this.btnSkincare.Text = "Skincare";
            this.btnSkincare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSkincare.UseVisualStyleBackColor = true;
            // 
            // btnBentoBox
            // 
            this.btnBentoBox.AutoSize = true;
            this.btnBentoBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBentoBox.Image = ((System.Drawing.Image)(resources.GetObject("btnBentoBox.Image")));
            this.btnBentoBox.Location = new System.Drawing.Point(453, 136);
            this.btnBentoBox.Name = "btnBentoBox";
            this.btnBentoBox.Size = new System.Drawing.Size(120, 120);
            this.btnBentoBox.TabIndex = 26;
            this.btnBentoBox.Text = "Bento Box";
            this.btnBentoBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBentoBox.UseVisualStyleBackColor = true;
            // 
            // btnFastFood
            // 
            this.btnFastFood.AutoSize = true;
            this.btnFastFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFastFood.Image")));
            this.btnFastFood.Location = new System.Drawing.Point(303, 136);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(120, 120);
            this.btnFastFood.TabIndex = 25;
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFastFood.UseVisualStyleBackColor = true;
            // 
            // btnMeat
            // 
            this.btnMeat.AutoSize = true;
            this.btnMeat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeat.Image = ((System.Drawing.Image)(resources.GetObject("btnMeat.Image")));
            this.btnMeat.Location = new System.Drawing.Point(153, 136);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(120, 120);
            this.btnMeat.TabIndex = 24;
            this.btnMeat.Text = "Meat";
            this.btnMeat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeat.UseVisualStyleBackColor = true;
            // 
            // btnCookie
            // 
            this.btnCookie.AutoSize = true;
            this.btnCookie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookie.Image = ((System.Drawing.Image)(resources.GetObject("btnCookie.Image")));
            this.btnCookie.Location = new System.Drawing.Point(3, 136);
            this.btnCookie.Name = "btnCookie";
            this.btnCookie.Size = new System.Drawing.Size(120, 120);
            this.btnCookie.TabIndex = 23;
            this.btnCookie.Text = "Cookie";
            this.btnCookie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCookie.UseVisualStyleBackColor = true;
            // 
            // btnEggs
            // 
            this.btnEggs.AutoSize = true;
            this.btnEggs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEggs.Image = ((System.Drawing.Image)(resources.GetObject("btnEggs.Image")));
            this.btnEggs.Location = new System.Drawing.Point(453, 3);
            this.btnEggs.Name = "btnEggs";
            this.btnEggs.Size = new System.Drawing.Size(120, 120);
            this.btnEggs.TabIndex = 22;
            this.btnEggs.Text = "Eggs";
            this.btnEggs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEggs.UseVisualStyleBackColor = true;
            // 
            // btnMilk
            // 
            this.btnMilk.AutoSize = true;
            this.btnMilk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilk.Image = ((System.Drawing.Image)(resources.GetObject("btnMilk.Image")));
            this.btnMilk.Location = new System.Drawing.Point(303, 3);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(120, 120);
            this.btnMilk.TabIndex = 21;
            this.btnMilk.Text = "Milk";
            this.btnMilk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMilk.UseVisualStyleBackColor = true;
            // 
            // btnCoca
            // 
            this.btnCoca.AutoSize = true;
            this.btnCoca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoca.Image = ((System.Drawing.Image)(resources.GetObject("btnCoca.Image")));
            this.btnCoca.Location = new System.Drawing.Point(153, 3);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(120, 120);
            this.btnCoca.TabIndex = 20;
            this.btnCoca.Text = "Coca Cola";
            this.btnCoca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoca.UseVisualStyleBackColor = true;
            // 
            // btnSoda
            // 
            this.btnSoda.AutoSize = true;
            this.btnSoda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoda.Image = ((System.Drawing.Image)(resources.GetObject("btnSoda.Image")));
            this.btnSoda.Location = new System.Drawing.Point(3, 3);
            this.btnSoda.Name = "btnSoda";
            this.btnSoda.Size = new System.Drawing.Size(120, 120);
            this.btnSoda.TabIndex = 9;
            this.btnSoda.Text = "Soda";
            this.btnSoda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoda.UseVisualStyleBackColor = true;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Items";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.Width = 125;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 125;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.panel1);
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblCartSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSoda;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Button btnSkincare;
        private System.Windows.Forms.Button btnBentoBox;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnMeat;
        private System.Windows.Forms.Button btnCookie;
        private System.Windows.Forms.Button btnEggs;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}