using Entity;
using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInfoController : ControllerBase
    {
        private readonly IstudentLogicLayer _ilogicLayer;

        public StudentInfoController(IstudentLogicLayer ilogicLayer)
        {
            _ilogicLayer = ilogicLayer;
        }
        [HttpGet]
        [Route("GetStudentData")]
        public IActionResult getdata()
        {
            var data = _ilogicLayer.getAll();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public IActionResult getbyId(int id)
        {
            var data = _ilogicLayer.getById(id);
            return Ok(data);
        }

        [HttpPut("UpdateTable")]
        public IActionResult update(StudentInfoModel data)
        {
            _ilogicLayer.update(data);
            return Ok(data);
        }

        [HttpPost("AddStudent")]
        public IActionResult add(StudentInfoModel data)
        {
            _ilogicLayer.StudenDataAdd(data);
            return Ok(data);
        }

        [HttpDelete("StudentDelete")]
        
        public IActionResult delete(int id)
        {
            var del = _ilogicLayer.deletestudent(id);
            return Ok(del);
        }

    }
}
