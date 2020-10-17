using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PortalRandkowy.API.Data;
using PortalRandkowy.API.Models;

namespace PortalRandkowy.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;

        public ValuesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var values = await context.Values.ToListAsync();
            return Ok(values);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var value = await context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<ActionResult<Value>> Post(Value value)
        {
            context.Values.Add(value);
            await context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut("{id}")]
        public async void EditValue(int id, Value value)
        {
            var data = context.Values.Find(id);
            data.Name = value.Name;
            context.Values.Update(data);
            await context.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async void EditValue(int id)
        {
            var data = context.Values.Find(id);
            context.Values.Remove(data);
            await context.SaveChangesAsync();
        }
    }
}