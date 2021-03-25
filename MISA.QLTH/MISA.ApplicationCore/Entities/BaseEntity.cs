using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Entity
{
    /// <summary>
    /// lấy tra trường thông tin cơ sở.
    /// </summary>
    /// CreatBy : MF757 TTdung
    /// DateTime: 23/2/2021
    
    public class BaseEntity
    {
    }
    /// <summary>
    /// Hiển thi tên thuộc tính
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayName : Attribute
    {
        public string Name { get; set; }
        public DisplayName(string name = null)
        {
            this.Name = name;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class Value : Attribute
    {

    }
    /// <summary>
    /// check trường không được để trống
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {

    }

    /// <summary>
    /// check trùng mã  
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDuplicated : Attribute
    {

    }

    /// <summary>
    /// check khoá chính
    /// </summary>
    public class PrimaryKey : Attribute
    {

    }
}
