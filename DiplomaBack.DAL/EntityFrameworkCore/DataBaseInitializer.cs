using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiplomaBack.DAL.Entities;

namespace DiplomaBack.DAL.EntityFrameworkCore
{
    public class DataBaseInitializer
    {
        private const string UrlApi = "http://localhost:59323/";

        public static void Initialize(DataBaseContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Login = "Jeka9999",
                        FirstName = "Евгений",
                        SecondName = "Кураев",
                        MiddleName = "Федорович",
                        Email = "eetteg@gmail.com"
                    },
                    new User
                    {
                        Login = "Mosya",
                        FirstName = "Моисеенко",
                        SecondName = "Артем",
                        MiddleName = "Михайлович",
                        Email = "eetteg@gmail.com"

                    },
                    new User
                    {
                        Login = "Dimkin7",
                        FirstName = "Дмитрий",
                        SecondName = "Селезнев",
                        MiddleName = "Никифорович",
                        Email = "eetteg@gmail.com"
                    },
                    new User
                    {
                        Login = "Bardik",
                        FirstName = "Владислав",
                        SecondName = "Бардамид",
                        MiddleName = "Юрьевич",
                        Email = "eetteg@gmail.com"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Tutors.Any())
            {
                context.Tutors.AddRange(
                    new Tutor
                    {
                        UserId = 0,
                        CountPluses = 0,
                        CountMinuses = 0
                    }
                );
                context.SaveChanges();
            }

            if (!context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subject
                    {
                        FileId = 0,
                        Name = "Математика",
                        Url = "Mathematics",
                    },
                    new Subject
                    {
                        FileId = 0,
                        Name = "Физика",
                        Url = "Physics"
                    },
                    new Subject
                    {
                        FileId = 0,
                        Name = "Геометрия"
                    },
                    new Subject
                    {
                        FileId = 0,
                        Name = "Английский язык"
                    },
                    new Subject
                    {
                        FileId = 0,
                        Name = "Экономика"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Lessons.Any())
            {
                context.Lessons.AddRange(
                    new Lesson
                    {
                        UserId = 1,
                        SubjectId = 0,
                        TutorId = 0,
                        TimeOfStart = DateTime.Now,
                        TimeOfEnd = DateTime.Now.AddHours(1),
                    },
                    new Lesson
                    {
                        UserId = 2,
                        SubjectId = 0,
                        TutorId = 0,
                        TimeOfStart = DateTime.Now,
                        TimeOfEnd = DateTime.Now.AddHours(1),
                    },
                    new Lesson
                    {
                        UserId = 3,
                        SubjectId = 0,
                        TutorId = 0,
                        TimeOfStart = DateTime.Now,
                        TimeOfEnd = DateTime.Now.AddHours(1),
                    }
                );
                context.SaveChanges();
            }

            if (!context.Comments.Any())
            {
                context.Comments.AddRange(
                    new Comment
                    {
                        UserId = 1,
                        TutorId = 0,
                        Text = "Мне понравилось"
                    },
                    new Comment
                    {
                        UserId = 2,
                        TutorId = 0,
                        Text = "10 из 10"
                    },
                    new Comment
                    {
                        UserId = 3,
                        TutorId = 0,
                        Text = "Невероятно!"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Files.Any())
            {
                context.Files.AddRange(
                    new File
                    {
                        Path = $"{UrlApi}Files/Subjects/Physics.jpg"
                    },
                    new File
                    {
                        Path = $"{UrlApi}Files/Subjects/Physics.jpg"
                    },
                    new File
                    {
                        Path = $"{UrlApi}Files/Subjects/Physics.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}