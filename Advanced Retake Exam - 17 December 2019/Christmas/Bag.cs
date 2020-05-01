﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();
        }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Present present)
        {
            if(this.data.Count < Capacity)
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            var presentToRemove = this.data
                .FirstOrDefault(n => n.Name == name);

            return this.data.Remove(presentToRemove);
        }

        public Present GetHeaviestPresent()
        {
            var result = this.data
                .OrderByDescending(w => w.Weight)
                .FirstOrDefault();

            return result;
        }

        public Present GetPresent(string name)
        {
            var result = this.data
                .FirstOrDefault(n => n.Name == name);

            return result;
        }

        public string Report()
        {
            var report = new StringBuilder();

            report.AppendLine($"{this.Color} bag contains:");

            foreach (var present in this.data)
            {
                report.AppendLine($"Present {present.Name} for a {present.Gender}");
            }


            return report.ToString().TrimEnd();
        }
    }
}
