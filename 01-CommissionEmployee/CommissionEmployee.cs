using System;

public class CommissionEmployee : object
{
    public string FirstName { get; set; }
    public string LastName { get; set;  }
    public string SocialSecurityNumber { get; set;  }
   private decimal grossSales; // Ventas brutas semanales
   private decimal commissionRate; // porcentaje de comision

   public CommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales, decimal commissionRate)
   {
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      GrossSales = grossSales; // propiedad que valida las ventas brutas semanales
      CommissionRate = commissionRate; // propiedad que valida el porcentaje de comision
   }

   public decimal GrossSales
   {
      get
      {
         return grossSales;
      }
      set
      {
         if (value < 0) 
         {
            throw new ArgumentOutOfRangeException(value.ToString(), value, "{nameof(GrossSales)} must be >= 0");
         }

         grossSales = value;
      }
   }

   public decimal CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         if (value <= 0 || value >= 1)
         {
            throw new ArgumentOutOfRangeException(value.ToString(), value, "{nameof(CommissionRate)} must be > 0 and < 1");
         }

         commissionRate = value;
      }
   }

   //public decimal Earnings() => commissionRate * grossSales;
    public decimal Earnings()
    {
        return commissionRate * grossSales;
    }

    public override string ToString()
    {
        return  "Empleado por comision   : " + FirstName + " " + LastName+"\n"+
                "Numero de Seguro Social : " + SocialSecurityNumber+"\n" +
                "Ventas Brutas           : " + grossSales+"\n" +
                "Porcentaje de Comision  : " + commissionRate;
    }
}