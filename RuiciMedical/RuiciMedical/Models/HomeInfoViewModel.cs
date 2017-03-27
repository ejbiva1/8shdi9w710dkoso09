using System.Collections.Generic;

namespace RuiciMedical
{
    public class HomeInfoViewModel
    {
        public List<RecentVisitExpertsGroupViewModel> RecentVisitExpertsGroup { get; set; }
    }

    public class RecentVisitExpertsGroupViewModel
    {

        public List<RecentVisitExpertsViewModel> RecentVisitExperts { get; set; }
    }

}