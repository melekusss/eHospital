

namespace Solution1.ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    public class Doctor : Person
    {
        #region Properties

        public int Id { get;  set; }
        public int Salary { get;  set; }
        public string MainSpecialization { get;  set; }
        public int YearsOfWork { get;  set; }

        public List<Specialization> Specialization { get;  set; } = new List<Specialization>();


        #endregion

        #region Constructors
        public Doctor(int Id, int salary, string mainspecialization, int yearsOfWork, string name, string surname, int age) : base(name, surname, age)
        {
            Debug.Assert(condition: !String.IsNullOrWhiteSpace(mainspecialization) && salary>0 && yearsOfWork > 0);
            this.Id = Id;
            this.Salary = salary;
            this.MainSpecialization = mainspecialization;
            this.YearsOfWork = yearsOfWork;
            

        }
        public Doctor(int Id, int salary, string mainspecialization, int yearsOfWork, string name, string surname, int age, List<Specialization> specialization) : base(name, surname, age)
        {
            Debug.Assert(condition: !String.IsNullOrWhiteSpace(mainspecialization) && salary > 0 && yearsOfWork > 0);
            this.Id = Id;
            this.MainSpecialization = mainspecialization;
            this.YearsOfWork = yearsOfWork;
            this.Salary = salary;
            this.Specialization = specialization;
        }
        
        #endregion

        #region Methods
        public override string GetAdditionalDescription()
        {
            return String.Format("Specjalizacja:{0}, Staż pracy:{1} lat, Wypłata:{2} zł", this.MainSpecialization, this.YearsOfWork, this.Salary);
        }
        #endregion
        public void AddSpecialization(IEnumerable<Specialization> specializations)
        {
            foreach (var specialization in specializations)
                Specialization.Add(specialization);
        }

    }
}
