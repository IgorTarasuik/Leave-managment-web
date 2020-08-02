using Leave_managment_web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_managment_web.Contracts
{
  public  interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
    }
}
