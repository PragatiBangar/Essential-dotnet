namespace DisconnectedAccessTest.Models;

public class LeaveApplication{

    public int Id{get; set;}
    public int EmployeeId{get; set;}
    public DateTime CreatedOn{get;set;}
    public DateTime FromDate{get;set;}
    public DateTime ToDate{get;set;}
    public string? Status{get;set;}
    public string? LeaveType{get;set;}


    // public static int employeeId;

    // public static int empId{
    //     get
    //     {return employeeId;
    //     }
    //     set{employeeId=value;
    //     }
    // }



}