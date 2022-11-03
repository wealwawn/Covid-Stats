using System;

public class Vaccination
#region Properties

{
    private string vaxCounty;

    public string VaxCounty
    {
        get { return vaxCounty; }
        set { vaxCounty = value; }
    }
    private int totalPopulation;

    public int TotalPopulation
    {
        get { return totalPopulation; }
        set { totalPopulation = value; }
    }
    private int vaxNumber;

    public int VaxNumber
    {
        get { return vaxNumber; }
        set { vaxNumber = value; }
    }


    private double vaxPercent
    {
        get { return vaxPercent; }
    }
    #endregion

    #region Utility Methods
    /// <summary>
    /// string representation of the object
    /// </summary>
    /// <returns>string representation of the object</returns>
    public override string ToString()
    {
        string message;

        message = VaxCounty + "county has a population of " + TotalPopulation.ToString + "and the number of vaccinated people is " + VaxNumber.ToString + "leading to a vaccination percentage of " VaxPercent.ToString

        return message;
    }
    /// <summary>
    /// Clears the state oif the object.
    /// </summary>
    public void Clear()
    {
        vaxCounty = string.Empty;
        totalPopulation = 0;
        vaxNumber = 0;
    }
    #endregion
    #region Constructors
    public Vaccination()
    {
        Clear();

    }
    
    #endregion
    #region Destructors
    /// <summary>
    /// Destructor
    /// </summary>
    ~Person()
    {
        vaxCounty = null;
    }
} 
        #endregion

}

