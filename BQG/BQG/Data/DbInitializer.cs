namespace BQG.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { Name = "Amit Singh", Age = 8, DOB = Convert.ToDateTime("2014/07/20"), Standard = 6,Sex = "Male", School = "St. Thomas" },
                new Student { Name = "George McMillan", Age = 9, DOB = Convert.ToDateTime("2015/05/10"), Standard = 7,Sex = "Male", School = "St. Dominic" },
                new Student { Name = "Vince McMahon", Age = 10, DOB = Convert.ToDateTime("2017/02/28"), Standard = 8,Sex = "Male", School = "DBP" },
                new Student { Name = "Paul Levesque", Age = 12, DOB = Convert.ToDateTime("2018/07/05"), Standard = 9,Sex = "Male", School = "Francis College" },
                new Student { Name = "John Cena", Age = 15, DOB = Convert.ToDateTime("2020/07/20"), Standard = 10,Sex = "Male", School = "The Hindu" },
                new Student { Name = "Stephanie McMahon ", Age = 10, DOB = Convert.ToDateTime("2018/04/09"), Standard = 8,Sex = "Female", School = "Angels" },
                new Student { Name = "Shawn Michaels", Age = 9, DOB = Convert.ToDateTime("2016/03/08"), Standard = 9,Sex = "Male", School = "Physics Walla" },
                new Student { Name = "Donald Trump", Age = 13, DOB = Convert.ToDateTime("2014/01/25"), Standard = 10,Sex = "Male", School = "St. Thomas" },
                new Student { Name = "Kamala Harris", Age = 14, DOB = Convert.ToDateTime("2016/09/01"), Standard = 9,Sex = "Female", School = "DPS" },
                new Student { Name = "Melania Trump", Age = 14, DOB = Convert.ToDateTime("2017/05/20"), Standard = 9,Sex = "Female", School = "DPS" }
            };

            context.Student.AddRange(students);
            context.SaveChanges();
        }
    }
}
