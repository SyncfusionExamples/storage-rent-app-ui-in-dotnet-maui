using System;
using System.Collections.ObjectModel;
using MyStorageUI.Models;

namespace MyStorageUI.ViewModels
{
    public class StorageViewModel
    {
        private ObservableCollection<Storage> storageCollection;

        public ObservableCollection<Storage> Storage
        {
            get { return storageCollection; ; }
            set { storageCollection = value; }
        }

        internal void GenerateInfo()
        {
            storageCollection = new ObservableCollection<Storage>();
            storageCollection.Add(new Storage { Picture = "winter", Name = "Winter", Temperature = "18 °F", Weight = "124 lbs", EndDate = "Nov 25", Progress = 80, ProgressColor = Color.FromArgb("#eb7f60") });
            storageCollection.Add(new Storage { Picture = "kidtoys", Name = "Kid Toys", Temperature = "18 °F", Weight = "54 lbs", EndDate = "Jun 5", Progress = 45, ProgressColor = Color.FromArgb("#9fc482") });
            storageCollection.Add(new Storage { Picture = "furniture", Name = "Furniture", Temperature = "18 °F", Weight = "954 lbs", EndDate = "Jun 5", Progress = 30, ProgressColor = Color.FromArgb("#9fc482") });
        }

        public StorageViewModel()
        {
            GenerateInfo();
        }
    }
}

