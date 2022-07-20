using BeeEngineering.Models;

namespace BeeEngineering.Repository
{
    public interface ICandidatesRepository
    {
        CandidateModel Create(CandidateModel candidate);
        List<CandidateModel> GetAll();
        CandidateModel GetById(int id);
        CandidateModel Update(CandidateModel candidate);
        bool Delete(int id);

    }
}
