﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CourseDataAccess.Models;

public partial class Teacher
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Mobile { get; set; }

    public virtual ICollection<Courseschedule> Courseschedules { get; set; } = new List<Courseschedule>();
}