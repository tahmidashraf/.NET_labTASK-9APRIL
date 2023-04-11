using BILL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace BILL.Service
{
    public class ProjectService
    {
        public static List<ProjectDTO> Get()

        {
            var data = DataAccessFactory.P().Get();
            return Convert(data);
        }
        public static ProjectDTO Get(int id)
        {
            return Convert(DataAccessFactory.ProjectData().Get(id));
        }
        public static ProjectDTO Insert(ProjectDTO project)
        {
          var data = Convert(project);
            var ret = DataAccessFactory.ProjectData().Insert(data);
            return Convert(ret);
        }

        public static ProjectDTO Update(ProjectDTO project)
        {
          var data = Convert(project);
            var ret = DataAccessFactory.ProjectData().Update(data);
            return Convert(ret);
        }
        public static Project Delete(int id)
        {

            return DataAccessFactory.ProjectData().Delete(id);
        }

        static ProjectDTO Convert(Project project)
        {
            return new ProjectDTO
            {
                Id = project.Id,
                Title = project.Title,
                Status= project.Status,
                StartDate=project.StartDate,
                EndDate=project.EndDate,
            };
        }

        static Project Convert(ProjectDTO projectDTO)
        {
            return new Project
            {

                Id = projectDTO.Id,
                Title = projectDTO.Title,
                Status = projectDTO.Status,
                StartDate = projectDTO.StartDate,
                EndDate = projectDTO.EndDate,

            };
        }

        static List<ProjectDTO> Convert(List<Project> projects)
        {

            var data = new List<ProjectDTO>();
            foreach (var project in projects)
            {
                data.Add(Convert(project));
            }
            return data;

        }
    }
}
