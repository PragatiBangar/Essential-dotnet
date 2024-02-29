using DisconnectedAccessTest.Models;
using DisconnectedAccessTest.service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers;

[ApiController]
[Route("/api/leaves")]
public class LeaveController : ControllerBase
{
    private readonly ILeaveService _service;     
    public LeaveController(ILeaveService service)
    {
        _service = service;
    }

    [HttpGet]
    public List<LeaveApplication> GetLeaves()
    {
        List<LeaveApplication> leaves= _service.GetAll();
        return leaves;
    }

    [HttpGet("leave")]
    public LeaveApplication GetLeaveApplication(int id)
    {
        LeaveApplication leave= _service.GetLeaveApplication(id);
        return leave;
    }

    [HttpPost]
    public bool Insert(LeaveApplication leaveApplication)
    {
        bool status = _service.Insert(leaveApplication);
        return status;
    }

    [HttpPut]
    public bool Update(LeaveApplication leaveApplication)
    {
        bool status = _service.Update(leaveApplication);
        return status;
    }

    [HttpDelete]
    public bool Delete(int id)
    {
        bool status = _service.Delete(id);
        return status;
    }
}
