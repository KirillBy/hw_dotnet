using System;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Programm starts");
            var motoRepo = new Repository();
            var motoBMW = new Motorcycle(1, MotoNames.BMW, "I5", 2020);
            var motoHarley = new Motorcycle(2, MotoNames.HarleyDavidson, "HD20", 2019, 1956);
            var motoHonda = new Motorcycle(3, MotoNames.Honda, "Turist", 2008, 56908);
            var motoMinsk = new Motorcycle(4, MotoNames.Minsk, "Wind", 2015, 30290);
            var motoSuzuki = new Motorcycle(5, MotoNames.Suzuki, "Su23", 2010, 43902);
            var motoYamaha = new Motorcycle(5, MotoNames.Yamaha, "Stels", 2020, 500);
            motoRepo.Create(motoBMW);
            motoRepo.Create(motoHarley);
            motoRepo.Create(motoHonda);
            motoRepo.Create(motoMinsk);
            motoRepo.Create(motoSuzuki);
            motoRepo.Create(motoYamaha);
            motoRepo.Update(motoYamaha, 550);
            motoRepo.Update(motoMinsk, 33500);
            var newMoto = motoRepo.ReadById(3);
            motoRepo.Delete(motoSuzuki);
            motoRepo.Create(newMoto);
        }
    }
}
