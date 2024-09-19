﻿using SchoolClassManagmentProject.Models.AppException;
using SchoolClassManagmentProject.Models.Entities;

/*SchoolClass schoolClass9a = new SchoolClass(9,'a',12);
SchoolClass schoolClass9b = new SchoolClass(9, 'b', 13);
SchoolClass schoolClass10a = new SchoolClass(10, 'a',12);
SchoolClass schoolClass10b = new SchoolClass(10, 'c', 12);

SchoolClass schoolClass12a = new SchoolClass(12, 'a', 12);
SchoolClass schoolClass12b = new SchoolClass(12, 'b', 12);

SchoolClass schoolClass13a = new SchoolClass(13, 'a', 13);
SchoolClass schoolClass13b = new SchoolClass(13, 'b', 13);

try
{
    schoolClass9a.SetLastGrade(1);
}
catch (LastGradeModificationErrorException lastGradeModificationError)
{
    Console.WriteLine(lastGradeModificationError.ParamName);
    Console.WriteLine(lastGradeModificationError.Message);

}

schoolClass9a.AdvanceGrade();
Console.WriteLine(schoolClass9a.Name);*/

Student student1 = new Student("Nagy","Jani",new DateTime(2005,07,07),true,"06201234567");
Console.WriteLine(student1.EnglishName());
Console.WriteLine(student1.HungarianName());
Console.WriteLine(student1.StudentAge());
if (student1.HasEmail())
    Console.WriteLine("Van e-mail címe");
else
    Console.WriteLine("Nincs e-mail címe");