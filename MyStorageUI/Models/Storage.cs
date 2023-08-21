using System;
namespace MyStorageUI.Models
{
    public class Storage
    {
       
        private string name;
        private string picture;
        private string temperature;
        private string weight;
        private string endDate;
        private int progress;
        private Color progressColor;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Temperature
        {
            get { return temperature; }
            set {  temperature = value;}
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }

        public Color ProgressColor
        {
            get { return progressColor; }
            set { progressColor = value; }
        }
    }
}

