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
            
            if (picoPlacaRulesList.Exists(p => p.dia.Equals(ppModel.dia) && p.numero.Equals(ppModel.numero)))
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
