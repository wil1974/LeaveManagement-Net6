using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using System.Runtime.InteropServices;

namespace LeaveManagement.Web.Configurations
{

    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
