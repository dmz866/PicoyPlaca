using System;
using System.Collections.Generic;
using System.Text;

namespace PicoPlaca.DataModel
{
    public class CheckPicoPlaca
    {
        private List<PicoPlacaReglasModel> picoPlacaRulesList = new List<PicoPlacaReglasModel>();
        
        public CheckPicoPlaca()
        {
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Monday, 1));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Monday, 2));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Tuesday, 3));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Tuesday, 4));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Wednesday, 5));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Wednesday, 6));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Thursday, 7));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Thursday, 8));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Friday, 9));
            picoPlacaRulesList.Add(new PicoPlacaReglasModel(DayOfWeek.Friday, 0));
        }

        public string checkPlaca(PicoPlacaReglasModel ppModel)
        {
            string result = string.Empty;
            PicoPlacaReglasModel res = new PicoPlacaReglasModel();
            double fecha7am = ppModel.fecha.AddHours(7).TimeOfDay.TotalMinutes;
            double fecha930am = ppModel.fecha.AddHours(9).AddMinutes(30).TimeOfDay.TotalMinutes;
            double fecha16am = ppModel.fecha.AddHours(16).TimeOfDay.TotalMinutes;
            double fecha1930am = ppModel.fecha.AddHours(19).AddMinutes(30).TimeOfDay.TotalMinutes;

            if (picoPlacaRulesList.Exists(p => p.dia.Equals(ppModel.dia) && p.numero.Equals(ppModel.numero) && 
            ((ppModel.fecha.TimeOfDay.TotalMinutes >= fecha7am && ppModel.fecha.TimeOfDay.TotalMinutes <= fecha930am) || 
            (ppModel.fecha.TimeOfDay.TotalMinutes >= fecha16am && ppModel.fecha.TimeOfDay.TotalMinutes <= fecha1930am))))
            {
                result = "No puede circular";
            }
            else
            {
                result = "Si puede circular";
            }

            return result;
        }
    }
}
