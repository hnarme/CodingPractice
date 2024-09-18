class Critter
{
    private int foodLevel = 5;
    private int tiredness = 0;
    private int boredLevel = 0;
    private bool isAlive = true;
    private int dayNum = 0;
    public string critterName;

    public string NameCritter(string name)
    {
        critterName = name;
        return critterName;
    }

    private void DayCount()
    {
        if (isAlive)
        {
            dayNum++;
        }

        if (dayNum >= 5)
        {
            Console.WriteLine(critterName + "survived for 5 days. You win!");
        }
    }

    public int getDayCount()
    {
        return dayNum;
    }
    public void Feed()
    {
        Console.WriteLine("You feed " + critterName + ".");
        foodLevel++;
        tiredness++;
        if (foodLevel > 10)
        {
            Console.WriteLine("You overfed" + critterName + ".");
            Die();
        }
        if (tiredness > 10)
        {
            Console.WriteLine(critterName + " is tired.");
            Sleep();
        }
        DayCount();
    }
    public void Sleep()
    {
        Console.WriteLine(critterName + " is sleeping.");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Zzz...");
            foodLevel--;
            if (foodLevel <= 0)
            {
                Console.WriteLine(critterName + " starves in its sleep.");
                Die();
            }
        }
        tiredness = 0;
        DayCount();
    }
    public void Play()
    {
        Console.WriteLine(critterName + " is having fun!");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Ha Ha Ha");
            boredLevel++;
            if (boredLevel == 0)
            {
                Console.WriteLine(critterName + " is bored.");
            }
        }
        tiredness = 0;
        DayCount();
    }
    private void Die()
    {
        Console.WriteLine(critterName + " dies.");
        isAlive = false;
    }
    public bool IsAlive()
    {
        return isAlive;
    }
}