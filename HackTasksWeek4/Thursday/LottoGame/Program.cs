using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Combination<int, string>> comboList = new List<Combination<int, string>>();
                Combination<int, string> combo1 = new Combination<int, string>(1, 2, 6, "a", "b", "v");
                Combination<int, string> combo2 = new Combination<int, string>(1, 2, 6, "a", "b", "v");
                Combination<int, string> combo3 = new Combination<int, string>(1, 5, 3, "lotto", "totto", "v");
                Combination<int, string> combo4 = new Combination<int, string>(3, 4, 5, "toto", "lotto", "game");
                Combination<int, string> combo5 = new Combination<int, string>(1, 2, 6, "a", "b", "v");
            comboList.Add(combo1); comboList.Add(combo2); comboList.Add(combo3); comboList.Add(combo4); comboList.Add(combo5);
            Combination<int, string>[] comboArray = comboList.ToArray(); 
            LottoGame<int, string> lotto = new LottoGame<int, string>(comboArray);
                lotto.Validate();

        }
    }
}
