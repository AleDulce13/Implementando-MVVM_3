﻿using Implementando_MVVM_3.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Implementando_MVVM_3.VistaModel
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES

        string _N1;
        string _N2;
        string _R;
        string _Tipousuario;
        DateTime _Fecha;
        string _ResultadoFecha;

        #endregion
        #region CONTRUCTOR

        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }

        #endregion

        #region OBJETOS

        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return R; }
            set { SetValue(ref _R, value); }
        }
        public string Tipousuario
        {
            get { return _Tipousuario; }
            set { SetValue(ref _Tipousuario, value); }
        }
        public string SeleccionarTipouser
        {
            get { return _Tipousuario; }
            set
            {
                SetProperty(ref _Tipousuario, value);
                Tipousuario = _Tipousuario;
            }
        }
        public string Resultadofecha
        {
            get { return _ResultadoFecha; }
            set { SetValue(ref _ResultadoFecha, value); }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set
            {
                SetValue(ref _Fecha, value);
                Resultadofecha = _Fecha.ToString("dd/MM/yyyy");
            }
        }

        //public string Mensaje
        //{
        //get { return _Mensaje; }
        //set { SetValue(ref _Mensaje, value); }
        //}

        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task NavegarPagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }

        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 + n2;
            R = r.ToString();
        }
        //public void ProcesoSimple()
        //{

        //}
        #endregion

        #region COMANDOS

        public ICommand PNavegarPagina2command => new Command(async () => await NavegarPagina2());
        public ICommand Suymarcommand => new Command(Sumar);
        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion
    }
}
