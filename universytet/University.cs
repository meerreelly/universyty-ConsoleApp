using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universytet
{
    public class University
    {
        string uniname;
        List<Group> groups;

        public University(string uniname, List<Group> groups)
        {
            this.uniname = uniname;
            this.groups = groups;
        }
        public University()
        {
            this.uniname = null;
            this.groups = new List<Group>();
        }
        
        public string GetInfo()
        {
            return $"University name: {this.uniname}|Count of groups:{groups.Count}";
        }
        public List<Group> GetGroupList()
        {
            return groups;
        }
        public override string ToString()
        {
            return $"University name: {this.uniname}|Count of groups:{groups.Count}";
        }
    }
}
