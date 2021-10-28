using System;
using System.Collections.Generic;

namespace Models
{
    public class Turn
    {
        public Turn() {}
        public int Id {get; set;}
        public int playerId {get; set;}
        public int targetId {get; set;}
        public int matchId {get; set;}
        public int shotLocation {get; set;}
        public int turnNumber {get; set;}
    }
}