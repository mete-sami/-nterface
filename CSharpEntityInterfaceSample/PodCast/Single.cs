using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class Single:BaseModel,IPieceEntity3,IPlay
    {
        public Single(string name)
        {
            Name = name;
            Console.WriteLine(name);
            Console.Read();
        }
        public string Name { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ReleaseDate {
            get { return ReleaseDate.AddDays(10); }
                }
        public DateTime RemainingTime { get; set; }
        public DateTime LastPlayDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Artist artist { get; set; }

        public void Play(Single singles)
        {
            throw new NotImplementedException();
        }
    }
    
}
