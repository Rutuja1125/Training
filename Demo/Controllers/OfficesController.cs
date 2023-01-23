using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.JsonPatch;
using System.Runtime.InteropServices;

namespace Demo.Controllers
{
    [Route("api/office")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly DemoContext _context;

        public OfficesController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/Offices
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Office>>> GetOffices()
        //{
        //    return await _context.Offices.ToListAsync();
        //}
        public IQueryable<OfficeDTO> Get() 
        {
            var offices = from x in _context.Offices
                          select new OfficeDTO()
                          {
                              Id = x.Id,
                              EmployeeName = x.Employee.Name
                          };
            return offices;
        }

        // GET: api/Offices/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDatabyId(int id)
        {
            var result = await _context.Offices.Where(x => x.Id == id).Select(x => new OfficeDetailDto() 
            {
                Id = x.Id,
                Location = x.Location,
                EmployeeName = x.Employee.Name,

            }).ToListAsync();
            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="office"></param>
        /// <returns>Returns ActionResult of type office</returns>
        /// <remarks>
        /// Sample request (this request updates the author's location)
        /// </remarks>

        // PUT: api/Offices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffice([FromRoute] int id,[FromBody] Office office)
        {
            if (id != office.Id)
            {
                return BadRequest();
            }

            _context.Entry(office).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        /// <summary>
        /// This is post method in office class
        /// </summary>
        /// <param name="office"></param>
        /// <param name="id"></param>
        /// <returns></returns>
       
        //[HttpPatch("{id}")]
        //public async Task<IActionResult> UpdateOfficePatch([FromRoute] int id,[FromBody] JsonPatchDocument office)
        //{
        //    var result = await _context.AddRangeAsync(office);
        //    return Ok(result);
        //}
       
        //POST: api/Offices
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Office>> PostOffice(Office office)
        {
            _context.Offices.Add(office);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOffice", new { id = office.Id }, office);
        }

        // DELETE: api/Offices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffice(int id)
        {
            var office = await _context.Offices.FindAsync(id);
            if (office == null)
            {
                return NotFound();
            }

            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfficeExists(int id)
        {
            return _context.Offices.Any(e => e.Id == id);
        }
    }
}
