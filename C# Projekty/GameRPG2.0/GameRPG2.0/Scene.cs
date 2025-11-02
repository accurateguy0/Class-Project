using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class Scene // to klasa bazowa do wszystkich pozostałych klas ...Scene
    {
        protected Game game;
        public Scene(Game game) 
        {
            this.game = game;
        }
        virtual public void Run() { } // słowo kluczowe virtual pozwala na uzycie override
    }
}
