﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder.Models
{
    public class Directory
    {
        public Directory(string fullPath, string name)
        {
            this.FullPath = fullPath;
            this.Name = name;
            this.Children = new ObservableCollection<object>();
        }
        public string FullPath
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public ObservableCollection<object> Children
        {
            get;
            private set;
        }
    }
}
