using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Entity
{
    /// <summary>
    /// Danh sách kế hoạch thu cho trường học
    /// </summary>
    /// CreateBy : MF757 TTdung
    /// CreateDate: 23/3/2021
    public class Surcharge
    {
        /// <summary>
        /// id Khoản thu
        /// </summary>
        [PrimaryKey]
        public Guid SurchargeId { get; set; }

        /// <summary>
        /// Tên khoản thu
        /// </summary>
        [Required]
        [CheckDuplicated]
        [DisplayName("Tên khoản thu")]
        public string SurchargeName { get; set; }

        /// <summary>
        /// Id nhóm khoản thu
        /// </summary>
        public Guid SurchargeGroupId { get; set; }

        /// <summary>
        /// nhom khoan thu(khong dau)
        /// </summary>
        public string SurchargeGroupName { get; set; }
        /// <summary>
        /// Mức thu
        /// </summary>
        [Required]
        [Value]
        [DisplayName("Mức thu")]
        public decimal SurchargeLevel { get; set; }

        /// <summary>
        /// id phạm vi thu
        /// </summary>
        [Required]
        [DisplayName("Phạm vi thu")]
        public Guid GroupClassId { get; set; }

        /// <summary>
        /// phạm vi thu
        /// </summary>
        public string GroupClassName { get; set; }

        /// <summary>
        /// Tính chất
        /// </summary>
        public string SurchargeType { get; set; }

        /// <summary>
        /// Đơn vị tính
        /// </summary>
        [Required]
        [DisplayName("Đơn vị tính")]
        public string CaculatorUnit { get; set; }

        /// <summary>
        /// Kỳ thu
        /// </summary>
        [Required]
        [DisplayName("Kỳ thu")]
        public string SurchargePeriod { get; set; }

        /// <summary>
        /// Áp dũng miễn giảm 
        /// </summary>
        public bool IsDiscount { get; set; }

        /// <summary>
        /// Khoản thu bắt buộc
        /// </summary>
        public bool IsObligatory { get; set; }

        /// <summary>
        /// Cho phép xuất hóa đơn
        /// </summary>
        public bool IsInvoice { get; set; }

        /// <summary>
        /// Cho phép xuất chứng từ
        /// </summary>
        public bool IsExportDocuments { get; set; }

        /// <summary>
        /// Cho phép hoàn trả
        /// </summary>
        public bool IsReturn { get; set; }

        /// <summary>
        /// Thu nội bộ
        /// </summary>
        public bool IsInternal { get; set; }
        
        /// <summary>
        /// Phân loại đăng ký
        /// </summary>
        public bool IsRegister { get; set; }

        /// <summary>
        /// Theo dõi
        /// </summary>
        public bool IsFollow { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string UpdateBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}
