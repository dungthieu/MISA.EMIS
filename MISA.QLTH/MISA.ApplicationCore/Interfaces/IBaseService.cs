using MISA.QLTH.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Interfaces
{

    /// <summary>
    /// interface Service 
    /// </summary>
    /// <typeparam name="T"> where T : class</typeparam>
    /// CreatBy : MF757 TTdung Dz
    /// DateTime: 23/3/2021
    public interface IBaseService<T>
    {

        /// <summary>
        /// lấy toàn bộ dữ liệu 
        /// </summary>
        /// <returns> trả về 1 chuỗi kết quả  chứa các thông tin về việc lấy toàn bộ </returns>
        ServiceResult getAll();

        /// <summary>
        /// lay gia tri theo id
        /// </summary>
        /// <returns></returns>
        ServiceResult getById(Guid id);

        /// <summary>
        /// tạo mới 1 cột dựa vào các tham số truyền vào.
        /// </summary>
        /// <param name="entity"> các trường thông tin đẻ tạo mới </param>
        /// <returns>trả về 1 chuỗi kết quả chứa các thông tin về việc thêm mới</returns>
        ServiceResult Create(T entity);

        /// <summary>
        /// upđate 1 bản ghi 
        /// </summary>
        /// <param name="entity">trường được sửa đổi </param>
        /// <returns>trả về 1 chuỗi kết quả chứa các thông tin về việc sử </returns>
        ServiceResult Update(T entity);

        /// <summary>
        /// xoá 1 bản ghi dựa theo id
        /// </summary>
        /// <param name="id">khoá chính của bản ghi đó</param>
        /// <returns>trả về 1 chuỗi kết quả chứa các thông tin về việc xoá</returns>
        ServiceResult Delete(Guid id);
    }
}
