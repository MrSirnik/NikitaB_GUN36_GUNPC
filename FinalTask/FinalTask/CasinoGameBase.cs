using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    abstract class CasinoGameBase
    {
        private int bet;

        public CasinoGameBase()
        {
            FactoryMethod();
        }
        
        public abstract void PlayGame();

        public delegate void EventMessage(string message);

        public event EventMessage OnWin;
        public event EventMessage OnLoose;
        public event EventMessage OnDraw;

        public void OnWinInvoke()
        {
            OnWin?.Invoke("Вы выйграли!");
            Console.WriteLine("Вы выйграли!");
        }
        public void OnLooseInvoke()
        {
            OnLoose?.Invoke("Вы проиграли!");
            Console.WriteLine("Вы проиграли!");
        }
        public void OnDrawInvoke()
        {
            OnDraw?.Invoke("Ничья");
            Console.WriteLine("Ничья");
        }

        protected abstract void FactoryMethod();
    }
}
