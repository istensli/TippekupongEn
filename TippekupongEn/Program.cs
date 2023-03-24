namespace TippekupongEn
{
    internal class Program
    {

        /*
         Oppgave

            Skriv koden mer objektorientert. 

            1. Innfør en klasse Match som representerer en fotballkamp. 

            2. Hvilke felt (objektvariable) bør den ha? 

            3. Hva gjør applikasjonen med en fotballkamp? 

            4. Det siste(3) blir til metodene i klassen. 

            5. Det er ikke meningen å random generere kamputfall, med mindre man ønske å utfordre seg litt. */
        static void Main(string[] args)
        {
          

            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            Match match = new Match();
            match.StartMatch();
            

            var result = match.Result();
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");


        }
    }
}