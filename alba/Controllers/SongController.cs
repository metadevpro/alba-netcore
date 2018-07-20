using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using alba.Services;
using alba.Models;
using System;
using Metadev.Oas3.Attributes;

namespace alba.Controllers
{
    [Route("api/songs")]
    [Tag("Song")]
    public class SongController : Controller
    {
        private SongService songService;

        public SongController(SongService songService)
        {
            this.songService = songService;
        }

        // GET: api/songs
        [HttpGet]
        [Operation("getSong")]
        [Tag("query")]
        [Description("Retrieves a list of songs.")]
        [Summary("Main endpoint to retrieve lists of songs.")]
        public IEnumerable<Song> Get()
        {
            return songService.Get();
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        [Operation("getSongById")]
        [Tag("queryById")]
        [Description("Retrieves a song by Id.")]
        [Response(200, "Song returned", typeof(Song))]
        [Response(404, "Not found", null)]
        [Response(500, "Server Error", typeof(string))]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(songService.GetById(id));
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/songs
        [HttpPost]
        [Operation("createSong")]
        [Tag("create")]
        [Description("Creates a new song.")]
        public Song Post([FromBody]Song payload)
        {
            return songService.Create(payload);
        }

        // PUT api/songs/5
        [HttpPut("{id}")]
        [Tag("modify")]
        [Operation("updateSong")]
        [Description("Modifies a new song.")]
        public Song Put(string id, [FromBody]Song payload)
        {
            return songService.Update(id, payload);
        }

        // DELETE api/songs/5
        [HttpDelete("{id}")]
        [Tag("delete")]
        [Operation("deleteSong")]
        [Description("Deletes a song by Id.")]
        public Song Delete(string id)
        {
            return songService.Delete(id);
        }
    }
}
