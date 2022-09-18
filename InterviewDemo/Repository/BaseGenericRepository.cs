using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.DTO;
using InterviewDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace InterviewDemo.Repository
{
    public abstract class BaseGenericRepository<T, U> : IBaseGenericRepository<U> where T : EntityBase where U : EntityBaseDTO
    {
        private readonly DataEFContext _context;
        protected readonly DbSet<T> _entities;
        protected readonly IMapper _mapper;
        public BaseGenericRepository(DataEFContext context, IMapper mapper)
        {
            _context = context;
            _entities = _context.Set<T>();
            _mapper = mapper;
        }

        public virtual async Task<int> Add(U entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            await _entities.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<int> Delete(U entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _entities.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<U?> Get(int id) 
        {
            var entity = await _entities.FirstOrDefaultAsync(e => e.Id == id);
            return _mapper.Map<U>(entity);
        } 

        public virtual async Task<ICollection<U>> GetAll()
        {
            var entities = await _entities.ToListAsync();
            return _mapper.Map<ICollection<U>>(entities);
        }

        public virtual async Task<int> Update(U entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _entities.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
