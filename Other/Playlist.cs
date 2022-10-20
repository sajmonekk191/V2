using NAudio.Wave;
using System.Windows.Forms;

namespace VoidSharp.Other
{
    class Playlist
    {
        public static int curenttrack = 0;
        public static readonly string url = @"http://81.162.196.29/server/";
        public static string[] songs = new string[]
        {
               url + "ABCDEFU.wav",
               url + "Beforeyougo.wav",
               url + "Imposible.wav",
               url + "LielessxScrubnoob.wav",
               url + "royalty.wav",
               url + "shutup.mp3",
               url + "LeanOn.mp3",
               url + "Shrek10.mp3",
               url + "roses.mp3",
               url + "NewYork.mp3",
               url + "SomeSay.mp3",
               url + "SadEmo.mp3",
               url + "Payphone.mp3",
               url + "HSK.mp3",
               url + "Hangover.mp3",
               url + "Pepas.mp3",
               url + "timber.mp3",
               url + "Hearth.mp3",
               url + "OnlyGirl.mp3",
               url + "LoveStory.mp3",
               url + "Letitgo.mp3",
               url + "Gravityfalls.mp3",
               url + "xdd.mp3",
               url + "dontletmedown.mp3",
               url + "morethanyouknow.mp3",
               url + "somebodywatching.mp3",
               url + "STS.mp3",
               url + "ShutupHardstyle.mp3",
               url + "001.mp3",
               url + "takealot.mp3",
               url + "sweathers.mp3",
               url + "kidsnotalone.mp3",
               url + "justdance.mp3",
               url + "goodmood.mp3",
               url + "paparazii.mp3",
               url + "somertime.mp3",
               url + "everytimetouch.mp3",
               url + "waitingallnight.mp3",
               url + "safeandsound.mp3",
               url + "lsdproblem.mp3",
               url + "stereolove.mp3",
               url + "rockstar.mp3",
               url + "runaway.mp3",
               url + "scaredlonely.mp3",
               url + "countystar.mp3",
               url + "stupidump.mp3",
               url + "infinity.mp3",
               url + "prayerinC.mp3",
               url + "kissme.mp3",
        };
        public static void LoadBangers(Banger b)
        {
            b.playlist.Items.Add("ABCDEFU");
            b.playlist.Items.Add("Before You Go");
            b.playlist.Items.Add("Imposible");
            b.playlist.Items.Add("Lieless x Scrubnoob");
            b.playlist.Items.Add("Royalty");
            b.playlist.Items.Add("Shut Up And Dance With Me");
            b.playlist.Items.Add("Lean On");
            b.playlist.Items.Add("Shrek10");
            b.playlist.Items.Add("Roses");
            b.playlist.Items.Add("NewYork");
            b.playlist.Items.Add("Some Say");
            b.playlist.Items.Add("Sad Emo");
            b.playlist.Items.Add("Payphone");
            b.playlist.Items.Add("Head Shoulders Knees and Toes");
            b.playlist.Items.Add("Hangover");
            b.playlist.Items.Add("Pepas");
            b.playlist.Items.Add("Timber");
            b.playlist.Items.Add("Hearth to Hearth");
            b.playlist.Items.Add("OnlyGirl");
            b.playlist.Items.Add("LoveStory");
            b.playlist.Items.Add("Let It Go x Wildest Dreams");
            b.playlist.Items.Add("Gravity Falls");
            b.playlist.Items.Add("XDDXDXDXD");
            b.playlist.Items.Add("Dont Let Me Down");
            b.playlist.Items.Add("More Than You Know");
            b.playlist.Items.Add("Somebody is Watching Me");
            b.playlist.Items.Add("Save That Shit");
            b.playlist.Items.Add("Shut Up and Dance (Hardstyle)");
            b.playlist.Items.Add("001");
            b.playlist.Items.Add("Its Gona Take A Lot");
            b.playlist.Items.Add("Sweather Weather");
            b.playlist.Items.Add("The Kids arent Alone");
            b.playlist.Items.Add("Just Dance");
            b.playlist.Items.Add("Good Mood");
            b.playlist.Items.Add("Paparazii");
            b.playlist.Items.Add("Summertime Sadness");
            b.playlist.Items.Add("Everytime We Touch");
            b.playlist.Items.Add("Waiting All Night");
            b.playlist.Items.Add("Safe and Sound");
            b.playlist.Items.Add("LSD Problem");
            b.playlist.Items.Add("Stereo Love");
            b.playlist.Items.Add("RockStar");
            b.playlist.Items.Add("RunAway");
            b.playlist.Items.Add("Scared To Be Lonely");
            b.playlist.Items.Add("Counting Stars");
            b.playlist.Items.Add("Are You Stupid?");
            b.playlist.Items.Add("Infinity <3");
            b.playlist.Items.Add("Prayers in C");
            b.playlist.Items.Add("KISS ME");
        }
        public static void ChangeBanger(Banger b)
        {
            switch (b.playlist.SelectedItem.ToString().Trim())
            {
                case "ABCDEFU":
                    curenttrack = 0;
                    PlayMusic(Other.Playlist.songs[0]);
                    break;
                case "Before You Go":
                    curenttrack = 1;
                    PlayMusic(Other.Playlist.songs[1]);
                    break;
                case "Imposible":
                    curenttrack = 2;
                    PlayMusic(Other.Playlist.songs[2]);
                    break;
                case "Lieless x Scrubnoob":
                    curenttrack = 3;
                    PlayMusic(Other.Playlist.songs[3]);
                    break;
                case "Royalty":
                    curenttrack = 4;
                    PlayMusic(Other.Playlist.songs[4]);
                    break;
                case "Shut Up And Dance With Me":
                    curenttrack = 5;
                    PlayMusic(Other.Playlist.songs[5]);
                    break;
                case "Lean On":
                    curenttrack = 6;
                    PlayMusic(Other.Playlist.songs[6]);
                    break;
                case "Shrek10":
                    curenttrack = 7;
                    PlayMusic(Other.Playlist.songs[7]);
                    break;
                case "Roses":
                    curenttrack = 8;
                    PlayMusic(Other.Playlist.songs[8]);
                    break;
                case "NewYork":
                    curenttrack = 9;
                    PlayMusic(Other.Playlist.songs[9]);
                    break;
                case "Some Say":
                    curenttrack = 10;
                    PlayMusic(Other.Playlist.songs[10]);
                    break;
                case "Sad Emo":
                    curenttrack = 11;
                    PlayMusic(Other.Playlist.songs[11]);
                    break;
                case "Payphone":
                    curenttrack = 12;
                    PlayMusic(Other.Playlist.songs[12]);
                    break;
                case "Head Shoulders Knees and Toes":
                    curenttrack = 13;
                    PlayMusic(Other.Playlist.songs[13]);
                    break;
                case "Hangover":
                    curenttrack = 14;
                    PlayMusic(Other.Playlist.songs[14]);
                    break;
                case "Pepas":
                    curenttrack = 15;
                    PlayMusic(Other.Playlist.songs[15]);
                    break;
                case "Timber":
                    curenttrack = 16;
                    PlayMusic(Other.Playlist.songs[16]);
                    break;
                case "Hearth to Hearth":
                    curenttrack = 17;
                    PlayMusic(Other.Playlist.songs[17]);
                    break;
                case "OnlyGirl":
                    curenttrack = 18;
                    PlayMusic(Other.Playlist.songs[18]);
                    break;
                case "LoveStory":
                    curenttrack = 19;
                    PlayMusic(Other.Playlist.songs[19]);
                    break;
                case "Let It Go x Wildest Dreams":
                    curenttrack = 20;
                    PlayMusic(Other.Playlist.songs[20]);
                    break;
                case "Gravity Falls":
                    curenttrack = 21;
                    PlayMusic(Other.Playlist.songs[21]);
                    break;
                case "XDDXDXDXD":
                    curenttrack = 22;
                    PlayMusic(Other.Playlist.songs[22]);
                    break;
                case "Dont Let Me Down":
                    curenttrack = 23;
                    PlayMusic(Other.Playlist.songs[23]);
                    break;
                case "More Than You Know":
                    curenttrack = 24;
                    PlayMusic(Other.Playlist.songs[24]);
                    break;
                case "Somebody is Watching Me":
                    curenttrack = 25;
                    PlayMusic(Other.Playlist.songs[25]);
                    break;
                case "Save That Shit":
                    curenttrack = 26;
                    PlayMusic(Other.Playlist.songs[26]);
                    break;
                case "Shut Up and Dance (Hardstyle)":
                    curenttrack = 27;
                    PlayMusic(Other.Playlist.songs[27]);
                    break;
                case "001":
                    curenttrack = 28;
                    PlayMusic(Other.Playlist.songs[28]);
                    break;
                case "Its Gona Take A Lot":
                    curenttrack = 29;
                    PlayMusic(Other.Playlist.songs[29]);
                    break;
                case "Sweather Weather":
                    curenttrack = 30;
                    PlayMusic(Other.Playlist.songs[30]);
                    break;
                case "The Kids arent Alone":
                    curenttrack = 31;
                    PlayMusic(Other.Playlist.songs[31]);
                    break;
                case "Just Dance":
                    curenttrack = 32;
                    PlayMusic(Other.Playlist.songs[32]);
                    break;
                case "Good Mood":
                    curenttrack = 33;
                    PlayMusic(Other.Playlist.songs[33]);
                    break;
                case "Paparazii":
                    curenttrack = 34;
                    PlayMusic(Other.Playlist.songs[34]);
                    break;
                case "Summertime Sadness":
                    curenttrack = 35;
                    PlayMusic(Other.Playlist.songs[35]);
                    break;
                case "Everytime We Touch":
                    curenttrack = 36;
                    PlayMusic(Other.Playlist.songs[36]);
                    break;
                case "Waiting All Night":
                    curenttrack = 37;
                    PlayMusic(Other.Playlist.songs[37]);
                    break;
                case "Safe and Sound":
                    curenttrack = 38;
                    PlayMusic(Other.Playlist.songs[38]);
                    break;
                case "LSD Problem":
                    curenttrack = 39;
                    PlayMusic(Other.Playlist.songs[39]);
                    break;
                case "Stereo Love":
                    curenttrack = 40;
                    PlayMusic(Other.Playlist.songs[40]);
                    break;
                case "RockStar":
                    curenttrack = 41;
                    PlayMusic(Other.Playlist.songs[41]);
                    break;
                case "RunAway":
                    curenttrack = 42;
                    PlayMusic(Other.Playlist.songs[42]);
                    break;
                case "Scared To Be Lonely":
                    curenttrack = 43;
                    PlayMusic(Other.Playlist.songs[43]);
                    break;
                case "Counting Stars":
                    curenttrack = 44;
                    PlayMusic(Other.Playlist.songs[44]);
                    break;
                case "Are You Stupid?":
                    curenttrack = 45;
                    PlayMusic(Other.Playlist.songs[45]);
                    break;
                case "Infinity <3":
                    curenttrack = 46;
                    PlayMusic(Other.Playlist.songs[46]);
                    break;
                case "Prayers in C":
                    curenttrack = 47;
                    PlayMusic(Other.Playlist.songs[47]);
                    break;
                case "KISS ME":
                    curenttrack = 27;
                    PlayMusic(Other.Playlist.songs[48]);
                    break;
            }
        }
        public static void PlayMusic(string url)
        {
            Banger.stream = new MediaFoundationReader(url);
            Banger.wo.Stop();
            Banger.wo = new WasapiOut();
            Banger.wo.Init(Banger.stream);
            Banger.wo.Play();
        }
        public static void AutoPlayer(Banger b)
        {
            if (Banger.stream.CurrentTime >= Banger.stream.TotalTime - new System.TimeSpan(0, 0, 1))
            {
                b.playlist.SelectedIndex++;
                Playlist.curenttrack++;
                Playlist.PlayMusic(Playlist.songs[Playlist.curenttrack]);
            }
        }
    }
}
