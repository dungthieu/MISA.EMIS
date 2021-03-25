using Dapper;
using MISA.QLTH.ApplicationCore.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTH.Instructure.DataAccess
{
    /// <summary>
    /// hàm con thực thi interface IBaseRepository
    /// </summary>
    /// <typeparam name="T">T is class</typeparam>
    /// CreatBy : MF757 TTdung dz
    /// DateTime: 23/3/2021
    /// 
    public class BaseRepository<T> : IBaseRepository<T>
    {
        #region Declare     
        protected string className;
        protected string procName;
        protected string _connectionString = "Host = 47.241.69.179; " +
             "Port= 3306; " +
             "Database = Dungthieu;" +
             "User Id = dev; " +
             "Password=12345678";

        protected IDbConnection _dbConnection;
        #endregion
        #region Constructor
        public BaseRepository()
        {
            _dbConnection = new MySqlConnection(_connectionString);
        }
        public string GetName()
        {

            className = typeof(T).Name;
            return className;
        }
        public DynamicParameters GetDynamicParams(Guid id)
        {
            var dynamicParams = new DynamicParameters();

            dynamicParams.Add($"@{className}Id", id.ToString());

            return dynamicParams;
        }
        #endregion
        public IEnumerable<T> GetAll()
        {
            procName = $"Proc_Get{GetName()}s";

            var ListObj = _dbConnection.Query<T>(procName, commandType: CommandType.StoredProcedure);

            return ListObj;
        }
        public T GetById(Guid id)
        {
            procName = $"Proc_Get{GetName()}ById";

            var Obj = _dbConnection.Query<T>(procName, param: GetDynamicParams(id), commandType: CommandType.StoredProcedure).FirstOrDefault();
            return Obj;
        }
        //public T getByName(string name)
        //{
        //    procName = $"Select * from Customer where CustomerCode = {name}";

        //    var Obj = _dbConnection.Query<T>(procName, commandType: CommandType.Text).FirstOrDefault();
        //    return Obj;
        //}
        public int Insert(T entity)
        {
            procName = $"Proc_Insert{GetName()}";
            var Obj = _dbConnection.Execute(procName, entity, commandType: CommandType.StoredProcedure);
            return Obj;
        }

        public int Update(T entity)
        {
            procName = $"Proc_Update{GetName()}";
            var Obj = _dbConnection.Execute(procName, entity, commandType: CommandType.StoredProcedure);
            return Obj;
        }

        public int Delete(Guid id)
        {
            procName = $"Proc_Delete{GetName()}";
            var Obj = _dbConnection.Execute(procName, param: GetDynamicParams(id), commandType: CommandType.StoredProcedure);
            return Obj;
        }

        public T GetEntityByProperty(string propertyName, object propertyValue)
        {
            var query = $"SELECT * FROM {typeof(T).Name} where {propertyName} = '{propertyValue}'";
            var obj = _dbConnection.Query<T>(query, commandType: CommandType.Text).FirstOrDefault();
            return obj;
        }
        public int DeleteRange(List<T> entities)
        {
            return 5;
        }

    }
}
