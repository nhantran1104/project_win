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
        private int stars;

        public Ratings(string commment, int stars)
        {
            this.commment = commment;
            this.stars = stars;
        }

        public string Commment { get => commment; set => commment = value; }

        public int Stars { get => stars; set => stars = value; }
    }
}
