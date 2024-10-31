using static pass2.Form1;

namespace pass2
{

    public partial class Form1 : Form
    {
        private List<Product> _productList = new List<Product>();
        private ShoppingCart _shoppingCart = new ShoppingCart();
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            UpdateProductListView();

        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Image Image { get; set; }

            public Product(string name, decimal price, int quantity, Image image)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Image = image;
            }
        }

        public class ShoppingCart
        {
            private List<Product> _products = new List<Product>();

            public void AddProduct(Product product)
            {
                _products.Add(product);
            }

            public void RemoveProduct(Product product)
            {
                _products.Remove(product);
            }

            public decimal GetTotalPrice()
            {
                return _products.Sum(p => p.Price * p.Quantity);
            }

            public int GetTotalQuantity()
            {
                return _products.Sum(p => p.Quantity);
            }

            public List<Product> GetProducts()
            {
                return _products;
            }

            public void ClearCart()
            {
                _products.Clear();
            }
        }
        private void UpdateProductListView()
        {
            // Cập nhật ListView hiển thị danh sách sản phẩm
            listViewProducts.Items.Clear();
            foreach (var product in _productList)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                listViewProducts.Items.Add(item);
            }
        }
        private void UpdateCartListView()
        {
            // Cập nhật ListView hiển thị giỏ hàng
            listViewCart.Items.Clear();
            foreach (var product in _shoppingCart.GetProducts())
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                listViewCart.Items.Add(item);
            }
            lblTotalPrice.Text = $"Total: {_shoppingCart.GetTotalPrice():C}";
        }
        private void LoadProducts()
        {
            // Thêm các sản phẩm mẫu vào danh sách sản phẩm
            _productList.Add(new Product("Product 1", 10.0m, 1, null));
            _productList.Add(new Product("Product 2", 20.0m, 1, null));
            // Thêm các sản phẩm khác nếu cần
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProducts.SelectedItems[0];
                var product = _productList.First(p => p.Name == selectedItem.Text);
                _shoppingCart.AddProduct(product);
                UpdateCartListView();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCart.SelectedItems[0];
                var product = _shoppingCart.GetProducts().First(p => p.Name == selectedItem.Text);
                _shoppingCart.RemoveProduct(product);
                UpdateCartListView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order completed successfully!");
            _shoppingCart.ClearCart();
            UpdateCartListView();
        }

        private void listViewCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
