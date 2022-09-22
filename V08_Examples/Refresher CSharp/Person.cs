// ReSharper disable ConvertToAutoProperty
// ReSharper disable ArrangeAccessorOwnerBody
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global

namespace Refresher_CSharp
{
    using System;

    public class Person
    {
        #region Properties

        private string _lastName;

        public string FirstName { get; set; }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get
            {
                var fullName = LastName + " " + FirstName;
                return fullName;
            }
        }

        public string FullNameInv => FirstName + " " + LastName;

        #endregion

        #region Events

        private string _nickName;

        public string NickName
        {
            get => _nickName;
            set
            {
                _nickName = value;
                OnNameChanged(value);
            }
        }

        public event EventHandler<string> NickNameChanged;

        protected virtual void OnNameChanged(string newName)
        {
            NickNameChanged?.Invoke(this, newName);
        }

        #endregion
    }
}
