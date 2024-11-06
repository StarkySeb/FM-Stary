using zvirata;

namespace zvirata{


    class Zvire{

        protected string druh;

        protected int vek;

        protected string zvuk;

        public Zvire(string druh, int vek, string zvuk){
            this.druh = druh;
            this.vek = vek;
            this.zvuk = zvuk;

        }
        public void VypisInfo(){
        Console.WriteLine($"Druh: {druh}, Věk: {vek}, Zvuk: {zvuk}");
         }
    }

        // Vytvoření třídy zvířete Kůň která implementuje rozhraní od třídy Zvire
        class Kun : Zvire{
            //Vytvoření jednorozměrného pole pro typy zvířat(obsah pole vygenerovaný pomocí chatgpt, jsem líný já vím)
    private static string[] druhZvire = { "Český teplokrevník", "Arabský plnokrevník", "Fríský kůň", "Appaloosa", "Percheron" };
    //Konstruktor pro zvíře, kde beru base z konstruktoru Zvire, zde ho takzvane přetěžuju a zadávám parametry pro zvíře
    public Kun() : base("Kůň", new Random().Next(1, 21), "Brrr"){ 
             // Náhodný výběr druhu koně
            Random random = new Random();
                int druhNahodny = random.Next(druhZvire.Length); // Vybere náhodné zvíře z pole pomocí indecu druhZvire.Lenght(druhZvire je pole se zvířaty a použil jsem Lenght aby vybíral z velikosti pole, místo zapsání obyč čísla, protože co kdyby bych chtěl nějaký druh přidat)
                this.druh = druhZvire[druhNahodny];  // Přiřadí náhodně vybraný druh
             }
        }
        //
        //
        //Udělal jsem si třídu pro koně a chatgpt mi vypsal ostatni zvirata podle toho co jsem vytvoril.. vsechny funguji na stejnem principu, proto je okomentovany jenom kun
        //
        //
        //

        class Pes : Zvire{
    private static string[] druhZvire = { "Husky", "Labrador", "Německý ovčák", "Bulldog", "Beagle" };
    public Pes() : base("Pes", new Random().Next(1, 16), "Haf Haf"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
        }

        class Kocka : Zvire{
    private static string[] druhZvire = { "Britská krátkosrstá", "Mainská mývalí", "Siamská", "Ragdoll", "Perská" };
    public Kocka() : base("Kočka", new Random().Next(1, 16), "Mňau"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
    }

        class Krava : Zvire{
    private static string[] druhZvire = { "Holštýnský skot", "Hereford", "Angus", "Charolais", "Jersey" };
    public Krava() : base("Krava", new Random().Next(1, 21), "Múú"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Ovce : Zvire{
    private static string[] druhZvire = { "Merino", "Suffolk", "Texel", "Romanovská", "Cheviot" };
    public Ovce() : base("Ovce", new Random().Next(1, 12), "Béé"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Koza : Zvire{
    private static string[] druhZvire = { "Anglonubijská", "Kříženec", "Šumavská", "Bílá bošovická", "Mongolská" };
    public Koza() : base("Koza", new Random().Next(1, 15), "Béé"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Prase : Zvire{
    private static string[] druhZvire = { "Landrace", "Duroc", "Pietrain", "Large White", "Berkshire" };
    public Prase() : base("Prase", new Random().Next(1, 15), "Oink Oink"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Kachna : Zvire{
    private static string[] druhZvire = { "Indická běžce", "Pižmová", "Aylesbury", "Kavkazská", "Orpington" };
    public Kachna() : base("Kachna", new Random().Next(1, 10), "Kvák Kvák"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Slepice : Zvire{
    private static string[] druhZvire = { "Hampshire", "Czech Golden", "Leghorn", "Sussex", "Plymouth Rock" };
    public Slepice() : base("Slepice", new Random().Next(1, 10), "Kvak Kvak"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

        class Lama : Zvire{
    private static string[] druhZvire = { "Bílá lama", "Černá lama", "Kříženec", "Tibetská", "Peruánská" };

    public Lama() : base("Lama", new Random().Next(1, 20), "Huff Huff"){
        Random random = new Random();
            int druhNahodny = random.Next(druhZvire.Length);
            this.druh = druhZvire[druhNahodny];
    }
}

class VytvorZvire{
    //dynamicke vytvareni objektu pres => (lamdda), zkracuje mi to čas, tak jsem to použil a nahrazuje to toto:    
    // public Zvire VytvorKun()
    //{
      //  return new Kun();  // Vytvoří nového koně
    //}
    public Zvire VytvorKun() => new Kun();
    public Zvire VytvorPes() => new Pes();
    public Zvire VytvorKocku() => new Kocka();
    public Zvire VytvorKrava() => new Krava();
    public Zvire VytvorOvce() => new Ovce();
    public Zvire VytvorKoza() => new Koza();
    public Zvire VytvorPrase() => new Prase();
    public Zvire VytvorKachna() => new Kachna();
    public Zvire VytvorSlepice() => new Slepice();
    public Zvire VytvorLama() => new Lama();
}

    
}