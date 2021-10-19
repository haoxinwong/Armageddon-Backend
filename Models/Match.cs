using System.Collections.Generic;

namespace Models
{
    public class Match
    {
        public Match() {
            this.OpponentIds = new List<int>();
        }
        public Match(int id, int hostId, int turnCount, int winnerId) : this()
        {
            this.Id = id;
            this.HostId = hostId;
            this.TurnCount = turnCount;
            this.WinnerId = winnerId;

        }
        public int Id { get; set; }
        public int HostId { get; set; }
        public int TurnCount { get; set; }
        public int WinnerId { get; set; }
        List<int> OpponentIds { get; set; }

    }
}