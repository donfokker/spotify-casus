using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Casus {
    internal class Client : iPlayable  {
        static void Main(string[] args) {
          
        }
        public int CurrentTime { get; set; }
        public bool Playing { get; set; }
        public bool Shuffle { get; set; }
        public bool repeat { get; set; }


    }
}
