using System.Data;
using System.Data.Common;
using DisconnectedAccessTest.service.Interface;
using MySql.Data.MySqlClient;

namespace DisconnectedAccessTest.Models;
public class LeaveService:ILeaveService{

    private readonly IConfiguration _configuration;

    private readonly string _connectionString;

    public LeaveService(IConfiguration configuration){
        
     _configuration=configuration;
     _connectionString = _configuration.GetConnectionString("DefaultConnection")?? throw new ArgumentNullException("connectionString");
    }
    public List<LeaveApplication> GetAll()
    {
        List<LeaveApplication> leaveApplications = new List<LeaveApplication>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=_connectionString;
        try{
            string query="select * from leaveapplications";
            MySqlCommand command = new MySqlCommand(query,con);
            MySqlDataAdapter adapter =  new MySqlDataAdapter(command);
            DataSet dataSet=new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable=dataSet.Tables[0];
            foreach(DataRow dataRow in dataTable.Rows)
            {
                int id=int.Parse(dataRow["id"].ToString());
                int employeeId=int.Parse(dataRow["employeeId"].ToString());
                DateTime createdOn= DateTime.Parse(dataRow["createdon"].ToString());
                DateTime fromDate= DateTime.Parse(dataRow["fromdate"].ToString());
                DateTime toDate= DateTime.Parse(dataRow["todate"].ToString());
                string leaveType=dataRow["leavetype"].ToString();
                string status=dataRow["status"].ToString();

                LeaveApplication leave =new LeaveApplication{
                    Id=id,
                    EmployeeId=employeeId,
                    CreatedOn=createdOn,
                    FromDate=fromDate,
                    ToDate=toDate,
                    LeaveType=leaveType,
                    Status=status
                };
                leaveApplications.Add(leave);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        } 
        return leaveApplications;
    }

    public LeaveApplication GetLeaveApplication(int id)
    {
        LeaveApplication leave=null;
        MySqlConnection con=new MySqlConnection(_connectionString);
        try{
            string query="select * from leaveapplications";
            MySqlCommand command=new MySqlCommand(query,con);
            MySqlDataAdapter adapter=new MySqlDataAdapter(command);
            DataSet dataSet =new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable=dataSet.Tables[0];
            DataColumn[] keycolumn =new DataColumn[1];
            keycolumn[0] =dataTable.Columns["id"];
            dataTable.PrimaryKey=keycolumn;
            DataRow dataRow=dataTable.Rows.Find(id);

            int employeeId=int.Parse(dataRow["employeeid"].ToString());
            DateTime createdOn=DateTime.Parse(dataRow["createdon"].ToString());
            DateTime fromDate=DateTime.Parse(dataRow["fromDate"].ToString());
            DateTime toDate=DateTime.Parse(dataRow["toDate"].ToString());
            string leaveType= dataRow["leaveType"].ToString(); 
            string status= dataRow["status"].ToString(); 

            leave =new LeaveApplication();
            leave.Id=id;
            leave.EmployeeId=employeeId;
            leave.CreatedOn=createdOn;
            leave.FromDate=fromDate;
            leave.ToDate=toDate;
            leave.LeaveType=leaveType;
            leave.Status=status;
        }
        catch(Exception e){
           throw e;
        }
        return leave;
    }
    
    public bool Insert(LeaveApplication leaveApplication){
        bool status=false;
        MySqlConnection con =new MySqlConnection(_connectionString);
        try{
            string query="select * from leaveapplications";
            MySqlCommand command =new MySqlCommand(query,con);
            MySqlDataAdapter adapter =new MySqlDataAdapter(command);
            DataSet dataSet =new DataSet();
            MySqlCommandBuilder commandBuilder=new MySqlCommandBuilder(adapter);
            adapter.Fill(dataSet);
            DataTable dataTable=dataSet.Tables[0];

            DataRow dataRow = dataTable.NewRow();
            dataRow["id"]=leaveApplication.Id;
            dataRow["employeeid"]=leaveApplication.EmployeeId;
            dataRow["createdon"]=leaveApplication.CreatedOn;
            dataRow["fromdate"]=leaveApplication.FromDate;
            dataRow["todate"]=leaveApplication.ToDate;
            dataRow["leavetype"]=leaveApplication.LeaveType;
            dataRow["status"]=leaveApplication.Status;
            dataTable.Rows.Add(leaveApplication);
            adapter.Update(dataSet);
            status=true;
            }
            catch(Exception e){
                 throw e;
            }
            return status;
        }

    public bool Update(LeaveApplication leaveApplication){
        bool status=false;
        MySqlConnection con =new MySqlConnection(_connectionString);
        try{
            string query ="select * from leaveapplications";
            MySqlCommand command =new MySqlCommand(query,con);
            MySqlDataAdapter adapter =new MySqlDataAdapter(command);
            DataSet dataSet =new DataSet();
            MySqlCommandBuilder commandBuilder=new MySqlCommandBuilder(adapter);
            adapter.Fill(dataSet);
            DataTable dataTable=dataSet.Tables[0];

            DataColumn[] keycolumn =new DataColumn[1];
            keycolumn[0]=dataTable.Columns["id"];
            dataTable.PrimaryKey=keycolumn;

            DataRow dataRow=dataTable.Rows.Find(leaveApplication.Id);
            dataRow["id"]=leaveApplication.Id;
            dataRow["employeeid"]=leaveApplication.EmployeeId;
            dataRow["createdon"]=leaveApplication.CreatedOn;
            dataRow["fromdate"]=leaveApplication.FromDate;
            dataRow["todate"]=leaveApplication.ToDate;
            dataRow["leavetype"]=leaveApplication.LeaveType;
            dataRow["status"]=leaveApplication.Status;
            adapter.Update(dataSet);
            status=true;
        }
        catch(Exception e){
            throw e;
        }
        return status;
    }

     public bool Delete(int id ){
        bool status=false;
        MySqlConnection con =new MySqlConnection(_connectionString);
        try{
            string query ="select * from leaveapplications";
            MySqlCommand command =new MySqlCommand(query,con);
            MySqlDataAdapter adapter =new MySqlDataAdapter(command);
            DataSet dataSet =new DataSet();
            MySqlCommandBuilder commandBuilder=new MySqlCommandBuilder(adapter);
            adapter.Fill(dataSet);
            DataTable dataTable=dataSet.Tables[0];

            DataColumn[] keycolumn =new DataColumn[1];
            keycolumn[0]=dataTable.Columns["id"];
            dataTable.PrimaryKey=keycolumn;

            DataRow dataRow=dataTable.Rows.Find(id);
            dataRow.Delete();
            adapter.Update(dataSet);
            status=true;   
        }
        catch(Exception e){
            throw e;
        }
        return status;
    }
}