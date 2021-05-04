using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AnalizadorLexico
{
    public class Compilador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string error;
        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Error"));
            }
        }

        private string lineacodigo;
        public string LineaCodigo
        {
            get { return lineacodigo; }
            set
            {
                lineacodigo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Codigo"));
            }
        }
        public bool ValidateCode()
        {
            if (!LineaCodigo.EndsWith(";"))
                Error = "Falta ;";
            else
                return true;
        }

    }
}