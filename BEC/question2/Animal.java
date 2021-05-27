package question2;

public class TestAnimals 
{
    public static void main(String args[])
        {
            Animal NewHorse = new Horse();
            Animal NewSheep = new Sheep();
            
            NewHorse.Eat();
            NewHorse.MakeNoise();

            NewSheep.Eat();
            NewSheep.MakeNoise();
        }
}

public class Animal
{
    public String Eat()
    {
        return "Yummy";
    }
    public Virtual String MakeNoise()
    {
        return "Durrr";
    }
}