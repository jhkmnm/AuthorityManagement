using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.View
{
    public abstract class ViewObjectBase : INotifyPropertyChanged
    {
        public virtual bool IsSelected
        {
            get;
            set;
        }

        public virtual string CreateUser
        { get; set; }

        public virtual DateTime CreateTime
        { get; set; }

        public virtual string LastUpUser
        { get; set; }

        public virtual DateTime LastUpTime
        { get; set; }

        protected void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
