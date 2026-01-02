using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterviewAssessmentSystem.Models
{
    [XmlRoot("Candidate")]
    public class Candidate : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _email;
        private DateTime _interviewDate;
        private string _skill1;
        private string _skill2;
        private bool _isSelected;
        private string _comments;

        [XmlElement("FirstName")]
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        [XmlElement("LastName")]
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        [XmlElement("PhoneNumber")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        [XmlElement("Email")]
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        [XmlElement("InterviewDate")]
        public DateTime InterviewDate
        {
            get => _interviewDate;
            set
            {
                _interviewDate = value;
                OnPropertyChanged(nameof(InterviewDate));
            }
        }

        [XmlElement("Skill1")]
        public string Skill1
        {
            get => _skill1;
            set
            {
                _skill1 = value;
                OnPropertyChanged(nameof(Skill1));
            }
        }

        [XmlElement("Skill2")]
        public string Skill2
        {
            get => _skill2;
            set
            {
                _skill2 = value;
                OnPropertyChanged(nameof(Skill2));
            }
        }

        [XmlElement("IsSelected")]
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
                OnPropertyChanged(nameof(Status));
            }
        }

        [XmlElement("Comments")]
        public string Comments
        {
            get => _comments;
            set
            {
                _comments = value;
                OnPropertyChanged(nameof(Comments));
            }
        }

        // Computed property for display
        [XmlIgnore]
        public string Status => IsSelected ? "Selected" : "Rejected";

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}