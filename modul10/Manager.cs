namespace modul10
{
    internal partial class Program
    {
        class Manager : Worker
        {
            public Manager(string firstName, string lastName, string passport, string phoneNumber) :
                base(firstName, lastName, passport, phoneNumber){}

           

            public override string GetPassport(bool isHidden = false)
            {
                if (isHidden)
                {
                    return "**** ******";
                }
                return $"Паспорт: {base.passport}";
            }

            public void SetPassport(string passport)
            {
                SaveChange(WorkerPosition.Manager, base.passport, passport);
                base.passport = passport;
            }
            public void SetFirstName(string firstName)
            {
                SaveChange(WorkerPosition.Manager, base.firstName, firstName);
                base.firstName = firstName;
            }

            public void SetLastName(string lastName)
            {
                SaveChange(WorkerPosition.Manager, base.lastName, lastName);
                base.lastName = lastName;
            }

            public override void SetPhoneNumber(string phoneNumber)
            {
                SaveChange(WorkerPosition.Manager, base.phoneNumber, phoneNumber);
                base.phoneNumber = phoneNumber;
               
            }
        }
    }
}
