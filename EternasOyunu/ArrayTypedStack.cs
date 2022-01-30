using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternasOyunu
{
    public class ArrayTypedStack : IStack
    {
        public List<EternasCubuk> items;
        public Random rnd;


        public ArrayTypedStack()//wg w ise beyaz g ise yeşili temsil etmektedir.
        {
            this.items = new List<EternasCubuk>();
            this.rnd = new Random();
        }
        public void Push()
        {
            var ets = new EternasCubuk();

            int sayi = rnd.Next(1, 9);
            ets.cubuk = sayi;
            var count = items.Count();
            if (items.FindAll(x => x.cubuk == ets.cubuk).Count < 4)
            {
                ets.wg = count == 0 ? "w" : (items[count - 1].wg == "w" ? "g" : "w");
                items.Add(ets);
            }
            else
            {
                this.Push();
            }
        }
    }
}
