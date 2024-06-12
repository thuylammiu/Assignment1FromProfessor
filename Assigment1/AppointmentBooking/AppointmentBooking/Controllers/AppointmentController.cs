﻿using AppointmentBooking.Dtos;
using AppointmentBooking.Entities;
using AppointmentBooking.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace AppointmentBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository appointmentRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IDentisRepository dentisRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository,
                                     IPatientRepository patientRepository,
                                     IDentisRepository dentisRepository)
        {
            this.patientRepository = patientRepository;
            this.dentisRepository = dentisRepository;
            this.appointmentRepository = appointmentRepository;
        }

       
        

        [HttpPost]
        [Route("AddAppointment")]
        public async Task<ActionResult<AppointmentDto>> AddAppointment([FromBody] AppointmentDto dto)
        {

            var entity = dto.Adapt<Appointment>();
            var result = await appointmentRepository.CreateAsync(entity);
            return Ok(result);
        }

        [HttpPost]
        [Route("NewPatient")]
        public async Task<ActionResult<AppointmentDto>> NewPatient([FromBody] PatientDto dto)
        {

            var entity = dto.Adapt<Patient>();
            var result = await patientRepository.CreateAsync(entity);
            return Ok(result);
        }

        [HttpPost]
        [Route("NewDetist")]
        public async Task<ActionResult<AppointmentDto>> NewDetist([FromBody] Dentist dto)
        {

            var entity = dto.Adapt<Dentist>();
            var result = await dentisRepository.CreateAsync(entity);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetListVipAppointment")]
        public async Task<ActionResult<IList<AppointmentDto>>> GetListVipAppointment()
        {
            Expression<Func<Patient, bool>> myLambda = (s) => s.DateOfBirth.Year < DateTime.Now.Year - 65;
            var entities = await patientRepository.GetWithFilter(myLambda, "Patients");
            var result = entities.Adapt<IList<AppointmentDto>>();
            return Ok(result);
        }

        [HttpGet]
        [Route("UpCommingEvents")]
        public async Task<ActionResult<IList<AppointmentDto>>> UpCommingEvents()
        {
            Expression<Func<Appointment, bool>> myLambda = (s) => s.AppointmentDate.ToDateTime(new TimeOnly()) > DateTime.Now;
            var entities = await appointmentRepository.GetWithFilter(myLambda, "Patients");
            var result = entities.Adapt<IList<AppointmentDto>>();
            return Ok(result);
        }
    }
}
