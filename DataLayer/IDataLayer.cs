using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataLayer
    {
        public List<StudentInfoModel> GetAll();
        public object update(StudentInfoModel data);
        public object getById(int id);
        public StudentInfoModel StudenDataAdd(StudentInfoModel data);
        public object deletestudent(int id);
    }
}
