using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using algStorage.DAL.Repositories;
using algStorage.DAL.Entities;

namespace algStorage.BLL
{
    public class GroupOperation
    {
        private AccessGroupRepository accessGroupRepository;

        public GroupOperation()
        {
            accessGroupRepository = new AccessGroupRepository();
        }

        public bool AddAccess(int userId, int algorithmId)
        {
            try
            {
                accessGroupRepository.Create(new AccessGroup { UserId = userId, AlgorithmId = algorithmId });
                accessGroupRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAccess(int userId, int algorithmId)
        {
            try
            {
                var item = accessGroupRepository.GetAll().Single(ag => ag.UserId == userId & ag.AlgorithmId == algorithmId);
                accessGroupRepository.Delete(item.Id);
                accessGroupRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<int> GetUsersWithAccess(int algorithmId)
        {
            try
            {
                List<int> result = new List<int>();
                var List = accessGroupRepository.GetAll().Where(ag => ag.AlgorithmId == algorithmId);
                foreach(var l in List)
                {
                    result.Add(l.UserId);
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<int> GetAccessedAlgorithms(int userId)
        {
            try
            {
                List<int> result = new List<int>();
                var List = accessGroupRepository.GetAll().Where(ag => ag.UserId == userId);
                foreach (var l in List)
                {
                    result.Add(l.AlgorithmId);
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
