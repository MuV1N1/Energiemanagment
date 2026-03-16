namespace EnergieManagment;

public class Straßenlaternen
{
    private int id = 0;
    private static int counter;

    public static int GesamtzahlLaternen
    {
        get
        {
            return counter;
        }
        private set
        {
            counter = value;
        }
    }
    private Boolean status;

    public String Status
    {
        get
        {
            if (status == true)
            {
                return "An";
                
            } else
            {
                return "Aus";
            }
        }
        set
        {
            if (value.ToLower().Equals("an"))
            {
                status = true;
            }

            if (value.ToLower().Equals("aus"))
            {
                status = false;
            }
        }
    }

    public Straßenlaternen(String status)
    {
        id++;
        Status = status;
        counter++;
    }
}