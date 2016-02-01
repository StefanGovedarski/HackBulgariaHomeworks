using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGames
{
    public class LottoResult<T,U> : LottoGame<T,U>
    {

        public LottoResult()
        {
            this.IsWinning = false;
            this.MatchedNumbersCount = 0;
            foreach (var el in listOfCombos)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (el.firstThree[i].Equals(winningCombo.firstThree[i])&&(el.secondThree[i].Equals(winningCombo.secondThree[i])))
                    {
                        this.IsWinning = true;
                        this.MatchedNumbersCount += 2;

                    }
                }
            }
        }

        public bool IsWinning { get; set; }
        public int MatchedNumbersCount { get; set; }




    }
}
