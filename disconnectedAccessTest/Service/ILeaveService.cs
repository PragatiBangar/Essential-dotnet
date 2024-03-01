using DisconnectedAccessTest.Models;

namespace DisconnectedAccessTest.service.Interface;
public interface ILeaveService{

    public List<LeaveApplication> GetAll();

    public LeaveApplication GetLeaveApplication(int id);

    public bool Insert(LeaveApplication leaveApplication);

    public bool Update(LeaveApplication leaveApplication);
     
    public bool Delete(int id );

}