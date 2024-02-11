﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        //Constructor
        public PttManager(IApplicantService applicantService) 
        {_applicantService = applicantService;}


        public void GiveMask(Person person) {
            PersonManager personManager=new PersonManager();
            if (personManager.CheckPerson(person))
            { 
                Console.WriteLine(person.FirstName + "için maske verildi"); 
            } else
            {
                Console.WriteLine("Maske Verilemedi.");
            }

        }

    }
}
