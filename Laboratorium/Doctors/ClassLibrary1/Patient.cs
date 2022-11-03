

namespace Solution1.ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    public class Patient : Person
    {
        #region Properties
        public string Disease { get; private set; }
        public int RoomNumber { get; private set; }
        public double VisitPayment { get; private set; }
        #endregion

        #region Constructors
        public Patient(string name, string surname, int age, string disease, int roomNumber, int visitPayment) : base(name, surname, age)
        {
            Debug.Assert(condition: !String.IsNullOrWhiteSpace(disease) && visitPayment>=0);

            this.Disease = disease;
            this.VisitPayment = visitPayment;
            this.RoomNumber = roomNumber;
        }


        #endregion

        #region Methods
        public override string GetAdditionalDescription()
        {
            return String.Format("Choroba:{0}, Pokój wizyty:{1}, Opłata za wizytę:{2} zł", this.Disease, this.RoomNumber, this.VisitPayment);
        }
        #endregion

    }
}
