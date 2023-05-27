using MiAppCuadrado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MiAppCuadrado.ViewModels
{
    public class ViewModelCuadrado : INotifyPropertyChanged
    {

        public ViewModelCuadrado() {
        
            Crear = new Command( () => {

                Cuadrado  C= new Cuadrado(lado);
                Resultado = C.ToString();

            });
        
        
        }


        double lado;
        public double Lado {
            get => lado;
            set
            {
                lado = value;
                var args = new PropertyChangedEventArgs(nameof(lado));
                PropertyChanged?.Invoke(this, args);
            }        
        }

        string resultado;

        public string Resultado
        {
            get => resultado;
            set
            {

                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(resultado));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command Crear { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
