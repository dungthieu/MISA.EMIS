using MISA.QLTH.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Entities
{
    /// <summary>
    /// Danh sách các lớp, khối
    /// </summary>
    /// CreateBy : MF757 TTdung
    /// CreateDate: 23/3/2021

    public class GroupClass
    {
        /// <summary>
        /// id khối
        /// </summary>
        [PrimaryKey]
        public Guid GroupClassId { get; set; }

        /// <summary>
        /// mã code khối
        /// </summary>
        public string GroupClassCode { get; set; }

        /// <summary>
        /// tên khối 
        /// </summary>
        public string GroupClassName { get; set; }

        /// <summary>
        /// mô tả
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ngày tạo
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// người tạo
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// ngày cập nhật
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// người cập nhật
        /// </summary>
        public string UpdateBy { get; set; }
    }
}
