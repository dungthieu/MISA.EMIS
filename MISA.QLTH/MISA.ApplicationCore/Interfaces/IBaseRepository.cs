using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface chứa các field để lấy dl từ db ra
    /// </summary>
    /// <typeparam name="T"> T là biến tham chiếu </typeparam>
    /// CreatBy : MF757 TTdung dz
    /// DateTime: 23/3/2021
    public interface IBaseRepository<T>
    {

        /// <summary>
        /// lấy 1 bản ghi theo tham số id
        /// </summary>
        /// <param name="id"> Primary key of Table current</param>
        /// <returns>1 bản ghi theo tham số id</returns>
        T GetById(Guid id);

        ///// <summary>
        ///// lấy 1 bản ghi có chứa tên đã điền
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns></returns>
        //T getByName(string name);

        /// <summary>
        /// láy 1 danh sách trả về của bảng T
        /// </summary>
        /// <returns>trả về tất cả các bản ghi của bảng T</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// update 1 bản ghi dựa trên những thay dổi entity 
        /// </summary>
        /// <param name="entity">tập hợp chứa các trường sau thay đổi của 1 hàng trong bảng t</param>
        /// <returns>1 bản update mới </returns>
        int Update(T entity);

        /// <summary>
        /// thêm mới 1 bản ghi dựa vào trường entity truyền vào 
        /// </summary>
        /// <param name="entity">1 danh sách các trường của 1 hàng mới trong bảng t</param>
        /// <returns>trả về 1 bản ghi mới </returns>
        int Insert(T entity);

        /// <summary>
        /// xoá bản ghi 
        /// </summary>
        /// <param name="id">giá trị của 1 khoá chính của bảng</param>
        /// <returns>trả về số bản ghi bị thay đổi (xoá)</returns>
        int Delete(Guid id);

        /// <summary>
        /// lấy 1 bản ghi dựa trên các tham số truyền vào 
        /// </summary>
        /// <param name="propertyName">lấy tên của cột</param>
        /// <param name="propertyValue"> giá trị của cột đó</param>
        /// <returns>1 bản ghi </returns>
        T GetEntityByProperty(string propertyName, object propertyValue);

        /// <summary>
        /// Xoá nhièu bản ghi cùng 1 lúc
        /// </summary>
        /// <param name="entities"> 1 danh dách các giá trị</param>
        /// <returns> số bản ghi bị xoá </returns>

        int DeleteRange(List<T> entities);


    }
}
