using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class operation
    {
        private DateTime date;
        private int num_op=0;
        private MAD montant;
        private string libelle;
       

        public operation(MAD mont,string leb,int num)
        {
            
            this.date = DateTime.Now;
            this.num_op =num;
            this.montant = mont;
            this.libelle = leb;

        }
        public void showop() {
            

            Console.WriteLine(this.date+"|| n " +this.num_op+"||"+this.libelle+this.montant.madstring());
        }




    }
}
