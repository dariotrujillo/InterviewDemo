using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.Automapper;
using InterviewDemo.DataContext;
using InterviewDemo.Model;
using InterviewDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InterviewDemoTests
{
    [TestClass]
    public class UnitTest
    {
     
        //[TestMethod]
        //public void GetPackage()
        //{
        //    DataEFContext context = new DataEFContext(new DbContextOptionsBuilder().Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        //    IMapper mapper = new Mapper(new MapperConfiguration(mc => {
        //        mc.AddProfile(new AutomapperProfiles());
        //    }));

        //    context.Set<Package>();

        //    PackageService service = new PackageService(context, mapper);

        //    var a = service.GetAll();
        //    Assert.IsNotNull(a);
        //}
    }
}