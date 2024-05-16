namespace DecouverteEvenements_ADeveloperStory
{
    internal class Developer
    {
        public event EnvoyerCode CodeFini;

        public Code CreerCode()
        {
            var code = new Code();

            code.Content = "int i = 0;";

            this.CodeFini?.Invoke(code);

            return code;
        }

    }
}
