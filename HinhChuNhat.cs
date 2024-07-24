namespace CSharp_TinhChuViDienTich
{
    public partial class HinhChuNhat : Form
    {
        double dai;
        double rong;

        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "- Diện tích: " + (dai * rong) + Environment.NewLine + "- Chu vi: " + (dai + rong) * 2;
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "Diện tích: " + TinhDienTich(dai, rong);
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            if (LayThongTinMoi())
                lblKQ.Text = "Chu vi: "  + TinhChuVi(dai, rong);
            else
                lblKQ.Text = "";
        }

        private double TinhDienTich(double d, double r)
        {
            return d * r;
        }
        private double TinhChuVi(double d, double r)
        {
            return (d + r) * 2;
        }

        private void LayThongTin()
        {
            try
            {
                dai = Convert.ToDouble(txtDai.Text);
                rong = Convert.ToDouble(txtRong.Text);
            }
            catch {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDai.Clear();
                txtRong.Clear();
                txtDai.Focus();
            }

        }

        private bool LayThongTinMoi()
        {
            try
            {
                dai = Convert.ToDouble(txtDai.Text);
                rong = Convert.ToDouble(txtRong.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDai.Clear();
                txtRong.Clear();
                txtDai.Focus();
                return false;
            }

        }
    }
}
