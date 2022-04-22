using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class SongManager:BaseModel
    {
        public SongManager(Single singles)
        {
          this.single=singles;
        }
        public string LastPlayDate(IPieceEntity3 single)
        {
            var value = single.LastPlayDate.ToString("dd MMMM yyyy, dddd");
            return value;
        }
        public void Play(IPlay play)
        {
            Console.WriteLine("Caliniyor "+" "+ single.Name);
            play.Play(single);
        }
        public Single single { get; set; }
    }
}

