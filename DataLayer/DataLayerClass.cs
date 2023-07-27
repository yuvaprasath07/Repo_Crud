using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DataLayerClass : IDataLayer
    {
        private readonly StudentDBContext _Context;

        public DataLayerClass(StudentDBContext context)
        {
            _Context = context;
        }

        public List<StudentInfoModel> GetAll()
        {
            var data = _Context.Students.ToList();
            return data;
        }

        public object getById(int id)
        {
            var data = _Context.Students.Where(x => x.StudentID == id);
            if (data == null)
            {
                return "Data is Null";
            }
            return data;
        }

        public StudentInfoModel StudenDataAdd(StudentInfoModel data)
        {
            var addstudent = _Context.Students.Add(data);
            _Context.SaveChanges();
            return data;
        }

        public object update(StudentInfoModel data)
        {
            var existingStudent = _Context.Students.FirstOrDefault(x => x.StudentID == data.StudentID);
            if (existingStudent != null)
            {
                existingStudent.FirstName = data.FirstName;
                existingStudent.LastName = data.LastName;
                existingStudent.StudentID = data.StudentID;
                existingStudent.standard = data.standard;
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public object deletestudent(int id)
        {
            var find = _Context.Students.Where(x => x.StudentID == id).FirstOrDefault();
            if (find != null)
            {
                _Context.Students.Remove(find);
                _Context.SaveChanges();
                return "Data Delete is sucessfully:";

            }
            return "Data is Null";

        }
    }
}