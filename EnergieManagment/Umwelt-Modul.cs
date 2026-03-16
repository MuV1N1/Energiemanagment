namespace EnergieManagment;

public static class Umwelt_Modul
{
    public static double Windgeschwindigkeit;

    public static double kmhZuMs(double kmh)
    {
        return kmh / 3.6;
    }
}