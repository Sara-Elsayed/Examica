﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UI.Examica.Model.Core.Domains;
using UI.Examica.Model.Core.Repository;

namespace UI.Examica.Model.Persistence.Repository
{
    public class ExamAppUserRepo : Repository<ExamAppUser>, IExamAppUserRepo
    {
        public ExamAppUserRepo(DbContext _context) : base(_context)
        {
        }
    }
}
