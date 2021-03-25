using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Entity
{
    /// <summary>
    /// 1 chuỗi object trả về cho người dùng
    /// </summary>
    /// CreatBy : MF757 TTdung
    /// DateTime: 23/2/2021
    public class ServiceResult
    {
        /// <summary>
        /// trả về lỗi cho dev.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// trả về status code cho dev.
        /// </summary>
        public MISACode MISACode { get; set; }
        /// <summary>
        ///link file log lịch sử lỗi .
        /// </summary>
        public string traceId { get; set; }
        /// <summary>
        /// trả về object data dữ liệu .(mesage ủe, data)
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// thêm thông tin .
        /// </summary>
        public string moreInfo { get; set; }
        /// <summary>
        /// check null dữ liệu .
        /// </summary>
        public checkvalue checkValue { get; set; }

    }
}
