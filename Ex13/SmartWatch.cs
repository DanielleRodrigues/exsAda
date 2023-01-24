/*Faça uma classe SmartWatch com a contagem dos passos diários de uma pessoa (pedômetro). 
Garanta utilizando acessors (get/set) que os passos apenas podem ser 
incrementados e um método resetOnMidnight() que reseta os passos para 0.
*/
using System;

class SmartWatch
{
    private int dailySteps;

    public int DailySteps
    {
        get { return dailySteps; }
        set { 
            if(value > dailySteps)
                dailySteps = value;
        }
    }

    public void ResetOnMidnight()
    {
        dailySteps = 0;
    }


    /*SmartWatch myWatch = new SmartWatch();
    myWatch.DailySteps = 100;
    Console.WriteLine("Passos dados: " + myWatch.DailySteps);

    myWatch.DailySteps += 8000;
    Console.WriteLine("Passos dados: " + myWatch.DailySteps);

    myWatch.ResetOnMidnight();
    Console.WriteLine("Passos dados:" + myWatch.DailySteps);*/
}