

namespace Solution1.ClassLibrary1
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Person
    {
        #region Fields
        private int age;
        private string name;
        private string surname;
        #endregion

        #region Properties
        public int Age
        {
            get { return this.age; }

            internal set
            {
                Debug.Assert(condition: value != 0 && value != null);

                this.age = value;
            }

        }

        public string Name
        {
            get { return this.name; }

            internal set
            {
                Debug.Assert(condition: !String.IsNullOrWhiteSpace(value));

                this.name = value;
            }
   
        }

        public PersonsSecondName SecondName { get; set; }


        public string Surname
        {
            get { return this.surname; }

            internal set
            {
                Debug.Assert(condition: !String.IsNullOrWhiteSpace(value));

                this.surname = value;
            }

        }

        

        #endregion

        #region Constructors

        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }

        #endregion

        #region Methods

        public abstract string GetAdditionalDescription();
        public virtual string GetDescription()
        {
            return String.Format("Imię:{0}, Drugie Imię:{1}, Nazwisko:{2}, Wiek:{3} lat", this.Name, this.SecondName, this.Surname, this.Age);
        }

        
       

        #endregion
    }

}
