﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Bibliotheek.Core.Entities
{
    public class Publisher
    {
        public string ID { get; private set; }
        public string Name { get; set; }
        public Publisher()
        {
            ID = Guid.NewGuid().ToString();
        }
        public Publisher(string name) : this()
        {
            Name = name;
        }
        public Publisher(string id, string name)
        {
            ID = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}