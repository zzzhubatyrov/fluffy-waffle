using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testapp.Model;

namespace TESTAPP.Model
{
    public class Role : Notify
    {
        private int _id;
        private string _name;

        public int Id
        {
            get => _id;
            set
            {
                Id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }
    }
}
