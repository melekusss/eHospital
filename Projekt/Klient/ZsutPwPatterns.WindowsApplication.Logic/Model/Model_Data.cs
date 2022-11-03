namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public partial class Model : IData
    {
        public string SearchText
        {
            get { return this.searchText; }
            set
            {
                this.searchText = value;

                this.RaisePropertyChanged("SearchText");
            }
        }
        private string searchText;

        public string SearchPrescriptionDoctorId
        {
            get { return this.searchPrescriptionDoctorId; }
            set
            {
                this.searchPrescriptionDoctorId = value;

                this.RaisePropertyChanged("SearchPrescriptionDoctorId ");
            }
        }
        private string searchPrescriptionDoctorId;


        public string SearchVisitDoctorId
        {
            get { return this.searchVisitDoctorId; }
            set
            {
                this.searchVisitDoctorId = value;

                this.RaisePropertyChanged("SearchVisitDoctorId ");
            }
        }
        private string searchVisitDoctorId;

        public string SearchFavouritePatientDoctorId
        {
            get { return this.searchFavouritePatientDoctorId; }
            set
            {
                this.searchFavouritePatientDoctorId = value;

                this.RaisePropertyChanged("SearchFavouritePatientDoctorId ");
            }
        }
        private string searchFavouritePatientDoctorId;


        public List<FavouritePatientData> FavouritePatientsList
        {
            get { return this.favouritePatientsList; }
            private set
            {
                this.favouritePatientsList = value;

                this.RaisePropertyChanged("FavouritePatientsList");
            }
        }
        private List<FavouritePatientData> favouritePatientsList = new List<FavouritePatientData>();


        public List<VisitData> VisitList
        {
            get { return this.visitList; }
            private set
            {
                this.visitList = value;

                this.RaisePropertyChanged("VisitList");
            }
        }
        private List<VisitData> visitList = new List<VisitData>();


        public List<PrescriptionData> PrescriptionList
        {
            get { return this.prescriptionList; }
            private set
            {
                this.prescriptionList = value;

                this.RaisePropertyChanged("PrescriptionList");
            }
        }
        private List<PrescriptionData> prescriptionList = new List<PrescriptionData>();

        public FavouritePatientData SelectedFavouritePatientData
        {
            get { return this.selectedFavouritePatientData; }
            set
            {
                this.selectedFavouritePatientData = value;

                this.RaisePropertyChanged("SelectedFavouritePatientData");
            }
        }
        private FavouritePatientData selectedFavouritePatientData;


        public VisitData SelectedVisitData
        {
            get { return this.selectedVisitData; }
            set
            {
                this.selectedVisitData = value;

                this.RaisePropertyChanged("SelectedVisitData");
            }
        }
        private VisitData selectedVisitData;

        public PrescriptionData SelectedPrescriptionData
        {
            get { return this.selectedPrescriptionData; }
            set
            {
                this.selectedPrescriptionData = value;

                this.RaisePropertyChanged("SelectedPrescriptionData");
            }
        }
        private PrescriptionData selectedPrescriptionData;


        public TemporaryPrescriptionData AssignedPrescriptionData
        {
            get { return this.assignedPrescriptionData; }
            set
            {
               
                this.assignedPrescriptionData = value;

                this.RaisePropertyChanged("AssignedPrescriptionData");
            }
        }

        private TemporaryPrescriptionData assignedPrescriptionData= new TemporaryPrescriptionData();

    }
}
