using System;
using System.Collections.Generic;

namespace RuiciMedical
{
    public class HomeInfoViewModel
    {
        public Dictionary<String, String> DateTimeListsGroup { get; set; }
        public List<RecentVisitExpertsGroupViewModel> RecentVisitExpertsGroup { get; set; }
    }

    public class RecentVisitExpertsGroupViewModel
    {

        public List<RecentVisitExpertsViewModel> RecentVisitExperts { get; set; }
    }

    public class DateTimeListsViewModel
    {

        public Dictionary<String, String> DateTimeLists { get; set; }
    }

}