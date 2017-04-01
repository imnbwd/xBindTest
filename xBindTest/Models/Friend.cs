using System;
using xBindTest.ViewModels;

namespace xBindTest.Models
{
    public class Friend : BindableBase
    {
        private DateTime _birthDate;
        private string _email;
        private string _name;

        /// <summary>
        /// Get or set BirthDate value
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { SetProperty(ref _birthDate, value); }
        }

        /// <summary>
        /// Get or set Email value
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        /// <summary>
        /// Get or set Name value
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}