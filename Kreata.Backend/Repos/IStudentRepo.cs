﻿using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
        Task<int> GetNumberOfStudentByYearAsync(int year);
        Task<int> GetNumberOfStudentByYearAndMonth(int year, int month);
        Task<string> GetNumberOfStudentByFirstName(string firstName);
    }
}
