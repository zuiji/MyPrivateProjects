using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElevCSV
{
    public class Student
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _email;
        private string _cprNr;
        private string _phoneNumber;
        private string _specialInfo;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^((?!\d)(?!;).){2,100}$"))
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentException("The first name is invalid");
                }
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    value = "";
                }
                if (Regex.IsMatch(value, @"^((?!\d)(?!;).)*$"))
                {
                    _middleName = value;
                }
                else
                {
                    throw new ArgumentException("The middle name is invalid");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^((?!\d)(?!;).){2,100}$"))
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("The last name is invalid");
                }

            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"))
                {
                    _email = value;

                }
                else
                {
                    throw new ArgumentException("The Email is invalid");
                }
            }
        }

        public string CprNr
        {
            get { return _cprNr; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[0-3][0-9][0-1][0-9]{3}-?[0-9]{4}$"))
                {
                    _cprNr = value;

                }
                else
                {
                    throw new ArgumentException("The CPR number is invalid");
                }

            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(((([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?[0-9]{3})([-\s\.]?[0-9]{3,4}))|(\d{8}))$"))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("The Phone number is invalid");
                }

            }
        }
        public string SpecialInfo
        {
            get { return _specialInfo; }
            set
            {
                if (value == null)
                {
                    value = "";
                }

                if (value.Contains(";"))
                {
                    throw new ArgumentException("Cant contain ;");
                }
                _specialInfo = value;
            }
        }
        public string EUX { get; set; }
        public string WantedSkpLocation { get; set; }
        public string GfSchool { get; set; }
        public string EducationDirection { get; set; }

        //enum eux
        //{
        //    ja,
        //    nej
        //}

        //enum wantedSkpLocation
        //{
        //    Slagelse,
        //    Roskilde,
        //    Ringsted,
        //    Vordingborg
        //}

        //enum GFSchool
        //{
        //    Køge,
        //    Ringsted,
        //    Roskilde,
        //    Slagelse,
        //    Vordingborg
        //}

        //enum educationDirection
        //{
        //    ITSupporter,
        //    DatateknikerMedSpecialeIProgrammering,
        //    DatateknikerMedSpecialeIInfrastruktur
        //}
       
    }
}
