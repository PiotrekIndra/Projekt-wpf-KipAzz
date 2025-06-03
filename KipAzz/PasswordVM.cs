using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace KipAzz
{
    class PasswordVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public MyCommand AddPasword { get; set; }
        public MyCommand UpdatePassword { get; set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public PasswordVM() {
            UpdatePassword = new RelayCommand(Update);
            AddPasword = new RelayCommand(Add);
        }
        private void Add() {
            //zapisujemy hasło do bazy danych
        }
        private void Update()
        {
            //aktualizujemy odpowiedni rekord w bazie danych
        }
        private void SelectIcon()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Grafika wektorowa (*.svg)|*.svg|Grafika rastrowa(*.png)|*.png";
            openFileDialog.InitialDirectory = "C:\\Users\\Uczen\\source\\repos\\Projekt-wpf-KipAzz\\KipAzz\\images"; //ZMODYFIKUJCIE TO, JEŚLI URUCHAMIACIE APLIKACJĘ Z INNEJ LOKALIZACJI!
            openFileDialog.Title = "Wybierz ikonkę";
            bool? success = openFileDialog.ShowDialog();
            if (success == true)
            {
                string path = openFileDialog.FileName;
                Image image = new Image(); //trzeba będzie ustawić to jako ten obraz 
                image.Source = new BitmapImage(new Uri(path));
            }
        }
        
    }
}
