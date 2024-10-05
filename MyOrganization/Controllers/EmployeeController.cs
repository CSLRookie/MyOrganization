﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOrganization.BusinessObject;
using MyOrganization.DataModel;

namespace MyOrganization.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public async Task<List<EmployeeDetails>> GetAllEmployeeDetails()
        {
            try
            {
                List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
                UserDetails userDetails = new UserDetails();
                employeeDetails = await userDetails.GetAllEmployeeDetails();
                if (userDetails != null) { return employeeDetails; }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        [Route("SaveEmployeeDetails")]
        [HttpPost]
        public async Task<List<EmployeeDetails>> SaveEmployeeData([FromBody] EmployeeDetails employeeDetails)
        {
            try
            {
                
                List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
                UserDetails userDetails = new UserDetails();
                empDetails = await userDetails.SaveEmployeeData(employeeDetails);
                return empDetails;
            }
            catch (Exception)
            {

                throw;
            }
            //return Ok(empDetails);
        }

        [Route("UpdateEmployeeDataById")]
        [HttpPost]
        public async Task<List<EmployeeDetails>> UpdateEmployeeDataById([FromBody] EmployeeDetails employeeDetails)
        {
            try
            {
                List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
                UserDetails userDetails = new UserDetails();
                empDetails = await userDetails.UpdateEmployeeDataById(employeeDetails);
                return empDetails;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [Route("DeleteEmployeeDetailsById")]
        [HttpPost]
        public async Task<List<EmployeeDetails>> DeleteEmployeeDetailsById(int employeeId)
        {
            try
            {
                List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
                UserDetails userDetails = new UserDetails();
                employeeDetails = await userDetails.DeleteEmployeeDetailsById(employeeId);
                return employeeDetails;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
