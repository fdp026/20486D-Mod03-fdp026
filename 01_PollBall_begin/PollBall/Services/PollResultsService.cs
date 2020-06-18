using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollBall.Services
{
    public class PollResultsService : IPollResultsService
    {
        private Dictionary<SelectedGame, int> _selectedVotes;

        public PollResultsService()
        {
            _selectedVotes = new Dictionary<SelectedGame, int>();
        }

        public void AddVote(SelectedGame game)
        {
            if ( _selectedVotes.ContainsKey(game))
            {
                _selectedVotes[game]++;
            }
            else
            {
                _selectedVotes.Add(game, 1);
            }
        }

        public SortedDictionary<SelectedGame, int> GetVoteResult()
        {
            return new SortedDictionary<SelectedGame, int>(_selectedVotes);
        }
    }
}
