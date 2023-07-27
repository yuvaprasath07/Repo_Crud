using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IstudentLogicLayer
    {
        public List<StudentInfoModel> getAll();
        public StudentInfoModel update(StudentInfoModel data);
        public object getById(int id);
        public StudentInfoModel StudenDataAdd(StudentInfoModel data);
        public object deletestudent(int id);
    }
}
