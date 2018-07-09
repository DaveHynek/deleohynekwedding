using deleohynekwedding.Models;
using System;
using System.Linq;

namespace deleohynekwedding.Data.SeedData
{
    public static class InvitationInitializer
    {
        public static void SeedInvitations(this WeddingContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Invitations.Any()) return;

            var invitations = new Invitation[]
            {
                new Invitation { RsvpCode="hynek15211", Guests = new Guest [] {
                    new Guest{ FirstName = "Emily", LastName = "DeLeo" },
                    new Guest{ FirstName = "David", LastName = "Hynek" }
                } },
                new Invitation { RsvpCode="hynek15217", Guests = new Guest [] {
                    new Guest{ FirstName = "James", LastName = "Hynek" },
                    new Guest{ FirstName = "Becky", LastName = "Hynek" }
                } },
                new Invitation { RsvpCode="hynek15206", Guests = new Guest [] {
                    new Guest{ FirstName = "Jonathan", LastName = "Hynek" }
                } },
                new Invitation { RsvpCode="hynek18202", Guests = new Guest [] {
                    new Guest{ FirstName = "Philip", LastName = "Hynek" }
                } },
                new Invitation { RsvpCode="braman33321", Guests = new Guest [] {
                    new Guest{ FirstName = "Richard", LastName = "Braman" },
                    new Guest{ FirstName = "Pamela", LastName = "Braman" }
                } },
                new Invitation { RsvpCode="braman27885", Guests = new Guest [] {
                    new Guest{ FirstName = "Richard", LastName = "Braman" },
                    new Guest{ FirstName = "Kat", LastName = "Braman" }
                } },
                new Invitation { RsvpCode="hynek60175", Guests = new Guest [] {
                    new Guest{ FirstName = "Suzanne", LastName = "Hynek" },
                    new Guest{ FirstName = "Mary", LastName = "Bagrowski" },
                    new Guest{ FirstName = "Doug", LastName = "Bagrowski" },
                    new Guest{ FirstName = "Brian", LastName = "Bagrowski" },
                    new Guest{ FirstName = "Kevin", LastName = "Bagrowski" }
                } },
                new Invitation { RsvpCode="deleo15101", Guests = new Guest [] {
                    new Guest{ FirstName = "Timothy", LastName = "DeLeo" },
                    new Guest{ FirstName = "Nadine", LastName = "DeLeo" }
                } },
                new Invitation { RsvpCode="deleo15218", Guests = new Guest [] {
                    new Guest{ FirstName = "Aaron", LastName = "DeLeo" }
                } },
                new Invitation { RsvpCode="gladstone77433", Guests = new Guest [] {
                    new Guest{ FirstName = "Terry", LastName = "Gladstone" },
                    new Guest{ FirstName = "Richard", LastName = "Gladstone" },
                    new Guest{ FirstName = "Aaron", LastName = "Gladstone" },
                    new Guest{ FirstName = "Matthew", LastName = "Gladstone" }
                } },
                new Invitation { RsvpCode="deleo76180", Guests = new Guest [] {
                    new Guest{ FirstName = "Cosimo", LastName = "DeLeo" },
                    new Guest{ FirstName = "Carol", LastName = "DeLeo" }
                } },
                new Invitation { RsvpCode="grunden15044", Guests = new Guest [] {
                    new Guest{ FirstName = "Melanie", LastName = "Grunden" },
                    new Guest{ FirstName = "Rob", LastName = "Grunden" }
                } },
                new Invitation { RsvpCode="dreier15229", Guests = new Guest [] {
                    new Guest{ FirstName = "Brent", LastName = "Dreier" },
                    new Guest{ FirstName = "Erin", LastName = "Dreier" }
                } },
                new Invitation { RsvpCode="gephart15044", Guests = new Guest [] {
                    new Guest{ FirstName = "Lori", LastName = "Gephart" },
                    new Guest{ FirstName = "Jim", LastName = "Gephart" },
                    new Guest{ FirstName = "Brittany", LastName = "Gephart" },
                    new Guest{ FirstName = "Bryan", LastName = "Lohr" }
                } },
                new Invitation { RsvpCode="gephart15126", Guests = new Guest [] {
                    new Guest{ FirstName = "Cameron", LastName = "Gephart" },
                    new Guest{ FirstName = "Kristen", LastName = "Gephart" }
                } },
                new Invitation { RsvpCode="campbell15101", Guests = new Guest [] {
                    new Guest{ FirstName = "Katie", LastName = "Campbell" },
                    new Guest{ FirstName = "Gordon", LastName = "Labosky" }
                } },
                new Invitation { RsvpCode="kearney15005", Guests = new Guest [] {
                    new Guest{ FirstName = "Elena", LastName = "Kearney" },
                    new Guest{ FirstName = "Tim", LastName = "Kearney" }
                } },
                new Invitation { RsvpCode="pucciarelli15044", Guests = new Guest [] {
                    new Guest{ FirstName = "Amber", LastName = "Pucciarelli" },
                    new Guest{ FirstName = "Alex", LastName = "Pucciarelli" }
                } },
                new Invitation { RsvpCode="alexovich94103", Guests = new Guest [] {
                    new Guest{ FirstName = "Michael", LastName = "Alexovich" },
                    new Guest{ FirstName = "Rob", LastName = "Wygand" }
                } },
                new Invitation { RsvpCode="osullivan44240", Guests = new Guest [] {
                    new Guest{ FirstName = "Brian", LastName = "O'Sullivan" }
                } },
                new Invitation { RsvpCode="anderson15017", Guests = new Guest [] {
                    new Guest{ FirstName = "Jack", LastName = "Anderson" },
                    new Guest{ FirstName = "Peg", LastName = "Anderson" }
                } },
                new Invitation { RsvpCode="delozier19018", Guests = new Guest [] {
                    new Guest{ FirstName = "Allyson", LastName = "DeLozier" },
                    new Guest{ FirstName = "Christian", LastName = "DeLozier" }
                } },
                new Invitation { RsvpCode="picozzi15243", Guests = new Guest [] {
                    new Guest{ FirstName = "Josh", LastName = "Picozzi" },
                    new Guest{ FirstName = "Laura", LastName = "Picozzi" }
                } },
                new Invitation { RsvpCode="egan55402", Guests = new Guest [] {
                    new Guest{ FirstName = "Katie", LastName = "Egan" },
                    new Guest{ FirstName = "James", LastName = "Thorson" }
                } },
                new Invitation { RsvpCode="stockstead55330", Guests = new Guest [] {
                    new Guest{ FirstName = "Bobby", LastName = "Stockstead" },
                    new Guest{ FirstName = "Charlotte", LastName = "Stockstead" }
                } },
                new Invitation { RsvpCode="kiber15214", Guests = new Guest [] {
                    new Guest{ FirstName = "Justin", LastName = "Kibler" },
                    new Guest{ FirstName = "Alex", LastName = "Kibler" }
                } },
                new Invitation { RsvpCode="volpe15147", Guests = new Guest [] {
                    new Guest{ FirstName = "Jacob", LastName = "Volpe" },
                    new Guest{ FirstName = "Taylor", LastName = "Volpe" }
                } },
                new Invitation { RsvpCode="boccardi06489", Guests = new Guest [] {
                    new Guest{ FirstName = "Audra", LastName = "Boccardi" },
                    new Guest{ FirstName = "Pete", LastName = "Boccardi" },
                    new Guest{ FirstName = "Liz", LastName = "Boccardi" }
                } },
                new Invitation { RsvpCode="williams16127", Guests = new Guest [] {
                    new Guest{ FirstName = "Lydia", LastName = "Williams" },
                    new Guest{ FirstName = "Mel", LastName = "Williams" }
                } },
                new Invitation { RsvpCode="williams15229", Guests = new Guest [] {
                    new Guest{ FirstName = "Benjamin", LastName = "Williams" },
                    new Guest{ FirstName = "Diana", LastName = "Williams" }
                } },
                new Invitation { RsvpCode="volpe15147", Guests = new Guest [] {
                    new Guest{ FirstName = "Jacob", LastName = "Volpe" },
                    new Guest{ FirstName = "Taylor", LastName = "Volpe" }
                } },
                new Invitation { RsvpCode="carr16001", Guests = new Guest [] {
                    new Guest{ FirstName = "Suzanne", LastName = "Carr" },
                    new Guest{ FirstName = "Tim", LastName = "Carr" }
                } },
                new Invitation { RsvpCode="macdonald16059", Guests = new Guest [] {
                    new Guest{ FirstName = "Lyle", LastName = "MacDonald" },
                    new Guest{ FirstName = "Patti", LastName = "MacDonald" }
                } },
                new Invitation { RsvpCode="beck21093", Guests = new Guest [] {
                    new Guest{ FirstName = "Lauren", LastName = "Beck" },
                    new Guest{ FirstName = "Ryan", LastName = "Beck" }
                } },
                new Invitation { RsvpCode="featherstone98516", Guests = new Guest [] {
                    new Guest{ FirstName = "Jean", LastName = "Featherstone" },
                    new Guest{ FirstName = "Carson", LastName = "Featherstone" }
                } },
                new Invitation { RsvpCode="deaton35173", Guests = new Guest [] {
                    new Guest{ FirstName = "Katie", LastName = "Deaton" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="ward27712", Guests = new Guest [] {
                    new Guest{ FirstName = "Rebecca", LastName = "Ward" },
                    new Guest{ FirstName = "Patrick", LastName = "Ward" }
                } },
                new Invitation { RsvpCode="zukowski15201", Guests = new Guest [] {
                    new Guest{ FirstName = "Stefanie", LastName = "Zukowski" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="clark22202", Guests = new Guest [] {
                    new Guest{ FirstName = "Nichola", LastName = "Clark" },
                    new Guest{ FirstName = "Joe", LastName = "Maschman" }
                } },
                new Invitation { RsvpCode="graciano15215", Guests = new Guest [] {
                    new Guest{ FirstName = "Sara", LastName = "Graciano" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="mcinnis02144", Guests = new Guest [] {
                    new Guest{ FirstName = "Cody", LastName = "McInnis" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="mcinnis03458", Guests = new Guest [] {
                    new Guest{ FirstName = "Lisa", LastName = "McInnis" },
                    new Guest{ FirstName = "Darren", LastName = "McInnis" },
                    new Guest{ FirstName = "Maeve", LastName = "McInnis" }
                } },
                new Invitation { RsvpCode="frank11787", Guests = new Guest [] {
                    new Guest{ FirstName = "Katrina", LastName = "Frank" },
                    new Guest{ FirstName = "Lawrence", LastName = "Agtuca" }
                } },
                new Invitation { RsvpCode="sunseri15209", Guests = new Guest [] {
                    new Guest{ FirstName = "Tina", LastName = "Sunseri" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="staas15237", Guests = new Guest [] {
                    new Guest{ FirstName = "Lauren", LastName = "Staas" },
                    new Guest{ FirstName = "Brad", LastName = "Herman" }
                } },
                new Invitation { RsvpCode="heslop16648", Guests = new Guest [] {
                    new Guest{ FirstName = "Judy", LastName = "Heslop" },
                    new Guest{ FirstName = "John", LastName = "Heslop" }
                } },
                new Invitation { RsvpCode="egan60004", Guests = new Guest [] {
                    new Guest{ FirstName = "Karen", LastName = "Egan" },
                    new Guest{ FirstName = "Dan", LastName = "Egan" }
                } },
                new Invitation { RsvpCode="dahm15217", Guests = new Guest [] {
                    new Guest{ FirstName = "Brian", LastName = "Dahm" },
                    new Guest{ FirstName = "Julia", LastName = "Dahm" }
                } },
                new Invitation { RsvpCode="freer15202", Guests = new Guest [] {
                    new Guest{ FirstName = "Connor", LastName = "Freer" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="anderson16803", Guests = new Guest [] {
                    new Guest{ FirstName = "Jeremy", LastName = "Anderson" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="floro90066", Guests = new Guest [] {
                    new Guest{ FirstName = "Joe", LastName = "Floro" }
                } },
                new Invitation { RsvpCode="obied15227", Guests = new Guest [] {
                    new Guest{ FirstName = "John", LastName = "Obied" }
                } },
                new Invitation { RsvpCode="maloney15206", Guests = new Guest [] {
                    new Guest{ FirstName = "Mike", LastName = "Maloney" },
                    new Guest{ FirstName = "Kasey", LastName = "Maloney" }
                } },
                new Invitation { RsvpCode="barnes15120", Guests = new Guest [] {
                    new Guest{ FirstName = "Shauna", LastName = "Barnes" },
                    new Guest{ FirstName = "Matt", LastName = "Fries" }
                } },
                new Invitation { RsvpCode="cowan21230", Guests = new Guest [] {
                    new Guest{ FirstName = "Will", LastName = "Cowan" },
                    new Guest{ FirstName = "Val", LastName = "Ludwig" }
                } },
                new Invitation { RsvpCode="williams15224", Guests = new Guest [] {
                    new Guest{ FirstName = "Matt", LastName = "Williams" },
                    new Guest{ FirstName = "Perrie", LastName = "Bell" }
                } },
                new Invitation { RsvpCode="caridi15201", Guests = new Guest [] {
                    new Guest{ FirstName = "Brandon", LastName = "Caridi" }
                } },
                new Invitation { RsvpCode="ledgerwood20017", Guests = new Guest [] {
                    new Guest{ FirstName = "Aaron", LastName = "Ledgerwood" }
                } },
                new Invitation { RsvpCode="warble15302", Guests = new Guest [] {
                    new Guest{ FirstName = "Adam", LastName = "Warble" }
                } },
                new Invitation { RsvpCode="rusiski15057", Guests = new Guest [] {
                    new Guest{ FirstName = "Lou", LastName = "Rusiski" },
                    new Guest{ FirstName = "Judy", LastName = "Rusiski" }
                } },
                new Invitation { RsvpCode="warble15210", Guests = new Guest [] {
                    new Guest{ FirstName = "Andrew", LastName = "Warble" }
                } },
                new Invitation { RsvpCode="giel26505", Guests = new Guest [] {
                    new Guest{ FirstName = "Nathan", LastName = "Giel" },
                    new Guest{ FirstName = "Ivy", LastName = "Giel" }
                } },
                new Invitation { RsvpCode="macher15216", Guests = new Guest [] {
                    new Guest{ FirstName = "Andrew", LastName = "Macher" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="ketter15108", Guests = new Guest [] {
                    new Guest{ FirstName = "Jeremy", LastName = "Ketter" },
                    new Guest{ FirstName = "Sarah", LastName = "Ketter" }
                } },
                new Invitation { RsvpCode="coley15122", Guests = new Guest [] {
                    new Guest{ FirstName = "Rebekah", LastName = "Coley" }
                } },
                new Invitation { RsvpCode="lynch15232", Guests = new Guest [] {
                    new Guest{ FirstName = "Olivia", LastName = "Lynch" }
                } },
                new Invitation { RsvpCode="jakab32312", Guests = new Guest [] {
                    new Guest{ FirstName = "Sara", LastName = "Jakab" },
                    new Guest{ FirstName = "Brad", LastName = "Jakab" }
                } },
                new Invitation { RsvpCode="pulice60191", Guests = new Guest [] {
                    new Guest{ FirstName = "Anna", LastName = "Pulice" }
                } },
                new Invitation { RsvpCode="owen80504", Guests = new Guest [] {
                    new Guest{ FirstName = "Evan", LastName = "Owen" },
                    new Guest{ FirstName = "Sarah", LastName = "Montanari" }
                } },
                new Invitation { RsvpCode="murphy15236", Guests = new Guest [] {
                    new Guest{ FirstName = "Donna", LastName = "Murphy" }
                } },
                new Invitation { RsvpCode="sutter15213", Guests = new Guest [] {
                    new Guest{ FirstName = "Jimmy", LastName = "Sutter" },
                    new Guest{ FirstName = "Rachelle", LastName = "Sutter" }
                } },
                new Invitation { RsvpCode="roman19380", Guests = new Guest [] {
                    new Guest{ FirstName = "Aaron", LastName = "Roman" }
                } },
                new Invitation { RsvpCode="mckenna15224", Guests = new Guest [] {
                    new Guest{ FirstName = "Kevin", LastName = "McKenna" }
                } },
                new Invitation { RsvpCode="murray05602", Guests = new Guest [] {
                    new Guest{ FirstName = "Megan", LastName = "Murray" }
                } },
                new Invitation { RsvpCode="braman61101", Guests = new Guest [] {
                    new Guest{ FirstName = "Tim", LastName = "Braman" },
                    new Guest{ FirstName = "Sophie", LastName = "Braman" }
                } },
                new Invitation { RsvpCode="baines61101", Guests = new Guest [] {
                    new Guest{ FirstName = "Sierra", LastName = "Baines" },
                    new Guest{ FirstName = "James", LastName = "Baines" }
                } },
                new Invitation { RsvpCode="teprovich15236", Guests = new Guest [] {
                    new Guest{ FirstName = "Stanley", LastName = "Teprovich" },
                    new Guest{ FirstName = "Heather", LastName = "Teprovich" }
                } },
                new Invitation { RsvpCode="finley15237", Guests = new Guest [] {
                    new Guest{ FirstName = "Doug", LastName = "Finley" }
                } },
                new Invitation { RsvpCode="kelly15101", Guests = new Guest [] {
                    new Guest{ FirstName = "Shelley", LastName = "Kelly" },
                    new Guest{ FirstName = "Joe", LastName = "Kelly" }
                } },
                new Invitation { RsvpCode="brandimarti15106", Guests = new Guest [] {
                    new Guest{ FirstName = "Joan", LastName = "Brandimarti" },
                    new Guest{ FirstName = "Paul", LastName = "Brandimarti" }
                } },
                new Invitation { RsvpCode="crooks15101", Guests = new Guest [] {
                    new Guest{ FirstName = "Francine", LastName = "Crooks" },
                    new Guest{ FirstName = "John", LastName = "Crooks" }
                } },
                new Invitation { RsvpCode="belcher14625", Guests = new Guest [] {
                    new Guest{ FirstName = "Elizabeth", LastName = "Belcher" },
                    new Guest{ FirstName = "Christopher", LastName = "Belcher" }
                } },
                new Invitation { RsvpCode="vins15005", Guests = new Guest [] {
                    new Guest{ FirstName = "Sean", LastName = "Vins" },
                    new Guest{ FirstName = "Maria", LastName = "Munsch" }
                } },
                new Invitation { RsvpCode="hoffman15219", Guests = new Guest [] {
                    new Guest{ FirstName = "Jordan", LastName = "Hoffman" }
                } },
                new Invitation { RsvpCode="cavalier15037", Guests = new Guest [] {
                    new Guest{ FirstName = "Gel", LastName = "Cavalier" }
                } },
                new Invitation { RsvpCode="cipriani15227", Guests = new Guest [] {
                    new Guest{ FirstName = "Brad", LastName = "Cipriani" },
                    new Guest{ FirstName = "+1", LastName = "+1" }
                } },
                new Invitation { RsvpCode="mcclain15206", Guests = new Guest [] {
                    new Guest{ FirstName = "Raymar", LastName = "McClain" }
                } },
                new Invitation { RsvpCode="snodgrassXXXXX", Guests = new Guest [] {
                    new Guest{ FirstName = "John", LastName = "Snodgrass" },
                    new Guest{ FirstName = "Margaret", LastName = "Snodgrass" },
                } },
            };

            Array.ForEach(invitations, x => context.Invitations.Add(x));
            context.SaveChanges();
        }
    }
}
