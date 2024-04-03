using System;
namespace inlämning_kon
{
    class program
    {
        static void Main(string[] args)
        {

            bil p1 = new bil();
            p1.märke = " Märket är alfa romro ";
            p1.model = " modelen är alfa romeo 4c ";
            p1.tillverkare = " tillverkaren är Alfa romeo ";
            p1.vikt = "väger runt 895 kg ";
            p1.pris = "kosta ifrån 460 000 kr men kan bli dyrare ";

            p1.Metod1();
            
                bil p2 = new bil();
                p2.Märkee = "märket är ford ";
                p2.modell = " modelen är ford focus";
                p2.tillverkaree = "tillverkaren är ford";
                p2.viktt = " kan varieras ifrån 1349-1563 kg";
                p2.priss = " kan kosta ifårn 380 000 kr till mera";

                p2.Metod2();
            
        }
    }
}
