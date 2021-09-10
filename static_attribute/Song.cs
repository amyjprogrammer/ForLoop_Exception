using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_attribute
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; //static attribute
        /*
          you can enter Console.WriteLine(Song.songCount) and it would show zero until a song is created
         */
        

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; //added one to the count everytime a new Song object is created
        }

        public int getsongCount()
        {
            return songCount;
        }
    }
}
