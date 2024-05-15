namespace DecouvertePOO
{
    internal interface IQuiPeutVoler
    {
        void Voler();

        //int NbAiles { get; }
    }

    internal interface IQuiPeutVolerEtSurvoler : IQuiPeutVoler
    {
        void Survoler();
    }
}
