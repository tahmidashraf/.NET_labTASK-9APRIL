using BILL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.Service
{
    public class MemberService
    {
        public static List<MemberDTO> Get()
        {
            var data = DataAccessFactory.MemberData().Get();
            return Convert(data);
        }
        public static MemberDTO Get(int id)
        {
            return Convert(DataAccessFactory.MemberData().Get(id));
        }
        public static MemberDTO Insert(MemberDTO member)
        {
            var data = Convert(member);
            var ret = DataAccessFactory.MemberData().Insert(data);
            return Convert(ret);
        }

        public static MemberDTO Update(MemberDTO member)
        {
            var data = Convert(member);
            var ret = DataAccessFactory.MemberData().Update(data);
            return Convert(ret);
        }
        public static MemberDTO Delete(int id)
        {

            return Convert(DataAccessFactory.MemberData().Delete(id));
        }

        static MemberDTO Convert(Member member)
        {
            return new MemberDTO
            {
                Id = member.Id,
                Name = member.Name,
                Role= member.Role,
                PId= member.PId,

            };
        }

        static Member Convert(MemberDTO memberDTO)
        {
            return new Member
            {

                Id = memberDTO.Id,
                Name = memberDTO.Name,
                Role = memberDTO.Role,
                PId = memberDTO.PId,

            };
        }

        static List<MemberDTO> Convert(List<Member> members )
        {

            var data = new List<MemberDTO>();
            foreach (var member in members)
            {
                data.Add(Convert(member));
            }
            return data;

        }
        static List<Member> Convert(List<MemberDTO> memberDTO)
        {

            var data = new List<Member>();
            foreach (var member in memberDTO)
            {
                data.Add(Convert(member));
            }
            return data;

        }
    }
}
