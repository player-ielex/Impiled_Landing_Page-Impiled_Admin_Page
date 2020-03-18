using System.Web.Mvc;

namespace Project_Impiled.Controllers
{

    [OutputCache(NoStore = true, Duration = 1)]
    public class DashboardController : Controller
    {

        // GET: Dashboard
        public ActionResult AllAnnouncement()
        {
            return View();
        }


        public ActionResult AddAnnouncement()
        {
            return View();
        }

        public ActionResult TermsandCondition()
        {
            return View();
        }


        public ActionResult AssignTeachers()
        {
            return View();
        }

        public ActionResult CompleteRewards()
        {
            return View();
        }

        public ActionResult PendingRewards()
        {
            return View();
        }

        public ActionResult AssignStudents()
        {
            return View();
        }

        public ActionResult CUTeachers()
        {
            return View();
        }

        public ActionResult AllTeachers()
        {
            return View();
        }

        public ActionResult CUStudents()
        {
            return View();
        }

        public ActionResult AllStudents()
        {
            return View();
        }

        public ActionResult ReCategory()
        {
            return View();
        }

        public ActionResult Rewards()
        {
            return View();
        }

        public ActionResult AllRewards()
        {
            return View();
        }

        public ActionResult Sections()
        {
            return View();
        }

        public ActionResult GradeLevel()
        {
            return View();
        }

        public ActionResult Subjects()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult MeetTheTeam()
        {
            return View();
        }

    }
}