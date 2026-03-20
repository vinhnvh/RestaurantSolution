using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Restaurant.UI
{
    public partial class TableControl : UserControl
    {
        // 1. Kho chứa dữ liệu
        private int _formIndex;

        // 2. Cửa sổ giao tiếp với bảng Properties
        [Category("Cấu Hình Bàn")]
        [Description("Số thứ tự để mở Form tương ứng (1-6)")]
        public int FormIndex
        {
            get { return _formIndex; }
            set
            {
                _formIndex = value;
                // Khi bạn gõ số ở ngoài, chữ trên nút sẽ đổi theo ngay
                if (btnTable != null)
                {
                    btnTable.Text = "Bàn số " + _formIndex;
                }
            }
        }

        public TableControl()
        {
            InitializeComponent();
        }

        // 3. Xử lý khi click vào nút
        private void btnTable_Click(object sender, EventArgs e)
        {
            switch (_formIndex)
            {
                case 1: new Form1().Show(); break;
                case 2: new Form2().Show(); break;
                case 3: new Form3().Show(); break;
                case 4: new Form4().Show(); break;
                case 5: new Form5().Show(); break;
                case 6: new Form6().Show(); break;
                default:
                    MessageBox.Show("Vui lòng gán FormIndex từ 1 đến 6 trong bảng Properties!");
                    break;
            }
        }
    }
}
