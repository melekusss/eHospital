

namespace Solution1.ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class PersonRepository : IPersonRepository
    {
        #region Fields
        private static readonly Person[] people = new Person[]
        {
      
        };
        #endregion


        #region Methods
        public Person[] Find(PersonsSecondName secondName)
        {
            IList<Person> foundPeople = people.Where(s => s.SecondName == secondName).ToList();

            return foundPeople.ToArray();
        }
        #endregion
    }
}
