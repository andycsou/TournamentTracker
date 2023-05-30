using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// một đội trong trận đấu
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// điểm số của một đội cụ thể
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// show ra đội này đã thắng từ trận nào trước đó
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
