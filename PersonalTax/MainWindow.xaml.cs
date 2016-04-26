using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalTax
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, ITax
    {
        #region Ctor
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.ResizeMode = ResizeMode.NoResize;

            Init();

        }
        #endregion

        #region 接口实现
        public decimal BaseHouse
        {
            get { return Convert.ToDecimal(txtHouseBase.Text); }
        }

        public decimal BaseSalary
        {
            get { return Convert.ToDecimal(txtSalary.Text); }
        }

        public decimal ForHospital
        {
            get { return Convert.ToDecimal(txtHos.Text); }
        }

        public double ForHospitalRate
        {
            get { return Convert.ToDouble(txtHosRate.Text); }
        }

        public decimal ForNoWork
        {
            get { return Convert.ToDecimal(txtNoWork.Text); }
        }

        public double ForNoWorkRate
        {
            get { return Convert.ToDouble(txtWorkRate.Text); }
        }

        public decimal ForOld
        {
            get { return Convert.ToDecimal(txtYLBX.Text); }
        }

        public double ForOldRate
        {
            get { return Convert.ToDouble(txtYLBXRate.Text); }
        }

        public double HouseRate
        {
            get { return Convert.ToDouble(txtHouseRate.Text); }
        }

        public decimal HouseSalary
        {
            get { return Convert.ToDecimal(txtHouseSalary.Text); }
        }

        public decimal StartTaxPoint
        {
            get { return Convert.ToDecimal(txtBeginSalary.Text); }
        }

        public decimal ThreeBasePoint
        {
            get { return Convert.ToDecimal(txtThreeBase.Text); }
        }

        public decimal CalcPersonAfterTaxSalary()
        {
            decimal sumSalary = BaseSalary - ThreeSum() - HouseSum() - CalcPersonTax();
            return sumSalary;
        }

        public decimal CalcPersonTax()
        {
            decimal gtSalary = BaseSalary - ThreeSum() - HouseSum()-StartTaxPoint ;
            decimal taxRate=0;
            int fastNum=0;
            return gtSalary.GetTaxLevel(out taxRate,out fastNum);
        }

        public decimal HouseSum()
        {
            return HouseSalary;
        }

        public decimal ThreeSum()
        {
            return ForHospital + ForOld + ForNoWork+10;
        }
        #endregion

        #region Methods
        public void Init() {
            txtThreeBase.Text = txtHouseBase.Text = txtSalary.Text;
        }


        #endregion

        #region Events
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtYLBX.Text = (ThreeBasePoint * (Convert.ToDecimal(ForOldRate / 100))).ToString();
                txtHos.Text = (ThreeBasePoint * (Convert.ToDecimal(ForHospitalRate / 100))).ToString();
                txtNoWork.Text = (ThreeBasePoint * (Convert.ToDecimal(ForNoWorkRate / 100))).ToString();

                txtHouseSalary.Text = (BaseHouse * (Convert.ToDecimal(HouseRate / 100))).ToString();
                lblThreeSumDetail.Content = ThreeSum();
                lblHouseSum.Content = HouseSum();

                lblTax.Content = CalcPersonTax();
                lblAfterTax.Content = CalcPersonAfterTaxSalary();
            }
            catch (Exception)
            {
                MessageBox.Show("请确认您输入的都是数字！","提示信息",MessageBoxButton.OK,MessageBoxImage.Warning);
            }

        }


        #endregion


    }
}
