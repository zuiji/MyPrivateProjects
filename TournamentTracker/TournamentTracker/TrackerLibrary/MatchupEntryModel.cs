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
        /// Represents one team in the match up.
        /// </summary>

        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the Score for the Particular team.
        /// </summary>

        public double Score { get; set; }

        /// <summary>
        /// Represents the match up that this team come from as the winner.
        /// </summary>

        public MatchupModel ParentMatchup { get; set; }
    }
}
