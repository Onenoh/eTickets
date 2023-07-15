using System.Collections;
using System.Collections.Generic;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActors
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
