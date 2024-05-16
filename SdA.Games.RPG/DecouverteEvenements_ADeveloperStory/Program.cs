using DecouverteEvenements_ADeveloperStory;

var chef = new Chef();
var chef2 = new Chef();
var patron = new Patron();
var developer = new Developer();

developer.CodeFini += chef.Inspecter;
developer.CodeFini += chef2.Inspecter;
developer.CodeFini += patron.ValiderDevelopperParCode;

var code = developer.CreerCode();