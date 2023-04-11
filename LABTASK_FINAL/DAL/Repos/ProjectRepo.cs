using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProjectRepo : Repo, IRepo<Project, int, Project>
    {
        public Project Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> Get()
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public Project Insert(Project obj)
        {
            throw new NotImplementedException();
        }

        public Project Update(Project obj)
        {
            throw new NotImplementedException();
        }
    }
}
