using ComptabiliteEssai;

var calculateur = new CalculateurTTC();

Console.WriteLine("Le montant HT ?");
var montantString = Console.ReadLine();
//var montantHT = decimal.Parse(montantString);

if (decimal.TryParse(montantString, out decimal montantHT))
{
    var result = calculateur.Calculer(montantHT, GetTvaSpecificPourLeVin);
    Console.WriteLine("Le montant TTC est {0}", result);
}


decimal GetTvaSpecificPourLeVin(string codePays, int typeTVA)
{
    return typeTVA / 100;
}