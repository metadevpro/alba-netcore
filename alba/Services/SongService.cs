using System;
using System.Collections.Generic;
using alba.Models;
using alba.Repositories;

namespace alba.Services
{
    public class SongService
    {
        private InMemoryRepository<Song> repository;
        public SongService(InMemoryRepository<Song> repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Song> Get()
        {
            return repository.Get();
        }

        public Song GetById(string id)
        {
            return repository.GetById(id);
        }

        public Song Create(Song payload)
        {
            payload.CreatedAt = DateTime.Now;
            payload.ModifiedAt = DateTime.Now;
            return repository.Create(payload);
        }

        public Song Update(string id, Song payload)
        {
            payload.ModifiedAt = DateTime.Now;
            return repository.Update(id, payload);
        }

        public Song Delete(string id)
        {
            return repository.Delete(id);
        }
    }
}
