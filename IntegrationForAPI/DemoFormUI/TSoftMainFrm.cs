using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Integration.Business.Abstract;
using Integration.Business.Abstract.TSoft;
using Integration.Business.Concrete;
using Integration.Business.Concrete.TSoft;
using Integration.Core.Utilities.Helper;
using Integration.DataAccess.Concrete.EntityFramework;
using Integration.DataAccess.Concrete.TSoft;
using Integration.Entities.Concrete.DataBase;

namespace DemoFormUI
{
    public partial class TSoftMainFrm : Form
    {
        readonly IProductService _productService;
        readonly ITSoftProductService _tSoftProductService;

        public TSoftMainFrm()
        {
            _productService = new ProductManager(new EfProductDal());
            _tSoftProductService = new TSoftProductManager(new ETSoftProductDal());
            InitializeComponent();
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            var user = _tSoftProductService.GetAll(0);
            dgwViewProduct.DataSource = user.Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = 0;
            while (start >= 0)
            {
                var product = _tSoftProductService.GetAll(start);
                if (product.Data.Length != 250)
                {
                    MessageBox.Show("Ürün Aktarımı tamamlandı.", "Başarılı", MessageBoxButtons.OK);
                    break;
                }

                foreach (var prod in product.Data)
                {
                    _productService.Add(new Product()
                    {
                        ProductName = prod.ProductName,
                        Barcode = prod.Barcode,
                        ProductCode = prod.ProductCode,
                        ProductId = prod.ProductId,
                        SellingPrice = prod.SellingPrice,
                        Stock = prod.Stock,
                    });
                }

                start += 250;
            }
        }
    }
}