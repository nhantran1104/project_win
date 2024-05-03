using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec
{
    internal class Ratings
    {
        private String commment;
        private double stars;

        public Ratings(string commment, double stars)
        {
            this.commment = commment;
            this.stars = stars;
        }

        public string Commment { get => commment; set => commment = value; }

        public double Stars { get => stars; set => stars = value; }
    }
}
