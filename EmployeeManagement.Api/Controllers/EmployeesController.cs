﻿using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return Ok(await _employeeRepository.GetEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var result = await _employeeRepository.GetEmployee(id);
                if(result == null) { return NotFound(); }
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
                if(employee == null){
                    return BadRequest();
                }

                // Add custom model validation error
                var emp = await _employeeRepository.GetEmployeeByEmail(employee.Email);Console.WriteLine("emp");

                if(emp!=null){
                    ModelState.AddModelError("email","Employee email already in use");
                    return BadRequest(ModelState);
                }


                var createdEmployee = await _employeeRepository.AddEmployee(employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.EmployeeId}, createdEmployee);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee){
            try{
                if(id != employee.EmployeeId)
                {
                    return BadRequest("Employee ID Mismatch");
                }

                var employeeToUdpate = await _employeeRepository.GetEmployee(id);

                if(employeeToUdpate == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }

                return await _employeeRepository.UpdateEmployee(employee);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Updating Data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id){
            try{
                var employeToDelete = await _employeeRepository.GetEmployee(id);

                if(employeToDelete == null){
                    return NotFound($"Employee with Id = {id} not found");
                }

                return await _employeeRepository.DeleteEmployee(id);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError,"Error deleting data");
            }
        }
    }
}
