using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB_Admin_Razor.Models
{
    [Table("Employee", Schema="HR")]
    public class Employee
    {
        private int employeeId;
        private string loginId;
        private string firstNames;
        private string knownAs;
        private string lastName;
        private char genderId;
        private DateTime birthDate;
        private string email;
        private string phoneNo;
        private DateTime dateStarted;
        private DateTime dateEnded;
        private decimal salary;
        private bool currentFlag;
        private byte photoId;
        private DateTime dateCreated;
        private DateTime dateLastModified;
        private int age;
        private bool retired;


        [ScaffoldColumn(false)]
        [Key]
        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        [ForeignKey("Login")]
        [Column(Order = 1)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please Enter Login Id"), MaxLength(50)]
        [Display(Name = "Employee's Login Id")]
        public string LoginId
        {
            get { return this.loginId; }
            set { this.loginId = value; }
        }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter First Names"), MaxLength(50)]
        [Display(Name = "Employee First Name")]


        public string FirstNames
        {
            get { return this.firstNames; }
            set { this.firstNames = value; }
        }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Name you are commonly know as"), MaxLength(50)]
        [Display(Name = "Employee Know As")]
        public string KnownAs
        {
            get { return this.knownAs; }
            set { this.knownAs = value; }
        }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Last Name"), MaxLength(50)]
        [Display(Name = "Employee Last Name")]
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public char GenderId
        {
            get { return this.genderId; }
            set { this.genderId = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }


        [EmailAddress]
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        [Phone]
        public string PhoneNo
        {
            get { return this.phoneNo; }
            set { this.phoneNo = value; }
        }

        // IGNORE FROM EF MODEL
        [NotMapped]
        public int Age
        {
            get {


                //return null if the date of birth  
                //greater than the current date  
                if (this.birthDate > DateTime.Now)
                    return 0;
                // get the basic number of years  
                int years = DateTime.Now.Year - this.birthDate.Year;
                // adjust the years against this year's  
                // birthday  
                if (DateTime.Now.Month < birthDate.Month ||
                   (DateTime.Now.Month == birthDate.Month &&
                    DateTime.Now.Day < birthDate.Day))
                {
                    years--;
                }
                // Don't return a negative number  
                // for years alive  
                if (years >= 0)
                    return years;
                else
                    return 0;
            }
            set
            {
                // Set retired flag based on age being over 65
                if (this.age > 65)
                    this.retired = true;
                this.age = value;
            }
        }

        //public int Age
        //{
        //    get { return this.age; }
        //    set {
        //        // Set retired flag based on age being over 65
        //        if (this.age > 65)
        //            this.retired = true;
        //        this.age = value;
        //    }
        //}


        public DateTime DateStarted
        {
            get { return this.dateStarted; }
            set { this.dateStarted = value; }

        }

        public DateTime DateEnded
        {
            get { return this.dateEnded; }
            set { this.dateEnded = value; }

        }


        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }

        }
        [Required]
        public bool CurrentFlag
        {
            get { return this.currentFlag; }
            set { this.currentFlag = value; }

        }

        public byte PhotoId
        {
            get { return this.photoId; }
            set { this.photoId = value; }

        }

        public DateTime DateCreated
        {
            get { return this.dateCreated; }
            set { this.dateCreated = value; }

        }

        public DateTime DateLastModified
        {
            get { return this.dateLastModified; }
            set { this.dateLastModified = value; }

        }

    }
}
