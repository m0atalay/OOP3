using OOP3;

ICrediBaseManager konutCrediManager = new KonutCrediManager();


ICrediBaseManager ıhtıyackredi = new IhtıyacKredi();


ICrediBaseManager tasıtkredi = new TasıtKrediManager();


//Interface1 fileLoggerService = new FileLoggerService();


DataBaseLoggerService dataBaseLogger = new DataBaseLoggerService();

AppBasvuru4 appBasvuru4 = new AppBasvuru4();
appBasvuru4.BasvuruYap(ıhtıyackredi, new DataBaseLoggerService());

List<ICrediBaseManager> krediler = new List<ICrediBaseManager>()
{
    konutCrediManager,ıhtıyackredi,tasıtkredi,
};

//appBasvuru4.Crediİnformation(krediler);



