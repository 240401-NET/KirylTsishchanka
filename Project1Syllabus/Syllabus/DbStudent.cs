using System;
using System.Collections.Generic;

namespace Project1Syllabus;

public partial class DbStudent
{
    public int? IdNumber { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public decimal? Attendance { get; set; }

    public decimal? Quiz { get; set; }

    public decimal? Midterm1 { get; set; }

    public decimal? Midterm2 { get; set; }

    public decimal? FinalExam { get; set; }

    public decimal? Total { get; set; }

    public string? LetterGrade { get; set; }
}
