using MISA.QLTH.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Entities
{
    /// <summary>
    /// Danh sách các nhóm khoản thu
    /// </summary>
    /// CreateBy : MF757 TTdung
    /// CreateDate: 23/3/2021
    public class SurchargeGroup
    {
        /// <summary>
        /// id nhóm khoản thu
        /// </summary>
        [PrimaryKey]
        public Guid SurchargeGroupId { get; set; }

        /// <summary>
        /// Tên nhóm khoản thu
        /// </summary>
        public string SurchargeGroupName { get; set; }

        /// <summary>
        /// mô tả
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// người tạo
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// ngày tạo
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// người cập nhật
        /// </summary>
        public string UpdateBy { get; set; }

        /// <summary>
        /// ngày cập nhật
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
