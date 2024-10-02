using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEKS //package everything in one package, building with a lot of room
{
    internal class AdminAssist
    {
        public string PmName {get;set;}
        public AdminAssist(string PMname){
            PmName = PMname; 
        }, 
        public PublicAdminAssist(string name, string description, int id, string PMname){
            Name = name; 
            Description = description;
            Id = id;
            PmName = PMname;
        }
    }
}
