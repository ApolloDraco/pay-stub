using System;

class PayStub {
    // global variables
    // the Heath Insurance Rate is 6%
    static int HIRate = 6;
    // the Tax Withhold Rate is 15%
    static int TWRate = 15;
    // the Retirement Contribution Rate is 12%
    static int RCRate = 12;

    // main method
    static void Main(string[] args) {
        // required variables
        string name;
        int biWeeklyHours;
        double payRate, grossPay, healthInsurance, taxWithhold, retireContribution, netPay;

        // input the user's name
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        // input the user's biweekly hours
        Console.Write("Enter your biweekly hours: ");
        biWeeklyHours = Convert.ToInt32(Console.ReadLine());

        // input the user's pay rate
        Console.Write("Enter your pay rate: ");
        payRate = Convert.ToDouble(Console.ReadLine());

        // compute Biweekly Gross Pay as Biweekly Hours * Pay Rate
        grossPay = Math.Round(biWeeklyHours * payRate, 2);

        // compute Health Insurance fee as Biweekly Gross Pay * Health Insurance Rate
        healthInsurance = Math.Round(grossPay * (HIRate / 100.0), 2);

        // compute Tax Withhold fee as Biweekly Gross Pay * Tax Withhold Rate
        taxWithhold = Math.Round(grossPay * (TWRate / 100.0), 2);

        // compute Retirement Contribution fee as Biweekly Gross Pay * Retirement Contribution Rate
        retireContribution = Math.Round(grossPay * (RCRate / 100.0), 2);

        // compute Biweekly Net Pay as Biweekly Gross Pay - 
        // (Health Insurance Fee + Tax Withhold Amount + Retirement Contribution fee)
        netPay = Math.Round(grossPay - (healthInsurance + taxWithhold + retireContribution), 2);

        // display the pay stub form with all information in a proper format
        Console.WriteLine("\n**********************************************************************************");
        Console.WriteLine("*                                    Pay Stub                                    *");
        Console.WriteLine("**********************************************************************************");
        Console.WriteLine($"*{"Employee Name: ",40}{name,-40}*");
        Console.WriteLine($"*{"Biweekly Working Hours: ",40}{biWeeklyHours,-40}*");
        Console.WriteLine($"*{"Pay Rate: ",40}${payRate.ToString("N"),-39}*");
        Console.WriteLine("**********************************************************************************");
        Console.WriteLine($"*{"Gross Pay: ",40}${grossPay.ToString("N"),-39}*");
        Console.WriteLine($"*{"Health Insurance: ",40}${healthInsurance.ToString("N"),-39}*");
        Console.WriteLine($"*{"Tax Withhold: ",40}${taxWithhold.ToString("N"),-39}*");
        Console.WriteLine($"*{"Retirement Contribution: ",40}${retireContribution.ToString("N"),-39}*");
        Console.WriteLine("**********************************************************************************");
        Console.WriteLine($"*{"Net Pay: ",40}${netPay.ToString("N"),-39}*");
        Console.WriteLine("**********************************************************************************");
    }
}
