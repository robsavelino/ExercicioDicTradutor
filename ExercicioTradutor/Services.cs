using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTradutor
{
    public class Services
    {
        public static void StartDictionary (Dictionary<string, string> dictionary)
        {
            dictionary.Add("if", "se");
            dictionary.Add("while", "enquanto");
            dictionary.Add(">=", "maior igual que");
            dictionary.Add("!=", "diferente de");
            dictionary.Add("<=", "menor igual que");
            dictionary.Add("==", "igual a");
            dictionary.Add(">", "maior que");
            dictionary.Add("<", "menor que");            
        }

        public static string TranslatePhrase (Dictionary<string, string> dictionary, string text)
        {
            foreach(var item in dictionary)
            {
                text = text.Replace($"{item.Key}", $"{item.Value}");
            }
            
            return text;
        }
    }
}
