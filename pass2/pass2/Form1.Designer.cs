namespace pass2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            listViewCart = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            lblTotalPrice = new ColumnHeader();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "460845338_122231742158003851_1726734479425510568_n.jpg");
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewProducts.LargeImageList = imageList1;
            listViewProducts.Location = new Point(90, 55);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(639, 606);
            listViewProducts.SmallImageList = imageList1;
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ảnh sản phẩm";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = " tên sản phẩm";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "giá";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "số lượng";
            columnHeader4.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(1057, 653);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1334, 750);
            button2.Name = "button2";
            button2.Size = new Size(145, 58);
            button2.TabIndex = 2;
            button2.Text = "THANH TOAN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(457, 750);
            button3.Name = "button3";
            button3.Size = new Size(89, 48);
            button3.TabIndex = 3;
            button3.Text = "Thêm vào giỏ hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(677, 750);
            button4.Name = "button4";
            button4.Size = new Size(109, 48);
            button4.TabIndex = 4;
            button4.Text = "SUA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(896, 748);
            button5.Name = "button5";
            button5.Size = new Size(137, 46);
            button5.TabIndex = 5;
            button5.Text = "Xóa khỏi giỏ hàng";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listViewCart
            // 
            listViewCart.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, lblTotalPrice });
            listViewCart.LargeImageList = imageList1;
            listViewCart.Location = new Point(759, 55);
            listViewCart.Name = "listViewCart";
            listViewCart.Size = new Size(754, 606);
            listViewCart.SmallImageList = imageList1;
            listViewCart.TabIndex = 6;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = View.Details;
            listViewCart.SelectedIndexChanged += listViewCart_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ảnh sản phẩm";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = " tên sản phẩm";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "giá";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "số lượng";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "tổng số lượng";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Text = "tổng giá trị đơn hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 836);
            Controls.Add(listViewCart);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListView listViewCart;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader lblTotalPrice;
    }
}
