using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FluentApi.Config;
using FluentApi.Models;
using FluentApi.Interfaces;

namespace FluentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DbModelContext _context;
        InterfaceResult interfaceResult = new InterfaceResult();

        public ProductsController(DbModelContext context)
        {
            _context = context;
        }

        // GET: api/Products     OBTENER TODOS
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        // GET: api/Products/5    OBTENER SOLO UNO
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return StatusCode(401, "No se encontro el registro");
            }

            return Ok(product);
        }

        // PUT: api/Products/5      ACTUALIZAR
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                //return BadRequest();
                return StatusCode(400, "El id que envio no coincide");
              
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return new JsonResult(new InterfaceResult { Status = true, Message = "Registro Actualizado" });
        }

       

        // POST: api/Products     INSERTAR
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(400, "Los datos son incorrectos");
                }
                _context.Products.Add(product);

                await _context.SaveChangesAsync();
                return new JsonResult(new InterfaceResult { Status = true, Message = "Todo salio bien" });
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno");
            }
        }


        // DELETE: api/Products/5   ELIMINAR
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return StatusCode(400, "El id que envio no coincide");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return new JsonResult(new InterfaceResult { Status = true, Message = "El registro se ha eliminado" });
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}