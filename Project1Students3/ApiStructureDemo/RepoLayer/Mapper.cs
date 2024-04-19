using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModelsLayer;

namespace RepoLayer
{
    internal static class Mapper
    {
        internal static Student DbToStudent(SqlDataReader sdr)
        {
            Student c = new Student();

            try
            {

                c.StudentId = sdr.GetInt32(0);
                c.UserName = sdr.GetString(1);
                c.UserPassword = sdr.GetString(2);
                throw new YourOwnPersonalException();
            }
            catch (YourOwnPersonalException ex)
            {
                Console.WriteLine(ex.message);
            }
            return c;
        }
    }


    internal static class Mapper2
    {
        internal static GradesForm DbToStudent(SqlDataReader sdr)
        {
            GradesForm c = new GradesForm();

            try
            {

                c.GradesFormId = sdr.GetInt32(0);
                c.FirstName = sdr.GetString(1);
                c.LastName = sdr.GetString(2);
                c.UnderGrad = sdr.GetString(3);
                c.OldGrade = sdr.GetString(4);
                c.RDescription = sdr.GetString(5);
                c.RStatus = sdr.GetString(6);
                throw new YourOwnPersonalException();
            }
            catch (YourOwnPersonalException ex)
            {
                Console.WriteLine(ex.message);
            }
            return c;
        }
    }






}