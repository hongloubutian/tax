using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTax
{
   public  interface ITax
    {
        #region 基本工资
        /// <summary>
        /// 税前工资
        /// </summary>
        decimal BaseSalary { get;  }

        /// <summary>
        /// 起征点
        /// </summary>
        decimal StartTaxPoint { get; }
        #endregion

        #region 三险
        /// <summary>
        /// 三险起征点
        /// </summary>
        decimal ThreeBasePoint { get;  }

        /// <summary>
        /// 养老保险
        /// </summary>
        decimal ForOld { get; }

        /// <summary>
        /// 养老个人占比
        /// </summary>
        double ForOldRate { get;  }
        /// <summary>
        /// 医疗保险
        /// </summary>
        decimal ForHospital { get; }

        /// <summary>
        /// 医保个人占比
        /// </summary>
        double ForHospitalRate { get;  }

        /// <summary>
        /// 失业保险
        /// </summary>
        decimal ForNoWork { get; }

        /// <summary>
        /// 失业保险个人占比
        /// </summary>
        double ForNoWorkRate { get;  }

        /// <summary>
        /// 三险缴费总数
        /// </summary>
        /// <returns>返回结果</returns>
        decimal ThreeSum();
        #endregion

        #region 住房公积金
        /// <summary>
        /// 住房公积金个人占比
        /// </summary>
        decimal BaseHouse { get; }

        /// <summary>
        /// 公积金
        /// </summary>
        decimal HouseSalary { get;  }

        /// <summary>
        /// 公积金比例
        /// </summary>
        double  HouseRate { get;  }

        /// <summary>
        /// 住房公积金缴费总数
        /// </summary>
        /// <returns>返回结果</returns>
        decimal HouseSum();
        #endregion

        #region 计算
        /// <summary>
        /// 计算个人所得税
        /// </summary>
        /// <returns>返回结果</returns>
        decimal CalcPersonTax();

        /// <summary>
        /// 计算税后薪资
        /// </summary>
        /// <returns>返回结果</returns>
        decimal CalcPersonAfterTaxSalary();
        #endregion
    }
}
