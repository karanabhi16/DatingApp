using AutoMapper;
using DatingApp.API.Models;
using DatingApp.API.Models.SendModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDetail, UserDetailsSend>().ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(pic => pic.Photos.FirstOrDefault(p => p.IsMain).Url);
            }).ForMember(dest => dest.Age, opt =>
            {
                opt.ResolveUsing(p => CalculateAge(p.DateOfBirth));
            });
            CreateMap<UserDetail, UserListSend>().ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(pic => pic.Photos.FirstOrDefault(p => p.IsMain).Url);
            }).ForMember(dest => dest.Age, opt =>
            {
                opt.ResolveUsing(a => (DateTime.Now - a.DateOfBirth));
            });
            CreateMap<Photo, PhotoDetailSend>();
        }

        public static int CalculateAge(DateTime givenDate)
        {
            int age = DateTime.Today.Year - givenDate.Year;
            if (givenDate.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
    }
}
