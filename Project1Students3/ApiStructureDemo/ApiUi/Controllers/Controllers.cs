using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;
using System.Text.Json;


namespace ApiUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudRegistration : ControllerBase
    {
        private readonly IBusinessLayerClass _ibus;

        public StudRegistration(IBusinessLayerClass ibus)
        {
            this._ibus = ibus;
        }




        [HttpPost("StudentRegistration")]
        public ActionResult<Student> StudentRegistration(Student c)
        {
            if (ModelState.IsValid)
            {
                Student c1 = this._ibus.StudentRegistration(c);
            }
            else
            {
                return NotFound("that modelbinding did't work");
            }
            return Created($"https://localhost:7007/api/StudRegistration/getStudent/{c.StudentId}", c);
        }


        [HttpPost("StudentLogin")]
        public ActionResult<Student> StudentLogin(Student c)
        {
            if (ModelState.IsValid)
            {
                Student c1 = this._ibus.StudentLogin(c);
                
            }
            else
            {
                return NotFound("that modelbinding did't work");
            }
            
            return Created($"https://localhost:7007/api/StudRegistration/getStudent/{c.StudentId}", c);
        }


        
        [HttpPost("StudentGradesForm")]
        public ActionResult<GradesForm> StudentGradesForm(GradesForm c)
        {
            if (ModelState.IsValid)
            {
                GradesForm c1 = this._ibus.StudentGradesForm(c);
                
            }
            else
            {
                return NotFound("that modelbinding did't work");
            }
            return Created($"https://localhost:7007/api/StudRegistration/getStudent/{c.GradesFormId}", c);
        }





        
        [HttpGet("GetGradesForms")]
        public ActionResult<List<GradesForm>> Students2(int? id)
        {
            if (id == null || id == 0)
            {
                List<GradesForm> StudentList2 = this._ibus.GetStudentList2();
                if (StudentList2 == null)
                {
                    return Problem("It's not you. It's us.... We cannot deliver.");
                }
                else return Ok(StudentList2);
            }
            else
            {
                return null;
            }
        }


        
        
        [HttpGet("InstructorApprovesRequests")]
        public ActionResult<List<GradesForm>> Students3(int? id)
        {
            if (id == null || id == 0)
            {
                List<GradesForm> StudentList3 = this._ibus.GetStudentList3();
                if (StudentList3 == null)
                {
                    return Problem("It's not you. It's us.... We cannot deliver.");
                }
                else return Ok(StudentList3);
            }
            else
            {
                return null;
            }
        }




    }
}