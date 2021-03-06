﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumProject.Data;
using AlbumProject.Models;
using AlbumProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private IRepository<Song> songRepo;

        public SongController(IRepository<Song> songRepo)
        {
            this.songRepo = songRepo;
        }

        // GET: api/Song
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songRepo.GetAll();
        }

        // GET: api/Song/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return songRepo.GetById(id);
        }

        // POST: api/Song
        [HttpPost]
        public IEnumerable<Song> Post([FromBody] Song song)
        {
            songRepo.Create(song);
            return songRepo.GetAll();

        }

        // PUT: api/Song/5
        [HttpPut("{id}")]
        public IEnumerable<Song> Put([FromBody] Song song)
        {
            songRepo.Update(song);
            return songRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Song> Delete(int id)
        {
            var deleteSong = songRepo.GetById(id);
            songRepo.Delete(deleteSong);
            return songRepo.GetAll();
        }
    }
}
