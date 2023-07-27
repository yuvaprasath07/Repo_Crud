using DataLayer;
using Entity;

namespace LogicLayer
{
    public class LogicLayerClass : IstudentLogicLayer
    {
        private readonly IDataLayer _datalayer;

        public LogicLayerClass(IDataLayer datalayer)
        {
            _datalayer = datalayer;
        }

        public object deletestudent(int id)
        {
            return _datalayer.deletestudent(id);
        }

        public List<StudentInfoModel> getAll()
        {
            var data = _datalayer.GetAll();
            return data;
        }

        public object getById(int id)
        {
            return _datalayer.getById(id);
        }

        public StudentInfoModel StudenDataAdd(StudentInfoModel data)
        {
            return _datalayer.StudenDataAdd(data);
        }

        public StudentInfoModel update(StudentInfoModel data)
        {
            _datalayer.update(data);
            return data;
        }
    }
}