using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoBackend.Data;
using ProjetoBackend.Models;

namespace ProjetoBackend.Controllers
{
    public class ItensComprasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItensComprasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItensCompras
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ItensCompra.Include(i => i.Compra).Include(i => i.Produto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ItensCompras/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItensCompra
                .Include(i => i.Compra)
                .Include(i => i.Produto)
                .FirstOrDefaultAsync(m => m.ItemCompraId == id);
            if (itemCompra == null)
            {
                return NotFound();
            }

            return View(itemCompra);
        }

        // GET: ItensCompras/Create
        public IActionResult Create()
        {
            ViewData["CompraId"] = new SelectList(_context.Compras, "CompraId", "CompraId");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome");
            return View();
        }

        // POST: ItensCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemCompraId,CompraId,ProdutoId,Quantidade")] ItemCompra itemCompra)
        {
            if (ModelState.IsValid)
            {
                itemCompra.ItemCompraId = Guid.NewGuid();
                _context.Add(itemCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompraId"] = new SelectList(_context.Compras, "CompraId", "CompraId", itemCompra.CompraId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome", itemCompra.ProdutoId);
            return View(itemCompra);
        }

        // GET: ItensCompras/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItensCompra.FindAsync(id);
            if (itemCompra == null)
            {
                return NotFound();
            }
            ViewData["CompraId"] = new SelectList(_context.Compras, "CompraId", "CompraId", itemCompra.CompraId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome", itemCompra.ProdutoId);
            return View(itemCompra);
        }

        // POST: ItensCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ItemCompraId,CompraId,ProdutoId,Quantidade")] ItemCompra itemCompra)
        {
            if (id != itemCompra.ItemCompraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemCompraExists(itemCompra.ItemCompraId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompraId"] = new SelectList(_context.Compras, "CompraId", "CompraId", itemCompra.CompraId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome", itemCompra.ProdutoId);
            return View(itemCompra);
        }

        // GET: ItensCompras/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItensCompra
                .Include(i => i.Compra)
                .Include(i => i.Produto)
                .FirstOrDefaultAsync(m => m.ItemCompraId == id);
            if (itemCompra == null)
            {
                return NotFound();
            }

            return View(itemCompra);
        }

        // POST: ItensCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var itemCompra = await _context.ItensCompra.FindAsync(id);
            if (itemCompra != null)
            {
                _context.ItensCompra.Remove(itemCompra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemCompraExists(Guid id)
        {
            return _context.ItensCompra.Any(e => e.ItemCompraId == id);
        }
    }
}
