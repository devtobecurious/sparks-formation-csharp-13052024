namespace ComptabiliteEssai
{
    public delegate decimal GetTva(string codePays, int codeTva);

    public class CalculateurTTC
    {
        //public decimal Calculer(decimal prixHT, decimal tva)
        //{
        //    return prixHT * (1 + tva);
        //}

        public decimal Calculer(decimal prixHT, GetTva getTva)
        {
            return prixHT * (1 + getTva("FR", 1));
        }
    }
}
