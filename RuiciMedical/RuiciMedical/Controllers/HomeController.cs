using System.Collections.Generic;
using System.Web.Mvc;

namespace RuiciMedical.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeInfoViewModel homeInfoViewModel = new HomeInfoViewModel();
            List<RecentVisitExpertsGroupViewModel> recentVisitExpertsGroupLists = new List<RecentVisitExpertsGroupViewModel>();
            RecentVisitExpertsGroupViewModel recentVisitExpertsGroup = new RecentVisitExpertsGroupViewModel();

            List<RecentVisitExpertsViewModel> recentVisitExpertsLists = new List<RecentVisitExpertsViewModel>();
            //宋冬雷
            RecentVisitExpertsViewModel recentVisitExpertsViewModel1 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel1.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel1.Title = "外科-主任医生";
            recentVisitExpertsViewModel1.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel1.Image = "../assets/pages/img/avatars/team8.jpg";
            recentVisitExpertsViewModel1.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists.Add(recentVisitExpertsViewModel1);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel2 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel2.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel2.Title = "外科-主任医生";
            recentVisitExpertsViewModel2.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel2.Image = "../assets/pages/img/avatars/team7.jpg";
            recentVisitExpertsViewModel2.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists.Add(recentVisitExpertsViewModel2);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel3 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel3.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel3.Title = "外科-主任医生";
            recentVisitExpertsViewModel3.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel3.Image = "../assets/pages/img/avatars/team6.jpg";
            recentVisitExpertsViewModel3.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists.Add(recentVisitExpertsViewModel3);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel4 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel4.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel4.Title = "外科-主任医生";
            recentVisitExpertsViewModel4.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel4.Image = "../assets/pages/img/avatars/team5.jpg";
            recentVisitExpertsViewModel4.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists.Add(recentVisitExpertsViewModel4);

            recentVisitExpertsGroup.RecentVisitExperts = recentVisitExpertsLists;
            recentVisitExpertsGroupLists.Add(recentVisitExpertsGroup);

            List<RecentVisitExpertsViewModel> recentVisitExpertsLists1 = new List<RecentVisitExpertsViewModel>();
            RecentVisitExpertsGroupViewModel recentVisitExpertsGroup1 = new RecentVisitExpertsGroupViewModel();
            //宋冬雷
            RecentVisitExpertsViewModel recentVisitExpertsViewModel11 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel11.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel11.Title = "外科-主任医生";
            recentVisitExpertsViewModel11.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel11.Image = "../assets/pages/img/avatars/team4.jpg";
            recentVisitExpertsViewModel11.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists1.Add(recentVisitExpertsViewModel11);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel12 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel12.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel12.Title = "外科-主任医生";
            recentVisitExpertsViewModel12.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel12.Image = "../assets/pages/img/avatars/team3.jpg";
            recentVisitExpertsViewModel12.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists1.Add(recentVisitExpertsViewModel12);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel13 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel13.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel13.Title = "外科-主任医生";
            recentVisitExpertsViewModel13.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel13.Image = "../assets/pages/img/avatars/team2.jpg";
            recentVisitExpertsViewModel13.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists1.Add(recentVisitExpertsViewModel13);

            RecentVisitExpertsViewModel recentVisitExpertsViewModel14 = new RecentVisitExpertsViewModel();

            recentVisitExpertsViewModel14.DoctorName = "宋冬雷";
            recentVisitExpertsViewModel14.Title = "外科-主任医生";
            recentVisitExpertsViewModel14.Hospital = "上海瑞慈医院";
            recentVisitExpertsViewModel14.Image = "../assets/pages/img/avatars/team1.jpg";
            recentVisitExpertsViewModel14.Synopsis = "擅长：脉动肿瘤";

            recentVisitExpertsLists1.Add(recentVisitExpertsViewModel14);
            recentVisitExpertsGroup1.RecentVisitExperts = recentVisitExpertsLists1;
            recentVisitExpertsGroupLists.Add(recentVisitExpertsGroup1);

            homeInfoViewModel.RecentVisitExpertsGroup = recentVisitExpertsGroupLists;
            return View(homeInfoViewModel);
        }
    }
}