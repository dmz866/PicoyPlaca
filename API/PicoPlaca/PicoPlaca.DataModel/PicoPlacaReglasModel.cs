using System;
using System.Collections.Generic;
using System.Text;

namespace PicoPlaca.DataModel
{
    public class PicoPlacaReglasModel
    {
        private DayOfWeek _dia;
        public DateTime _fecha;
        private int _numero;

        public DayOfWeek dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public PicoPlacaReglasModel()
        {

        }
        public PicoPlacaReglasModel(DayOfWeek dia, int numero)
        {
            this.dia = dia;
            this.numero = numero;
        }
        public PicoPlacaReglasModel(DayOfWeek dia, DateTime fecha, int numero)
        {
            this.dia = dia;
            this.fecha = fecha;
            this.numero = numero;
        }
    }
}
