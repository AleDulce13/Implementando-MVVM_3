﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Implementando_MVVM_3.Model;
using Implementando_MVVM_3.Datos;
using Xamarin.Forms;

namespace Implementando_MVVM_3.VistaModel.VMpokemon
{
    public class VMregistropokemon : BaseViewModel
    {
        #region VARIABLES

        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _TxtNroOrden;
        string _Txtpoder;
        string _Txticono;

        #endregion

        #region CONTSRUCTOR

        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS

        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }

        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string TxtNroOrden
        {
            get { return _TxtNroOrden; }
            set { SetValue(ref _TxtNroOrden, value); }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }
        #endregion

        #region PROCESOS

        public async Task Insertar()
        {
            var funcion = new Dpokemon();
            var parametros = new Mpokemon();

            parametros.Colorfondo = Txtcolorfondo;
            parametros.Colorpoder = Txtcolorpoder;
            parametros.Icono = Txticono;
            parametros.Nombre = Txtnombre;
            parametros.NroOrden = TxtNroOrden;
            parametros.Poder = Txtpoder;

            await funcion.Insertarpokemon(parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS

        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Volvercommand => new Command(async () => await Volver());
        #endregion
    }
}
