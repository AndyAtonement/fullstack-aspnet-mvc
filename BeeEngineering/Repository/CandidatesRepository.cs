using BeeEngineering.Data;
using BeeEngineering.Models;

namespace BeeEngineering.Repository
{
    public class CandidatesRepository : ICandidatesRepository
    {
        private readonly DataContext _context;

        public CandidatesRepository(DataContext context)
        {
            _context = context;
        }

        public CandidateModel Create(CandidateModel candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
            return candidate;
        }

        public List<CandidateModel> GetAll()
        {
            return _context.Candidates.ToList();
        }

        public CandidateModel GetById(int id)
        {
            return _context.Candidates.FirstOrDefault(x => x.Id == id);
        }

        public CandidateModel Update(CandidateModel candidate)
        {
            _context.Candidates.Update(candidate);
            _context.SaveChanges();
            return candidate;
        }
        
        public bool Delete(int id)
        {
            CandidateModel candidateDB = GetById(id);

            if (candidateDB == null) throw new Exception("Unexpected error deleting the candidadte");
            if (candidateDB == null) throw new Exception("Unexpected error deleting the candidadte");
            
            _context.Candidates.Remove(candidateDB);
            _context.SaveChanges();

            return true;
        }
                
    }
}
