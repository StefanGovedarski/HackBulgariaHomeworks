using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGames
{
    public class LottoGame<T, U>
    {
        protected Combination<int, string> winningCombo = new Combination<int, string>(3, 4, 5, "toto", "lotto", "game");
        protected static List<Combination<T, U>> listOfCombos = new List<Combination<T, U>>();

        public LottoGame(params Combination<T,U>[] combos)
        {
            for (int i = 0; i < combos.Length; i++)
            {
                listOfCombos.Add(combos[i]);
            }
        }


        private Combination<int, string> GetWinning()
        {
            return winningCombo;
        }
        public void Validate()
        {
            LottoResult<T, U> lottores = new LottoResult<T, U>();
            Console.WriteLine("Did i win the jackpot? {0} with {1} matching combos",lottores.IsWinning,lottores.MatchedNumbersCount);
        }
    }
}
