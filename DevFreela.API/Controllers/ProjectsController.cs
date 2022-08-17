using System.Reflection.Metadata;
using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/Projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(ActivityTrackingOptions query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(CreatProjectModel creatProject)
        {
            if (creatProject.Title.Length > 200)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new {id = creatProject.Id}, creatProject);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, UpdateProjectModel updateProject)
        {
            if (updateProject.Descriptions.Length > 200)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}