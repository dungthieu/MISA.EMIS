using MISA.QLTH.ApplicationCore.Entity;
using MISA.QLTH.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.ApplicationCore.Services
{
    // <summary>
    /// BaseService là class kế thừa từ  IBaseService.
    /// </summary>
    /// <typeparam name="T">Where T : class</typeparam>
    /// CreatBy : MF757 TTdung Dz
    /// DateTime: 23/3/2021
    public class BaseService<T> : IBaseService<T>
    {
        IBaseRepository<T> _baseRepository;
        protected ServiceResult _serviceResult;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _serviceResult = new ServiceResult();
            _baseRepository = baseRepository;
        }

        private ServiceResult Validate(T entity)
        {
            //lấy các properties của tham số truyền vào
            var properties = entity.GetType().GetProperties();

            foreach (var property in properties)
            {

                // tạo rỗng 1 displayName
                var displayName = string.Empty;

                var type = _serviceResult.checkValue;
                // lấy tên displayname
                var displayNameAttributes = property.GetCustomAttributes(typeof(DisplayName), true);

                //check length >0 thì lấy , nếu ko lấy = empty
                if (displayNameAttributes.Length > 0)
                {
                    displayName = (displayNameAttributes[0] as DisplayName).Name;
                }

                // lấy value của property
                var propertyValue = property.GetValue(entity);

                //check các property có thuộc tính required
                if (property.IsDefined(typeof(Required), false) && (type ==checkvalue.Create || type == checkvalue.Update))
                {

                    //check bat buoc nhap cho ca update, create, delete.
                    if (propertyValue == null)
                    {
                        // trả về cho người dùng message dữ liệu bị trống
                        _serviceResult.Data = $"{displayName}" + Properties.Resources.NoRequired;
                        _serviceResult.MISACode = MISACode.BadRequest;
                    }
                }

                //check các property có thuộc tính required
                if (property.IsDefined(typeof(CheckDuplicated), false) && (type == checkvalue.Create || type == checkvalue.Update))
                {
                    // Kiểm tra xem dữu liệu nhập vào có tồn tại hay không
                    var checkaDuplicate = _baseRepository.GetEntityByProperty(property.Name, property.GetValue(entity));

                    if (checkaDuplicate != null)
                    {
                        _serviceResult.checkValue = checkvalue.Create;
                        _serviceResult.Data = $"{displayName }" + Properties.Resources.Duplicate;
                        _serviceResult.MISACode = MISACode.BadRequest;
                    }
                }
            }
            return _serviceResult;

        }
        public ServiceResult getAll()
        {
            _serviceResult.Data = _baseRepository.GetAll();
            _serviceResult.MISACode = MISACode.Success;
            _serviceResult.Message = Properties.Resources.Success;
            return _serviceResult;
        }

        public ServiceResult Create(T entity)
        {
            _serviceResult.checkValue = checkvalue.Create;
            try
            {
                var request = Validate(entity).MISACode;

                var checkRequestValidate = Validate(entity).checkValue;

                if (request != MISACode.BadRequest && checkRequestValidate == checkvalue.Create)
                {
                    _serviceResult.Data = _baseRepository.Insert(entity);

                    _serviceResult.MISACode = MISACode.Created;

                    _serviceResult.Message = Properties.Resources.CreateSuccess;
                }
            }
            catch (Exception ex)
            {
                _serviceResult.Data = ex.Message;
                _serviceResult.Message = Properties.Resources.Createfail;
            }
            return _serviceResult;
        }
        public ServiceResult Update(T entity)
        {
            _serviceResult.checkValue = checkvalue.Update;

            try
            {

                var request = Validate(entity).MISACode;

                var checkRequestValidate = Validate(entity).checkValue;

                var isValidate = Validate(entity);
                if (request != MISACode.BadRequest && checkRequestValidate == checkvalue.Update)
                {
                    _serviceResult.Data = _baseRepository.Update(entity);
                    _serviceResult.MISACode = MISACode.Success;
                    _serviceResult.Message = Properties.Resources.UpdateSuccess;
                    return _serviceResult;
                }
            }
            catch (Exception ex)
            {
                _serviceResult.Message = Properties.Resources.UpdateFail;
                _serviceResult.Data = ex.Message;
            }
            return _serviceResult;
        }

        public ServiceResult Delete(Guid id)
        {
            var checkDelete = _baseRepository.GetById(id);
            if (checkDelete != null)
            {
                _serviceResult.Data = _baseRepository.Delete(id);
                _serviceResult.MISACode = MISACode.Success;
                _serviceResult.Message = Properties.Resources.DeleteSuccess;

            }
            else
            {
                _serviceResult.MISACode = MISACode.BadRequest;
                _serviceResult.Data = Properties.Resources.NotExsits;
                _serviceResult.Message = Properties.Resources.DeleteFail;
            }

            return _serviceResult;
        }
        public ServiceResult getById(Guid id)
        {
            var check = _baseRepository.GetById(id);
            if (check != null)
            {
                _serviceResult.Data = _baseRepository.GetById(id);
                _serviceResult.MISACode = MISACode.Success;
                _serviceResult.Message = Properties.Resources.Success;

            }
            _serviceResult.MISACode = MISACode.BadRequest;
            _serviceResult.Data = Properties.Resources.NotExsits;
            _serviceResult.Message = Properties.Resources.Error;
            return _serviceResult;
        }
    }
}
