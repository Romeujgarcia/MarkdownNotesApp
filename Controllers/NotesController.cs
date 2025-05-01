using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Markdig;
using MarkdownNotesApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkdownNotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private static int _noteIdCounter = 1;
        private static readonly List<Note> _notes = new List<Note>();

        // Endpoint para verificar a gramática
        [HttpPost("check-grammar")]
        public async Task<IActionResult> CheckGrammar([FromBody] TextDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Text))
                return BadRequest("Text cannot be empty.");

            var grammarErrors = await CheckGrammarAsync(dto.Text);
            return Ok(grammarErrors);
        }

        // Endpoint para salvar a nota
        [HttpPost("save")]
        public async Task<IActionResult> SaveNote([FromBody] Note note)
        {
            if (note == null || string.IsNullOrWhiteSpace(note.Content))
                return BadRequest("Note content cannot be empty.");

            note.Id = _noteIdCounter++;
            note.HtmlContent = Markdown.ToHtml(note.Content);
            _notes.Add(note);
            return CreatedAtAction(nameof(GetNoteById), new { id = note.Id }, note);
        }

        // Endpoint para listar notas salvas
        [HttpGet("list")]
        public IActionResult ListNotes()
        {
            return Ok(_notes);
        }

        // Endpoint para obter a versão HTML da nota
        [HttpGet("{id}")]
        public IActionResult GetNoteById(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
                return NotFound();

            return Ok(note.HtmlContent);
        }

        private async Task<List<string>> CheckGrammarAsync(string text)
        {
            // Aqui você pode implementar ou simular a verificação gramatical, por enquanto retorna lista vazia
            await Task.CompletedTask;
            return new List<string>(); 
        }
    }
}